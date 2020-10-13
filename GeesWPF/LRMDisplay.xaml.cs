using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Interop;

namespace GeesWPF
{
    /// <summary>
    /// Interaction logic for LRMDisplay.xaml
    /// </summary>
    public partial class LRMDisplay : Window
    {
        #region Don't ever take focus
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            //Set the window style to noactivate.
            var helper = new WindowInteropHelper(this);
            SetWindowLong(helper.Handle, GWL_EXSTYLE,
                GetWindowLong(helper.Handle, GWL_EXSTYLE) | WS_EX_NOACTIVATE);
        }

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_NOACTIVATE = 0x08000000;

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        #endregion

        DispatcherTimer timerClose = new DispatcherTimer();
        public LRMDisplay(ViewModel landingModel)
        {
            this.DataContext = landingModel;
            InitializeComponent();
            timerClose.Tick += AutoHide;
        }

        public void AutoHide(object sender, EventArgs e)
        {
            this.BeginStoryboard(FindResource("hide") as Storyboard);
            timerClose.Stop();
        }

        public void SlideLeft()
        {
            timerClose.Interval = new TimeSpan(0, 0, Properties.Settings.Default.CloseAfterLanding);
            if (Properties.Settings.Default.AutoCloseLanding)
            {
                timerClose.Start();
            }
            this.BeginStoryboard(FindResource("show") as Storyboard);
        }
        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.BeginStoryboard(FindResource("hide") as Storyboard);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Width < 350)
            {
                SlideLeft();
            }
        }
    }
}
