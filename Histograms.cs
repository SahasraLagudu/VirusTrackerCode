using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VirusTrackerCode
{
    public partial class Histograms : Form
    {
        public Histograms()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            string xAxis = "";
            string yAxis = "";
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            chart1.Series["Series1"].Label = xAxis + " vs " + yAxis;

        }
    }
}
