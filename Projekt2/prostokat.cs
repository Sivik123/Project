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
    public partial class prostokat : Form
    {
        public prostokat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox7.Text = (a * b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox3.Text);
            b = double.Parse(textBox4.Text);
            textBox7.Text = (2 * a + 2 * b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              double a, b;
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            textBox7.Text = ((Math.Sqrt(a * a + b * b)).ToString());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }
    }
}
