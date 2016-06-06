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
        // Przycisk Pole Trojkata prostokatnego
        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
         a =  double.Parse(textBox42.Text);
            b = double.Parse(textBox5.Text);
            
            textBox6.Text = (0.5 * (a * b)).ToString();    
        }
        //

        // Przycisk Pole Trojkata rownobocznego
        private void button4_Click(object sender, EventArgs e)
        {
               double a;
         a =  double.Parse(textBox4.Text);
         textBox6.Text = ((a * a) * Math.Sqrt(3) / 4).ToString();
          
           
        }
        //

     

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }
        //

        //
        private void button5_Click(object sender, EventArgs e)
        {
            double a,b,c;
            a = double.Parse(textBox7.Text);
            b = double.Parse(textBox8.Text);
            c = double.Parse(textBox9.Text);
            textBox6.Text = (a+b+c).ToString();
        }



        // Przycisk Powrotu
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            figury f = new figury();
            f.Show();
        }
        //


     

    }
}
