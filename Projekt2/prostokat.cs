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
            try
            {
                double a, b;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                
                if (a < 0 | b < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox7.Text = (a * b).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox7.Text = "Tylko dodatnie";
            }
            catch { textBox7.Text = "Wpisz Cyfre"; };
        }

        private void ObwodProstokata(object sender, EventArgs e) // Przycisk Obwodu
        {
            try
            {
                double a, b;
                a = double.Parse(textBox3.Text);
                b = double.Parse(textBox4.Text);
               
                if (a < 0 | b < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox7.Text = (2 * a + 2 * b).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox7.Text = "Tylko dodatnie";
            }
            catch { textBox7.Text = "Wpisz Cyfre"; };
        }

        private void PrzekatnaProstokata(object sender, EventArgs e) // Przycisk Przekatna
        {
            try
            {
                double a, b;
                a = double.Parse(textBox5.Text);
                b = double.Parse(textBox6.Text);
               
                if (a < 0 | b < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox7.Text = ((Math.Sqrt(a * a + b * b)).ToString());
                }
            }
            catch (wyjatek wyj)
            {
                textBox7.Text = "Tylko dodatnie";
            }
            catch { textBox7.Text = "Wpisz Cyfre"; };
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
