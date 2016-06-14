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
    public partial class trojkat : Form
    {
        Image Trojkat = Resources.trójkąt; // zadeklarowanie obrazka
        
        public trojkat()
        {
            InitializeComponent();
            pictureBox1.Image = Trojkat; 
        }

        private void PoleTrójkątaProstokątnego(object sender, EventArgs e) // Przycisk Pole Trojkata prostokatnego
        {
            double a, b;
         a =  double.Parse(textBox42.Text);
            b = double.Parse(textBox5.Text);
            
            textBox6.Text = (0.5 * (a * b)).ToString();    
        }
       
      

        private void PoleTrójkątaRównobocznego(object sender, EventArgs e) // Przycisk Pole Trojkata rownobocznego
        {
               double a;
         a =  double.Parse(textBox4.Text);
         textBox6.Text = ((a * a) * Math.Sqrt(3) / 4).ToString();
          
           
        }
        
 
        //

        //
        private void ObwódTrójkątówRóżnobocznych(object sender, EventArgs e) // Przycisk Obwód trojkatow roznobocznych
        {
            double a,b,c;
            a = double.Parse(textBox7.Text);
            b = double.Parse(textBox8.Text);
            c = double.Parse(textBox9.Text);
            textBox6.Text = (a+b+c).ToString();
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
            kwadrat f = new kwadrat();
            f.Show();

        }
        //


     

    }
}
