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

        private void Wstecz(object sender, EventArgs e) // Przycisk powrotu
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }

        private void PoleRownolegloboku(object sender, EventArgs e) // Przycisk powrotu
        {
          try 
	{	        
		  double a,h;
            a = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);

            if (a < 0 | h < 0) // wyrzucenie własnego wyjatku
            {
                throw new wyjatek();
            }
            else
            {
                textBox5.Text = (a * h).ToString();
            }
          }          
	    catch (wyjatek wyj)
	    {
            textBox5.Text = "Tylko dodatnie";
        }
        catch { textBox5.Text = "Wpisz Cyfre"; };

        }

        private void ObwodRownolegloboku(object sender, EventArgs e) // Przycisk obwodu
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
                    textBox5.Text = (2 * a + 2 * b).ToString();
                }
            }
            catch (wyjatek wyj)
            {
                textBox5.Text = "Tylko dodatnie";
            } catch
            { textBox5.Text = "Wpisz Cyfre"; };
        }

        private void rownoleglobok_Load(object sender, EventArgs e)
        {

        }
    }
}
