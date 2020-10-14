using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace GeesWPF
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
        private bool updatable = false;
        private string planeFilter = "";
        private DataTable logTable = new DataTable();
        public ViewModel()
        {
            Connected = false;
            updatable = false;
            UpdateTable();
        }
        #region Main Form Data
        public string Version
        {
            get {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                string myversion = fvi.FileVersion;
                return myversion; 
            }
        }

        bool connected;
        public bool Connected {
            get
            {
                return connected;
            }
            set
            {
                connected = value;
                OnPropertyChanged();
            }
        }

        public string ConnectedString
        {
            get {
                if (Connected)
                {
                    return "Connected";
                }
                else
                {
                    return "Disconnected";
                }
            }
        }

        public string ConnectedColor
        {
            get
            {
                if (!Connected)
                {
                    return "#FFE63946";
                }
                else
                {
                    return "#ff02c39a";
                }
            }
        }

        public bool Updatable
        {
            get
            {
                return updatable;
            }
            set
            {
                updatable = value;
                OnPropertyChanged();
            }
        }

        public List<int> Displays
        {
            get
            {
                List<int> displays = new List<int>();
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    displays.Add(i + 1);
                }
                return displays;
            }
        }
        #endregion

        #region My Landings data
        public DataTable LandingTable
        {
            get
            {
                return logTable;
            }
        }
        public string PlaneFilter
        {
            get
            {
                return planeFilter;
            }
            set
            {
                planeFilter = value;
                logTable.DefaultView.RowFilter = "Plane Like '%" + value + "%'";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LandingTable"));
            }
        }

        public void UpdateTable()
        {
            LandingLogger logger = new LandingLogger();
            logTable = logger.LandingLog;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LandingTable"));

            /*string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            BindData(path + @"\MyMSFS2020Landings-Gees\Landings.v1.csv");*/
        }
   /*     private void BindData(string filePath)
        {
            MakeLogIfEmpty();
            logTable.Columns.Clear();
            logTable.Rows.Clear();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    logTable.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = lines.Length - 1; i > 0; i--)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = logTable.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    logTable.Rows.Add(dr);
                }
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LandingTable"));
        }*/
        #endregion

        #region Landing Rate Data
        public class Parameters
        {
            public string Name { get; set; }
            public int FPM { get; set; }
            public double Gees { get; set; }
            public double Airspeed { get; set; }
            public double Groundspeed { get; set; }
            public double Headwind { get; set; }
            public double Slip { get; set; }
            public double Crosswind { get; set; }
        }

        private Parameters _lastLandingParams = new Parameters
        {
            Name = null,
            FPM = -125,
            Gees = 1.22,
            Airspeed = 65,
            Groundspeed = 63,
            Headwind = -7,
            Crosswind = 3,
            Slip = 1.53
        };
        public Parameters LastLandingParameters
        {
            get { return LastLandingParameters; }
            set
            {
                _lastLandingParams = value;
                LandingLogger logger = new LandingLogger();
                logger.EnterLog(new LandingLogger.LogEntry
                {
                    Time = DateTime.Now,
                    Plane = value.Name,
                    Fpm = value.FPM,
                    G = value.Gees,
                    AirV = value.Airspeed,
                    GroundV = value.Groundspeed,
                    HeadV = value.Headwind,
                    CrossV = value.Crosswind,
                    Sideslip = value.Slip
                });
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
            }
        }
        public string FPMText
        {
            get { return _lastLandingParams.FPM.ToString("0 fpm"); }
        }
        public string GeesText
        {
            get { return _lastLandingParams.Gees.ToString("0.##G"); }
        }
        public string GeesImage
        {
            get
            {
                if (_lastLandingParams.Gees < 1.2)
                {
                    return "/Images/smile.png";
                }
                else if (_lastLandingParams.Gees < 1.4)
                {
                    return "/Images/meh.png";
                }
                else if (_lastLandingParams.Gees < 1.8)
                {
                    return "/Images/frown.png";
                }
                else
                {
                    return "/Images/tired.png";
                }
            }
        }
        public string SpeedsText
        {
            get { return String.Format("{0} kt Air - {1} kt Ground", Convert.ToInt32(_lastLandingParams.Airspeed), Convert.ToInt32(_lastLandingParams.Groundspeed)); }
        }
        public string WindSpeedText
        {
            get
            {
                double Crosswind = _lastLandingParams.Crosswind;
                double Headwind = _lastLandingParams.Headwind;
                double windamp = Math.Sqrt(Crosswind * Crosswind + Headwind * Headwind);
                return Convert.ToInt32(windamp) + " kt";
            }
        }
        public int WindDirection
        {
            get
            {
                double Crosswind = _lastLandingParams.Crosswind;
                double Headwind = _lastLandingParams.Headwind;
                double windangle = Math.Atan2(Crosswind, Headwind) * 180 / Math.PI;
                return Convert.ToInt32(windangle);
            }
        }
        public string AlphaText
        {
            get { return _lastLandingParams.Slip.ToString("0.##º Left Sideslip; 0.##º Right Sideslip;"); }
        }
        #endregion

        protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }
}
