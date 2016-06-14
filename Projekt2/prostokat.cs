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
    public partial class prostokat : Form
    {
        Image Prostokat = Resources.prostokąt; // zadeklarowanie obrazka
       
        public prostokat()
        {
            InitializeComponent();
            pictureBox1.Image = Prostokat;
        }

        private void PoleProstokata(object sender, EventArgs e) // Przycisk Pola
        {
            double a,b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox7.Text = (a * b).ToString();
        }

        private void ObwodProstokata(object sender, EventArgs e) // Przycisk Obwodu
        {
            double a, b;
            a = double.Parse(textBox3.Text);
            b = double.Parse(textBox4.Text);
            textBox7.Text = (2 * a + 2 * b).ToString();
        }

        private void PrzekatnaProstokata(object sender, EventArgs e) // Przycisk Przekatna
        {
              double a, b;
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            textBox7.Text = ((Math.Sqrt(a * a + b * b)).ToString());
        }

        private void Wstecz(object sender, EventArgs e) // Przycisk Powrotu
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }

        private void Dalej(object sender, EventArgs e) // Przycisk DoPrzodu
        {
            this.Hide();
            trapez f = new trapez();
            f.Show();
        }
    }
}
