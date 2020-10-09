using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CTrue.FsConnect;
using Microsoft.FlightSimulator.SimConnect;
using System.Linq;
using System.Diagnostics;
using Octokit;
using FontAwesome.Sharp;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Concurrent;

namespace LandingRateMonitor
{
    public enum Requests
    {
        PlaneInfo = 0
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct PlaneInfoResponse
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public String Title;
        public bool OnGround;
        public double WindLat;
        public double WindHead;
        public double AirspeedInd;
        public double GroundSpeed;
        public double LateralSpeed;
        public double ForwardSpeed;
        public double Gforce;
        public double Radio;
    }

    public partial class FormMain : Form
    {
        #region Exception Handlers and Logging
        static public void UnhandledThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            HandleUnhandledException(e.Exception);
        }

        static public void HandleUnhandledException(Exception e)
        {
            MessageBox.Show(e.Message);
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string logout = "\n\n" + DateTime.Now.ToString() + "\n" + System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion + "\n" +
                e.Message + "\n" + e.Source + "\n" + e.StackTrace;
            System.IO.File.AppendAllText(@"./log.txt", logout);
        }

        #endregion

        #region Publics and statics
        static bool ShowLanding = false;
        static bool SafeToRead = true;
        static List<PlaneInfoResponse> Inair = new List<PlaneInfoResponse>();
        static List<PlaneInfoResponse> Onground = new List<PlaneInfoResponse>();
        static FsConnect fsConnect = new FsConnect();
        static List<SimProperty> definition = new List<SimProperty>();
        static string updateUri;
        int lastDeactivateTick;
        bool lastDeactivateValid;

        const int SAMPLE_RATE = 20; //ms
        const int BUFFER_SIZE = 10;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            labelVersion.Text = fvi.FileVersion;

