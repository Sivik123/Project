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
            try
            {
                double r;
                double pi = Math.PI;
                r = double.Parse(textBox1.Text);
               

                if (r < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox3.Text = (pi * r).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox3.Text = "Tylko dodatnie";
            }
            catch { textBox3.Text = "Wpisz Cyfre"; };
        }
       

        private void DlugoscOkregu(object sender, EventArgs e)// Przycisk Długość okręgu
        {
            try
            {
                double r;
                double pi = Math.PI;

                r = double.Parse(textBox2.Text);
                
                if (r < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox3.Text = ((2 * pi) * r).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox3.Text = "Tylko dodatnie";
            }
            catch { textBox3.Text = "Wpisz Cyfre"; };
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

        private void okrag_Load(object sender, EventArgs e)
        {

        }


    }
}
