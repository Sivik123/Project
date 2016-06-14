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
    public partial class figury : Form
    {
        public figury()
        {
            InitializeComponent();
        }

        private void Trojkat(object sender, EventArgs e)
        {
            this.Hide();
            trojkat t = new trojkat();
            t.ShowDialog();
        }

        private void Kwadrat(object sender, EventArgs e)
        {
            this.Hide();
            kwadrat k = new kwadrat();
            k.ShowDialog();
        }

        private void Okrag(object sender, EventArgs e)
        {
            this.Hide();
            prostokat p = new prostokat();
            p.ShowDialog();
        }

        private void Prostokat(object sender, EventArgs e)
        {
            this.Hide();
            okrag o = new okrag();
            o.ShowDialog();
        }

        private void Trapez(object sender, EventArgs e)
        {
            this.Hide();
            rownoleglobok r = new rownoleglobok();
            r.ShowDialog();
        }

        private void Rownoleglobok(object sender, EventArgs e)
        {
            this.Hide();
            trapez t = new trapez();
            t.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            figury box = new figury();
            box.ShowDialog();
        }

        private void Pomoc(object sender, EventArgs e)
        {

        }

        private void OProgramie(object sender, EventArgs e)
        {
            MessageBox.Show("Program ma za zadanie obliczenie podstawowych obliczen podanych figur By: Robert Myćka");
               
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

   
    }
}
