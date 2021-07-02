using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            if (!Regex.IsMatch(input1, @"\d+$") || !Regex.IsMatch(input2, @"\d+$"))
            {
                MessageBox.Show("enter a number");
            }

            if (radioButton1.Checked)
            {
                MessageBox.Show((int.Parse(input1) + int.Parse(input2)).ToString());
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show((int.Parse(input1) - int.Parse(input2)).ToString());
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show((int.Parse(input1) * int.Parse(input2)).ToString());
            }
            else if (radioButton4.Checked)
            {

                MessageBox.Show((int.Parse(input1) / int.Parse(input2)).ToString());
            }
            else
            {
                MessageBox.Show("Select a Option");
            }

        }

    }
}
