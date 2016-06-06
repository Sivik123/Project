using Projekt2.Properties;
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
    public partial class trapez : Form
    {
        Image Trapez = Resources.Trapez; // zadeklarowanie obrazka
        public trapez()
        {
            InitializeComponent();
            pictureBox1.Image = Trapez; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b,h;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            h = double.Parse(textBox3.Text);
            textBox4.Text = (((a +b)*h)/2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            c = double.Parse(textBox7.Text);
            d = double.Parse(textBox8.Text);
            textBox4.Text = (a + b + c + d).ToString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }
    }
}
