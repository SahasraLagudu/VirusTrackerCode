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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats stats = new Stats();
            stats.Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); 
            Form3 f3 = new Form3();
            f3.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportCSV f2 = new ImportCSV();
            f2.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisitDetails visit = new VisitDetails();
            visit.Show();
        }
    }
}
