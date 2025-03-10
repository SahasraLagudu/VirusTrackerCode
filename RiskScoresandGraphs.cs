using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusTrackerCode
{
    public partial class RiskScoresandGraphs : Form
    {
        public RiskScoresandGraphs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculateRiskScores rs = new CalculateRiskScores(); 
            rs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BarChartsOrHistograms bh = new BarChartsOrHistograms();
            bh.Show();
        }

        private void RiskScoresandGraphs_Load(object sender, EventArgs e)
        {

        }
    }
}
