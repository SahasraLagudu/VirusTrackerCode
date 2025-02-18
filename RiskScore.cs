using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusTrackerCode
{
    public partial class RiskScore : Form
    {
        string disease = "";
        ArrayList symptomList = new ArrayList();
        public RiskScore()
        {
            InitializeComponent();
            checkedListBox1.CheckOnClick = true; 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            disease += comboBox2.Text; 
        }

        public double calculateRiskScore(string disease)
        {
            double ans = 0;
            symptomList.Clear();
            return ans; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The probability of this patient getting " + disease + " is:" + calculateRiskScore(disease)); 
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (e.Equals(CheckState.Checked))
            {
                symptomList.Add(comboBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show(); 
        }
    }
}
