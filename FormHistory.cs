using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gees
{
    public partial class FormHistory : Form
    {
        DataTable logTable = new DataTable();
        public FormHistory()
        {
            InitializeComponent();
            //set last size
            if (Properties.Settings.Default.LandingsMaximised)
            {
                WindowState = FormWindowState.Maximized;
            }
            Location = Properties.Settings.Default.LandingsLocation;
            Size = Properties.Settings.Default.LandingsSize;

            //double buffer the datagrid
            Type dgvType = dataGridView.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
              BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView, true, null);

            iconFolder.BackgroundImage = FontAwesome.Sharp.IconChar.FolderOpen.ToBitmap(32, Color.FromArgb(230, 57, 70));
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            BindData(path + @"\MyMSFS2020Landings-Gees\Landings.v1.csv");
        }
        private void BindData(string filePath)
        {
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
            if (logTable.Rows.Count > 0)
            {
                dataGridView.DataSource = logTable;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            logTable.DefaultView.RowFilter = "Plane Like '%" + textBoxSearch.Text + "%'";
            dataGridView.DataSource = logTable;
        }

        private void iconFolder_Click(object sender, EventArgs e)
        {
            string myDocs = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = myDocs + @"\MyMSFS2020Landings-Gees";
            Process.Start(path);
        }

        private void FormHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.LandingsLocation = RestoreBounds.Location;
                Properties.Settings.Default.LandingsSize = RestoreBounds.Size;
                Properties.Settings.Default.LandingsMaximised = true;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.LandingsLocation = Location;
                Properties.Settings.Default.LandingsSize = Size;
                Properties.Settings.Default.LandingsMaximised = false;
            }
            else
            {
                Properties.Settings.Default.LandingsLocation = RestoreBounds.Location;
                Properties.Settings.Default.LandingsSize = RestoreBounds.Size;
                Properties.Settings.Default.LandingsMaximised = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}
