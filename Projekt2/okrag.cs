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
    public partial class okrag : Form
    {
        Image Okrag = Resources.okrąg; // zadeklarowanie obrazka
        public okrag()
        {
            InitializeComponent();
            pictureBox1.Image = Okrag; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;
            double pi = Math.PI;
            r = double.Parse(textBox1.Text);
            textBox3.Text = (pi * r).ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r;
            double pi = Math.PI;
            
            r = double.Parse(textBox2.Text);
            textBox3.Text = ((2 * pi) * r).ToString(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }
    }
}
