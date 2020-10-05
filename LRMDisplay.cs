using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LandingRateMonitor
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
        public LRMDisplay(int FPM)
        {
            InitializeComponent();
            LandingRateLabel.Text = FPM.ToString() + "fpm";
            timerClose.Start();
        }

        private void LRMDisplay_Load(object sender, EventArgs e)
        {

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Stop();
            this.Close();
        }
    }
}
