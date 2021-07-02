using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AsyncAwaitUsage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int CountChars()
        {
            int count = 0;
            using (StreamReader streamReader = new StreamReader("D:\\Cognizant\\Handson-git\\Handson_tekstac\\C#Additional-Handson 1\\AsyncAwaitUsage2\\wordcountcheck.txt"))
            {
                string content = streamReader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(2000);
            }
            return count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountChars);
            task.Start();

            label1.Text = "File is processing";
            int count = await task;
            label1.Text = count.ToString() + " characters";
        }

    }
}
