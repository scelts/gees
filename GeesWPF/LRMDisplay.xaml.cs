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

namespace GeesWPF
{
    /// <summary>
    /// Interaction logic for LRMDisplay.xaml
    /// </summary>
    public partial class LRMDisplay : Window
    {
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
    }
}
