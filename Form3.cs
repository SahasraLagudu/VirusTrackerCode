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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            ModifyPersonalDetails f4 = new ModifyPersonalDetails(); 
            f4.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 f1 = new Form1();
            f1.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SearchPatientID sp = new SearchPatientID();
            sp.Show();
        }
    }
}
