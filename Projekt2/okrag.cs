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

        private void PoleOkregu(object sender, EventArgs e) // Przycisk Pole
        {
            double r;
            double pi = Math.PI;
            r = double.Parse(textBox1.Text);
            textBox3.Text = (pi * r).ToString(); 
        }

        private void DlugoscOkregu(object sender, EventArgs e)// Przycisk Długość okręgu
        {
            double r;
            double pi = Math.PI;
            
            r = double.Parse(textBox2.Text);
            textBox3.Text = ((2 * pi) * r).ToString(); 
        }

        private void Wstecz(object sender, EventArgs e) // Przycisk powrotu
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }

        private void Dalej(object sender, EventArgs e) // Przycisk DoPrzodu
        {
            this.Hide();
            prostokat f = new prostokat();
            f.Show();
        }
    }
}
