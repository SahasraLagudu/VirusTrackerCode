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
    public partial class BarChartsOrHistograms : Form
    {
        public BarChartsOrHistograms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats stats = new Stats();
            stats.Show(); 
        }
    }
}
