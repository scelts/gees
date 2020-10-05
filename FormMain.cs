using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CTrue.FsConnect;
using Microsoft.FlightSimulator.SimConnect;
using System.Speech.Synthesis;
using System.Linq;
using System.Diagnostics;

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
        public double VX1;
        public double VY1;
        public double VZ1;
        public double VX2;
        public double VY2;
        public double VZ2;
        public double VX3;
        public double VY3;
        public double VZ3;
        public double Ax;
        public double Ay;
        public double Az;
        public double Radio;
    }

    public partial class FormMain : Form
    {
        static bool ShowLanding = false;
        static Queue<double> Inair = new Queue<double>();
        static Queue<double> Onground = new Queue<double>();
        static Queue<double> RadarAlt = new Queue<double>();
        static FsConnect fsConnect = new FsConnect();
        static List<SimProperty> definition = new List<SimProperty>();
        static Form mainForm; 

        public FormMain()
        {
            InitializeComponent();
            fsConnect.FsDataReceived += HandleReceivedFsData;
            definition.Add(new SimProperty("Title", null, SIMCONNECT_DATATYPE.STRING256));
            definition.Add(new SimProperty("SIM ON GROUND", "Bool", SIMCONNECT_DATATYPE.INT32));
            definition.Add(new SimProperty("STRUCT WORLDVELOCITY", "Feet per second", SIMCONNECT_DATATYPE.XYZ));
            definition.Add(new SimProperty("STRUCT BODY VELOCITY", "Feet per second", SIMCONNECT_DATATYPE.XYZ));
            definition.Add(new SimProperty("STRUCT SURFACE RELATIVE VELOCITY", "Feet per second", SIMCONNECT_DATATYPE.XYZ));
            definition.Add(new SimProperty("STRUCT WORLD ACCELERATION", "Feet per second squared", SIMCONNECT_DATATYPE.XYZ));
            definition.Add(new SimProperty("RADIO HEIGHT", "Feet", SIMCONNECT_DATATYPE.FLOAT64));
        }

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
            try
            {
                if (e.RequestId == (uint)Requests.PlaneInfo)
                {
                    if (!ShowLanding)
                    {
                        PlaneInfoResponse r = (PlaneInfoResponse)e.Data;
                        Console.WriteLine(r.Title);
                        Console.WriteLine(r.Radio);
                        //FPM1 = (Convert.ToInt32(r.VY1 * 60));
                        /*    FPM2 = (Convert.ToInt32(r.VY2 * 60));
                            FPM3 = (Convert.ToInt32(r.VY3 * 60));
                            double speed = Math.Sqrt(r.VX1 * r.VX1 + r.VY1 * r.VY1 + r.VZ1 * r.VZ1);
                            double A = Math.Sqrt(r.Ax * r.Ax + r.Ay * r.Ay + r.Az * r.Az);
                            Console.WriteLine($"{FPM1} {speed} {A}");*/

                        if (r.OnGround)
                        {
                            Onground.Enqueue(r.VY3);
                            RadarAlt.Enqueue(r.Radio);
                            if (RadarAlt.Count() > 20)
                            {
                                RadarAlt.Dequeue();
                            }
                            if (Onground.Count > 5)
                            {
                                Onground.Dequeue();
                                if (Inair.Count == 10)
                                {
                                    ShowLanding = true;
                                }
                            }
                            /*if (!POnGround)
                            {
                               // ShowLanding = true;
                                Console.WriteLine("#################################################");
                            }*/
                        }
                        else
                        {
                            Inair.Enqueue(r.VY3);
                            if (Inair.Count > 10)
                            {
                                Inair.Dequeue();
                            }
                            Onground.Clear();
                            RadarAlt.Enqueue(r.Radio);
                            if (RadarAlt.Count > 10)
                            {
                                RadarAlt.Dequeue();
                            }
                        }
                        // POnGround = r.OnGround;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            Double fpm = Inair.Average() - Onground.Average();
            Console.WriteLine(Inair.Average());
            Console.WriteLine(Onground.Average());
            Int32 FPM1 = Convert.ToInt32(fpm * 60);
            Int32 FPM = Convert.ToInt32(60 * (RadarAlt.ElementAt(5) - RadarAlt.ElementAt(10)) / 0.07);
            Console.WriteLine($"############{FPM1} {FPM}");
            LRMDisplay form = new LRMDisplay(FPM);
            form.Show();
            timerWait.Stop();
            Inair.Clear();
            Onground.Clear();
            RadarAlt.Clear();
            ShowLanding = false;

            /*   SpeechSynthesizer synthesizer = new SpeechSynthesizer();
               synthesizer.Volume = 100;  // 0...100
               synthesizer.Rate = 0;     // -10...10
               string text = FPM + " fpm";
               // Asynchronous
               synthesizer.SpeakAsync(text);*/
        }


        private void timerConnection_Tick(object sender, EventArgs e)
        {
            if (!backgroundConnector.IsBusy)
                backgroundConnector.RunWorkerAsync();

            if (fsConnect.Connected)
            {
                timerRead.Start();
                connectedLabel.Text = "Connected";
                connectedLabel.ForeColor = Color.Green;
                this.Icon = Properties.Resources.online;
                notifyIcon.Icon = Properties.Resources.online;
            }
            else
            {
                connectedLabel.Text = "Disconnected";
                connectedLabel.ForeColor = Color.Red;
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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {  
            e.Cancel = true;
            Hide();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LRMDisplay form = new LRMDisplay(100);
            form.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/r/MSFS2020LandingRate/");
        }
    }
}

