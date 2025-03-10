using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VirusTrackerCode
{
    public partial class VisitDetails : Form
    {
        public VisitDetails()
        {
            InitializeComponent();
            listSymptoms.CheckOnClick = true;
        }

        private void VisitDetails_Load(object sender, EventArgs e)
        {
            Symptom symptom = new Symptom();
            List<String> itemsSymptoms = symptom.populateSymptoms();
            foreach (String item in itemsSymptoms)
            {
                listSymptoms.Items.Add(item);
            }
            Disease disease = new Disease();
            DataTable itemsDiseases = disease.populateDiseases();
            comboDiseases.DisplayMember = "Disease";
            comboDiseases.ValueMember = "DiseaseID";
            comboDiseases.DataSource = itemsDiseases;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime visitDate = monthCalendar1.TodayDate;
            string symptoms = "";
            if (listSymptoms.CheckedItems.Count != 0)
            { 
                for (int i = 0; i < listSymptoms.CheckedItems.Count; i++)
                {
                    if (i == listSymptoms.CheckedItems.Count - 1)
                    {
                        break; 
                    }
                    symptoms += listSymptoms.CheckedItems[i].ToString() + ", ";
                }
            }
            int diseaseID = (int) comboDiseases.SelectedValue;
            string result = comboBox1.Text;
            InsertVisitDetails(visitDate, symptoms, diseaseID, result);
            MessageBox.Show("Saved Values");
        }

        private void InsertVisitDetails(DateTime visitDate, string symptoms, int diseaseID, string result)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rajul\source\repos\VirusTrackerCode\ClientDatabase\ClientDataVirusTracker.accdb";
            string query = "INSERT INTO VisitTable (VisitDate, Symptoms, DiseaseID, Result) VALUES ('" + visitDate + "', '" + symptoms + "', " + diseaseID + ", '" + result + "')";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
