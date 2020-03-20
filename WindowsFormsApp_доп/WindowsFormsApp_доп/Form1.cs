using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp_доп
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }
        private void Chart1_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int Y = 0;
            for (int i = 0; i < Convert.ToInt32(x.Text); i++)
            {
                chart1.Series[0].Points.AddXY(i, Math.Pow(Y, 2));
                if (Y <= Convert.ToInt32(y.Text))
                {
                    Y++;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            






        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void БД()
        {
         
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                БД();
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

           

        }
    }
}
