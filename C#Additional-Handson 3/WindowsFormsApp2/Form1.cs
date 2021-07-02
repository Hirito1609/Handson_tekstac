using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = new Bitmap(openFileDialog1.FileName);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
