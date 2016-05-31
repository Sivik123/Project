using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class kwadrat : Form
    {
        public kwadrat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kwadrat k = new kwadrat();
            k.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox4.Text = (4 * a).ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox2.Text);
            textBox4.Text = (a * a).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox3.Text);
            textBox4.Text = (a * Math.Sqrt(2)).ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }
    }
}
