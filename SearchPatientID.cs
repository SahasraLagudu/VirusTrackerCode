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
    public partial class SearchPatientID : Form
    {
        int ID; 
        public SearchPatientID()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ID_new = textBox1.Text; 
            ID = Int32.Parse(ID_new);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form3 f3 = new Form3();
            f3.Show(); 
        }
    }
}
