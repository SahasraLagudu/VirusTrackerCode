using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; 

namespace VirusTrackerCode
{
    public partial class ImportCSV : Form
    {
        public ImportCSV()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 f1 = new Form1(); 
            f1.Show(); 
        }

        private void InsertSymptom(string name)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rajul\source\repos\VirusTrackerCode\ClientDatabase\ClientDataVirusTracker.accdb";
            string query = "INSERT INTO SymptomLookup (Symptom) VALUES('" + name + "')";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                //command.Connection = connection;
                connection.Open();

                //MessageBox.Show("connected");

                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportSymptoms = new OpenFileDialog();
            //ImportSymptoms.Filter = "*.csv"; 
            StreamReader reader = null;
            if (DialogResult.OK == ImportSymptoms.ShowDialog())
            {
                string path = ImportSymptoms.FileName;
                reader = new StreamReader(File.OpenRead(path));
                List<String> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    InsertSymptom(values[0]);
                }
                MessageBox.Show("Import Completed");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ImportCSV_Load(object sender, EventArgs e)
        {

        }

        private void InsertDisease(string name)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rajul\source\repos\VirusTrackerCode\ClientDatabase\ClientDataVirusTracker.accdb";
            string query = "INSERT INTO DiseaseLookup (Disease) VALUES('" + name + "')";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                //command.Connection = connection;
                connection.Open();

                //MessageBox.Show("connected");

                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportDiseases = new OpenFileDialog();
            //ImportSymptoms.Filter = "*.csv"; 
            StreamReader reader = null;
            if (DialogResult.OK == ImportDiseases.ShowDialog())
            {
                string path = ImportDiseases.FileName;
                reader = new StreamReader(File.OpenRead(path));
                List<String> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    InsertDisease(values[0]);
                }
                MessageBox.Show("Import Completed");
            }

        }
    }
}
