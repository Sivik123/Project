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

        private void PoleTrapezu(object sender, EventArgs e) // Przycisk Pole
        {
            try
            {
                double a, b, h;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                h = double.Parse(textBox3.Text);


                if (a < 0 | b < 0 | h < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox4.Text = (((a + b) * h) / 2).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox4.Text = "Tylko dodatnie";
            }
            catch { textBox4.Text = "Wpisz Cyfre"; };
        }

        
        

        private void ObwodTrapezu(object sender, EventArgs e) // Przycisk Obwod
        {
            try
            {
                double a, b, c, d;
                a = double.Parse(textBox5.Text);
                b = double.Parse(textBox6.Text);
                c = double.Parse(textBox7.Text);
                d = double.Parse(textBox8.Text);
                
            
                 if (a < 0 | b < 0 | c < 0 | d < 0) // wyrzucenie własnego wyjatku
                {
                    throw new wyjatek();
                }
                else
                {
                    textBox4.Text = (a + b + c + d).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox4.Text = "Tylko dodatnie";
            }
            catch { textBox4.Text = "Wpisz Cyfre"; };
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
            rownoleglobok f = new rownoleglobok();
            f.Show();
        }
    }
}
