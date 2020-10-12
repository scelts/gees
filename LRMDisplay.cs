using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FontAwesome;
using FontAwesome.Sharp;

namespace Gees
{
    public partial class LRMDisplay : Form
    {
        const int AW_SLIDE = 0X40000;

        const int AW_HOR_POSITIVE = 0X1;

        const int AW_HOR_NEGATIVE = 0X2;

        const int AW_HIDE = 65536;

        [DllImport("user32")]

        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        protected override void OnLoad(EventArgs e)

        {
            //Animate form

            AnimateWindow(this.Handle, 200, AW_SLIDE | AW_HOR_POSITIVE);

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            AnimateWindow(this.Handle, 200, AW_SLIDE | AW_HOR_NEGATIVE | AW_HIDE);

            base.OnClosing(e);
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;

                const int WS_EX_NOACTIVATE = 0x08000000;
                const int WS_EX_TOOLWINDOW = 0x00000080;
                baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);

                return baseParams;
            }
        }
        public LRMDisplay(int FPM, double Gees, double Airspeed, double Groundspeed, double Headwind, double Crosswind, double Slip)
        {
            InitializeComponent();
            iconPictureFPM.BackgroundImage = IconChar.PlaneArrival.ToBitmap(32, Color.White);
            labelFPM.Text = FPM.ToString("0 fpm");
            if (Gees < 1.3)
            {
                iconPictureGees.BackgroundImage = IconChar.Smile.ToBitmap(32, Color.White);
            }
            else if (Gees < 2)
            {
                iconPictureGees.BackgroundImage = IconChar.Meh.ToBitmap(32, Color.White);
            }
            else
            {
                iconPictureGees.BackgroundImage = IconChar.Tired.ToBitmap(32, Color.White);
            }
            labelGEES.Text = Gees.ToString("0.##G");
            iconPictureAirSpeed.BackgroundImage = IconChar.TachometerAlt.ToBitmap(32, Color.White);
            labelAIRV.Text = String.Format("{0} kt Air - {1} kt Ground", Convert.ToInt32(Airspeed), Convert.ToInt32(Groundspeed));
            //iconPictureWind.BackgroundImage = IconChar.LongArrowAltDown.ToBitmap(32, Color.Black);
            double windangle = Math.Atan2(Crosswind, Headwind) * 180 / Math.PI;
            double windamp = Math.Sqrt(Crosswind * Crosswind + Headwind * Headwind);
            Graphics windDir = Graphics.FromImage(iconPictureWind.BackgroundImage);
            windDir.TranslateTransform(16, 16);
            windDir.RotateTransform(Convert.ToInt32(windangle));
            windDir.TranslateTransform(-16, -16);
            windDir.DrawImage(iconPictureWind.BackgroundImage, new PointF(0,0));
            labelWIND.Text = Convert.ToInt32(windamp) + " kt";
            labelANG.Text = Slip.ToString("0.##º Left Sideslip; 0.##º Right Sideslip;");
            if (Properties.Settings.Default.AutoClose)
            {
                timerClose.Interval = Convert.ToInt32(Properties.Settings.Default.CloseAfter) * 1000;
                timerClose.Start();
            }
        }

        private void LRMDisplay_Load(object sender, EventArgs e)
        {

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Stop();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
