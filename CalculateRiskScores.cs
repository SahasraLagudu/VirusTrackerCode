﻿using System;
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

        }
    }
}
