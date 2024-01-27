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
            [Name("Bounces")]
            public double Bounces { get; set; }
        }

        public string MakeLogIfEmpty()
        {
            //const string header = "Time,Plane,FPM,Impact (G),Air Speed (kt),Ground Speed (kt),Headwind (kt),Crosswind (kt),Sideslip (deg)";
            string myDocs = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Directory.CreateDirectory(myDocs + @"\MyMSFS2020Landings-Gees"); //create if doesn't exist
            string path = myDocs + @"\MyMSFS2020Landings-Gees\Landings.v3.csv";
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
                List<LogEntry> records;
                string path = MakeLogIfEmpty();
                // Read the CSV file into a list of LogEntry objects
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<LogEntry>().ToList();
                }

                // Convert the list of LogEntry objects to a DataTable
                var dt = new DataTable();

                // Add columns to DataTable based on LogEntry properties
                dt.Columns.Add("Time", typeof(DateTime));
                dt.Columns.Add("Plane", typeof(string));
                dt.Columns.Add("FPM", typeof(int));
                dt.Columns.Add("Impact (G)", typeof(double));
                dt.Columns.Add("Air Speed (kt)", typeof(double));
                dt.Columns.Add("Ground Speed (kt)", typeof(double));
                dt.Columns.Add("Headwind (kt)", typeof(double));
                dt.Columns.Add("Crosswind (kt)", typeof(double));
                dt.Columns.Add("Sideslip (deg)", typeof(double));
                dt.Columns.Add("Bounces", typeof(double));

                // Populate the DataTable with values from the list
                foreach (var record in records)
                {
                    dt.Rows.Add(record.Time, record.Plane, record.Fpm, record.G, record.AirV, record.GroundV, record.HeadV, record.CrossV, record.Sideslip, record.Bounces);
                }

                // Sort the DataTable by Time in descending order
                dt.DefaultView.Sort = "Time DESC";
                return dt.DefaultView.ToTable();
            }
        }
    }
}
