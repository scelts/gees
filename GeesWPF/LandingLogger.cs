using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace GeesWPF
{
    public class LandingLogger
    {
        public class LogEntry
        {
            [Name("Time")]
            public DateTime Time { get; set; }
            [Name("Plane")]
            public string Plane { get; set; }
            [Name("FPM")]
            public int Fpm { get; set; }
            [Name("Impact (G)")]
            public double G { get; set; }
            [Name("Air Speed (kt)")]
            public double AirV { get; set; }
            [Name("Ground Speed (kt)")]
            public double GroundV { get; set; }
            [Name("Headwind (kt)")]
            public double HeadV { get; set; }
            [Name("Crosswind (kt)")]
            public double CrossV { get; set; }
            [Name("Sideslip (deg)")]
            public double Sideslip { get; set; }
        }

        public string MakeLogIfEmpty()
        {
            //const string header = "Time,Plane,FPM,Impact (G),Air Speed (kt),Ground Speed (kt),Headwind (kt),Crosswind (kt),Sideslip (deg)";
            string myDocs = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Directory.CreateDirectory(myDocs + @"\MyMSFS2020Landings-Gees"); //create if doesn't exist
            string path = myDocs + @"\MyMSFS2020Landings-Gees\Landings.v2.csv";
            if (!File.Exists(path))
            {
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(new List<LogEntry>());
                }
            }
            return path;
        }

        public void EnterLog(LogEntry newLine)
        {
            string path = MakeLogIfEmpty();
            // Append to the file.
            using (var stream = File.Open(path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                List<LogEntry> newRecord = new List<LogEntry>();
                newRecord.Add(newLine);
                // Don't write the header again.
                csv.Configuration.HasHeaderRecord = false;
                csv.WriteRecords(newRecord);
            }
        }

        public DataTable LandingLog
        {
            get
            {
                var dt = new DataTable();
                string path = MakeLogIfEmpty();
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    // Do any configuration to `CsvReader` before creating CsvDataReader.
                    using (var dr = new CsvDataReader(csv))
                    {
                         dt.Load(dr);
                    }
                }
                dt.DefaultView.Sort = "Time desc";
                dt = dt.DefaultView.ToTable();
                return dt;
            }
        }
    }
}
