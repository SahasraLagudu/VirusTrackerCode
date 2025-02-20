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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.textBox1, "My button1");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //int patientID = int.Parse(textBox3.Text);
            /*int? patientID;
            if (int.TryParse(textBox3.Text, out patientID)
            {
                DoSomething(userVal.Value);
            }
            else
            { MessageBox.Show("Hey, we need an int over here."); }*/
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text); 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
