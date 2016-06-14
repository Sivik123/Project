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
    public partial class kwadrat : Form
    {
        Image Kwadrat = Resources.kwadrat; // zadeklarowanie obrazka
        public kwadrat()
        {
            InitializeComponent();
            pictureBox1.Image = Kwadrat; 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ObwodKwadratu(object sender, EventArgs e) //przycisk obwod
        {
            double a;
            a = double.Parse(textBox1.Text);
            textBox4.Text = (4 * a).ToString(); 
        }

        private void PoleKwadratu(object sender, EventArgs e) //przycisk Pole
        {
            double a;
            a = double.Parse(textBox2.Text);
            textBox4.Text = (a * a).ToString();
        }

        private void PrzekatnaKwadratu(object sender, EventArgs e) //przycisk przekątna
        {
            double a;
            a = double.Parse(textBox3.Text);
            textBox4.Text = (a * Math.Sqrt(2)).ToString();
        }


        private void Wstecz(object sender, EventArgs e) // Przycisk Powrot
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }

        private void Dalej(object sender, EventArgs e) // Przycisk DoPrzodu
        {
            this.Hide();
            okrag f = new okrag();
            f.Show();
        }

    
    }
}
