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
    public partial class ImportDiseases : Form
    {
        public ImportDiseases()
        {
            InitializeComponent();
            timer1.Start(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog1.ShowDialog(); //check permissions, //use List Types only as you can do efficient searching, ArrayList types are too
            //difficult to search or use, what's an ienumerable?
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1; //set properties later 
                richTextBox1.Text = progressBar1.Value.ToString() + "%";
            } else {
                timer1.Stop();
                MessageBox.Show("File Conversion Complete"); 
            }
        }

        private void ImportDiseases_Load(object sender, EventArgs e)
        {

        }
    }
}
