using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VirusTrackerCode
{
    public partial class BarChartsOrHistograms : Form
    {
        public BarChartsOrHistograms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiskScoresandGraphs riskScoresandGraphs = new RiskScoresandGraphs();
            riskScoresandGraphs.Show(); 
        }

        private void BarChartsOrHistograms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Histograms histograms = new Histograms();
            histograms.Show();
            List<String> histogram_bins = new List<string>(); 
            int bin_size = Int32.Parse(textBox2.Text); //does this do hexadecimal? or does it convert directly
            int min = Int32.Parse(textBox1.Text);
            int max = Int32.Parse(textBox3.Text);
            int index = 0; string range = ""; 
            for (int i = min; i <= max; i+=bin_size)
            {
                range += i;
                if (index % 2 == 0)
                {
                    histogram_bins.Add(range); 
                    range = ""; 
                } else
                {
                    range += '-';
                }
                index++; 
            }
        }
    }
}
