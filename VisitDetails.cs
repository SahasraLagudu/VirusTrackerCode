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
            List<String> symptoms = new List<String>(); 
            if (listSymptoms.CheckedItems.Count != 0)
            { 
                for (int i = 0; i < listSymptoms.CheckedItems.Count; i++)
                {
                    symptoms.Add(listSymptoms.CheckedItems[i].ToString());
                }
            }
            int diseaseID = (int) comboDiseases.SelectedValue;
            string result = comboBox1.Text;
            InsertVisitDetails(visitDate, symptoms, diseaseID, result);
            MessageBox.Show("Saved Values");
        }

        private void InsertVisitDetails(DateTime visitDate, List<String> symptoms, int diseaseID, string result)
        {
            DBAttributes dbat = new DBAttributes();
            string ConnectionString = dbat.getConnectionString();
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

    public class Visits
    {
        DateTime visitDate;
        List<String> Symptoms;
        int diseaseID;
        string result; 

        public Visits(DateTime visitDate, List<String> Symptoms, int diseaseID, string result)
        {
            this.visitDate = visitDate;
            this.Symptoms = Symptoms;
            this.diseaseID = diseaseID;
            this.result = result;
        }
    }

}