            timerRead.Interval = SAMPLE_RATE;
            button1.Select();
            iconGithub.BackgroundImage = IconChar.Github.ToBitmap(32, Color.White);
            iconReddit.BackgroundImage = IconChar.Reddit.ToBitmap(32, Color.White);
            iconFAS.BackgroundImage = IconChar.FontAwesome.ToBitmap(32, Color.White);
            iconDown.BackgroundImage = IconChar.ArrowDown.ToBitmap(32, Color.White);

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width-20,
                                      workingArea.Bottom - Size.Height-20);
            backgroundWorkerUpdate.RunWorkerAsync();
            fsConnect.FsDataReceived += HandleReceivedFsData;
            definition.Add(new SimProperty("Title", null, SIMCONNECT_DATATYPE.STRING256));
            definition.Add(new SimProperty("SIM ON GROUND", "Bool", SIMCONNECT_DATATYPE.INT32));
            definition.Add(new SimProperty("AIRCRAFT WIND X", "Knots", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("AIRCRAFT WIND Z", "Knots", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("AIRSPEED INDICATED", "Knots", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("GROUND VELOCITY", "Knots", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("VELOCITY BODY X", "Feet per second", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("VELOCITY BODY Z", "Feet per second", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("G FORCE", "GForce", SIMCONNECT_DATATYPE.FLOAT64));
            definition.Add(new SimProperty("PLANE ALT ABOVE GROUND", "Feet", SIMCONNECT_DATATYPE.FLOAT64));
        }

        #region Reading and processing the Simconnect data



        private void timerRead_Tick(object sender, EventArgs e)
        {
            if (!ShowLanding)
            {
                try
                {
                    fsConnect.RequestData(Requests.PlaneInfo);
                }
                catch
                {
                }
            }
            else
            {
                timerWait.Start();
            }
        }

        private static void HandleReceivedFsData(object sender, FsDataReceivedEventArgs e)
        {
            if (!SafeToRead)
            {
                Console.WriteLine("lost one");
                return;
            }
            SafeToRead = false;
            try
            {
                if (e.RequestId == (uint)Requests.PlaneInfo)
                {
                    if (!ShowLanding)
                    {
                        PlaneInfoResponse r = (PlaneInfoResponse)e.Data;
                        //ignore when noone is flying
                        if (r.GroundSpeed == 0)
                        {
                            SafeToRead = true;
                            return;
                        }
                        if (r.OnGround)
                        {
                            Onground.Add(r); 
                            if (Onground.Count > BUFFER_SIZE)
                            {
                                Onground.RemoveAt(0);
                                if (Inair.Count == BUFFER_SIZE)
                                {
                                    ShowLanding = true;
                                }
                            }
                        }
                        else
                        {
                            Inair.Add(r);
                            if (Inair.Count > BUFFER_SIZE)
                            {           
                                Inair.RemoveAt(0);
                            }
                            Onground.Clear();
                        }
                        if (Inair.Count > BUFFER_SIZE || Onground.Count > BUFFER_SIZE) //maximum 1 for race condition
                        {
                            Inair.Clear();
                            Onground.Clear();
                            throw new Exception("this baaad");
                        }
                        // POnGround = r.OnGround;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            SafeToRead = true;
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            //impact calculation
            try
            {
                double sample_time = Convert.ToDouble(SAMPLE_RATE) * 0.001; //ms
                double fpm = 60 * (Inair.ElementAt(BUFFER_SIZE / 2).Radio - Onground.ElementAt(BUFFER_SIZE / 2).Radio) / (sample_time * Convert.ToDouble(BUFFER_SIZE));
                Int32 FPM = Convert.ToInt32(-fpm);
                
                double gees = 0;
                int Gforcemeterlen = 100 / SAMPLE_RATE; // take 100ms average for G force
                for (int i = 0; i < Gforcemeterlen; i++)
                {
                    gees += Onground.ElementAt(i).Gforce;
                }
                gees /= Gforcemeterlen;

                double incAngle = Math.Atan(Inair.Last().LateralSpeed / Inair.Last().ForwardSpeed) * 180 / Math.PI;

                LRMDisplay form = new LRMDisplay(FPM, gees, Inair.Last().AirspeedInd, Inair.Last().GroundSpeed, Inair.Last().WindHead, Inair.Last().WindLat, incAngle);
                form.Show();
                timerWait.Stop();
                Inair.Clear();
                Onground.Clear();
                ShowLanding = false;
            }
            catch
            {
                //some params are missing. likely the user is in the main menu. ignore
            }
         }
        #endregion

        #region AutoConnection to sim
        private void timerConnection_Tick(object sender, EventArgs e)
        {
            if (!backgroundConnector.IsBusy)
                backgroundConnector.RunWorkerAsync();

            if (fsConnect.Connected)
            {
                timerRead.Start();
                iconConnStatus.BackgroundImage = Properties.Resources.connected;
                labelConn.Text = "Connected";
                this.Icon = Properties.Resources.online;
                notifyIcon.Icon = Properties.Resources.online;
            }
            else
            {
                iconConnStatus.BackgroundImage = Properties.Resources.disconnected;
                labelConn.Text = "No Running Sim Detected";
                this.Icon = Properties.Resources.offline;
                notifyIcon.Icon = Properties.Resources.offline;
            }
        }

        private void backgroundConnector_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!fsConnect.Connected)
            {
                try
                {
                    fsConnect.Connect("TestApp", "localhost", 500);
                    fsConnect.RegisterDataDefinition<PlaneInfoResponse>(Requests.PlaneInfo, definition);
                }
                catch { } // ignore
            }
        }
        #endregion

        #region Form Events and buttons/links

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e) //testing testing
        {
            /*int[] k = { 2, 3 };
            int i = k[10]; //duuuuh*/
            LRMDisplay form = new LRMDisplay(-100, 1.03, 65, 67, -5, -5, -2.34);
            form.Show();
        }
        private void iconReddit_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("https://www.reddit.com/r/MSFS2020LandingRate/");
        }

        private void iconGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/scelts/msfslandingrate");
        }

        private void iconFAS_Click(object sender, EventArgs e)
        {
            Process.Start("https://fontawesome.com/");
        }

        #endregion

        #region Update checks from github
        private void linkLabelUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(updateUri);
        }

        private void backgroundWorkerUpdate_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("EncryptiorDotNetApp"));
            var releases = client.Repository.Release.GetAll("scelts", "msfslandingrate").Result;
            var latest = releases[0];
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            if (version != latest.TagName)
            {
                e.Result = latest;
            }
            else
            {
                e.Result = null;
            }
        }

        private void backgroundWorkerUpdate_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
              //  MessageBox.Show(e.Error.Message);
                //error handler, tbd
            }
            else
            {
                if (e.Result != null)
                {
                    labelVersion.Visible = false;
                    linkLabelUpdate.Visible = true;
                    updateUri = (e.Result as Release).HtmlUrl;
                }
            }
        }
        #endregion

        #region Eye candies, show/hide/minimise tray

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            lastDeactivateTick = Environment.TickCount;
            lastDeactivateValid = true;
            this.Hide();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (this.Visible)
            {
                AnimateWindow(this.Handle, 200, AW_BLEND);
            }
            else
            {
                AnimateWindow(this.Handle, 200, AW_BLEND | AW_HIDE);
            }
            base.OnVisibleChanged(e);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (lastDeactivateValid && Environment.TickCount - lastDeactivateTick < 1000) return;
            this.Show();
            this.Activate();
        }

        const int AW_SLIDE = 0X40000;

        const int AW_VER_POSITIVE = 0X4;

        const int AW_VER_NEGATIVE = 0X8;

        const int AW_HIDE = 65536;
        const int AW_BLEND = 0x00080000;

        [DllImport("user32")]

        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        #endregion
    }
}

