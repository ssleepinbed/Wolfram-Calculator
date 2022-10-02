using System;
using System.Windows.Forms;

namespace Wolfram_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_eval_Click(object sender, EventArgs e)
        {
            //Instantiate class "wolfram"
            wolfram wolfram = new wolfram();
            //We can select which function we use based on which button we select.
            if(rbtnsolve.Checked)
            {
                eqresult_eval.Text = wolfram.evaluate(eqinput.Text)[0];
            }
            else if(rbtngraph.Checked)
            {
                graphbox.Image = wolfram.graph(eqinput.Text);
            }
            else if (rbtngraph3d.Checked)
            {
                graphbox.Image = wolfram.graph3d(eqinput.Text);
            }
            else if (rbtnderive.Checked)
            {
                eqresult_eval.Text = wolfram.derive(eqinput.Text);
            }
            else if (rbtnintegrate.Checked)
            {
                eqresult_eval.Text = wolfram.integrate(eqinput.Text);
            }
            else
            {
                return;
            }
        }

        private void rbtnsolve_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
