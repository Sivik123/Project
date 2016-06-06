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
    public partial class rownoleglobok : Form
    {
        Image Rownleglobok = Resources.równloegłobok; // zadeklarowanie obrazka
        public rownoleglobok()
        {
            InitializeComponent();
            pictureBox1.Image = Rownleglobok; 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,h;
            a = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);
            textBox5.Text = (a * h).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox3.Text);
            b = double.Parse(textBox4.Text);
            textBox5.Text = (2 * a + 2 * b).ToString();
        }
    }
}
