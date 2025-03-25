using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusTrackerCode
{
    public partial class CalculateRiskScores : Form
    {
        public CalculateRiskScores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            RiskScoresandGraphs rs = new RiskScoresandGraphs();
            rs.Show(); 
        }

        private void CalculateRiskScores_Load(object sender, EventArgs e)
        {
            Symptom symptom = new Symptom();
            List<String> itemsSymptoms = symptom.populateSymptoms();
            foreach (String item in itemsSymptoms)
            {
                checkedListBox1.Items.Add(item);
            }
            Disease disease = new Disease();
            DataTable itemsDiseases = disease.populateDiseases();
            comboBox1.DisplayMember = "Disease";
            comboBox1.ValueMember = "DiseaseID";
            comboBox1.DataSource = itemsDiseases;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = populateVisits((int) comboBox1.SelectedValue);
            List<String> symptoms = new List<String>();
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    symptoms.Add(checkedListBox1.CheckedItems[i].ToString());
                }
            }
            int total = dt.Rows.Count; List<double> probabilities = new List<double>();
            foreach (string symptom in symptoms)
            {
                int positive = 0; 
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Symptoms"].ToString().Contains(symptom) && row["Result"].ToString() == "Positive")
                    {
                        positive++; 
                    }
                }
                if (total != 0)
                {
                    double prob = positive / total;
                    probabilities.Add(prob);
                }
            }
            if (probabilities.Count > 0)
            {
                double ans = probabilities.Sum() / probabilities.Count();
                label4.Text = ans.ToString();
            } else {
                MessageBox.Show("You don't have enough data."); 
            }
        }

        public DataTable populateVisits(int diseaseID)
        {
            DataTable VisitCalcs = new DataTable();
            DBAttributes dBAttributes = new DBAttributes();
            string ConnectionString = dBAttributes.getConnectionString();
            string query = "SELECT Symptoms, DiseaseID, Result FROM VisitTable WHERE DiseaseID = " + diseaseID;
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(VisitCalcs);
                connection.Close();
            }
            return VisitCalcs;
        }
    }
}
