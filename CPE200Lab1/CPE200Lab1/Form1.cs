using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{

    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = lblDisplay.Text + ".";
            }
            else if (count == 0)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                count = 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            count = 0;
        }
        double hold;
        int mark = 0;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                hold = Double.Parse(lblDisplay.Text);
                lblDisplay.Text = "0";
                count = 0;
                mark = 1;
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                hold = Double.Parse(lblDisplay.Text);
                lblDisplay.Text = "0";
                count = 0;
                mark = 2;
            }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                hold = Double.Parse(lblDisplay.Text);
                lblDisplay.Text = "0";
                count = 0;
                mark = 3;
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                hold = Double.Parse(lblDisplay.Text);
                lblDisplay.Text = "0";
                count = 0;
                mark = 4;
            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            hold = Double.Parse(lblDisplay.Text) * -1;
            lblDisplay.Text = hold.ToString();
        }
        double hold2;
        double sum;
        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (per == 0)
            {
                if (mark == 1)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    sum = hold + hold2;
                }
                else if (mark == 2)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    sum = hold - hold2;
                }
                else if (mark == 3)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    sum = hold * hold2;
                }
                else if (mark == 4)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    sum = hold / hold2;
                }
                else if (mark == 0)
                {
                    sum = Double.Parse(lblDisplay.Text);
                }
            }
            else if (per == 1)
            {
                if (mark == 1)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    hold2 = (hold2 / 100) * hold;
                    sum = hold + hold2;
                }
                else if (mark == 2)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    hold2 = (hold2 / 100) * hold;
                    sum = hold - hold2;
                }
                else if (mark == 3)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    hold2 = (hold2 / 100) * hold;
                    sum = hold * hold2;
                }
                else if (mark == 4)
                {
                    hold2 = Double.Parse(lblDisplay.Text);
                    hold2 = (hold2 / 100) * hold;
                    sum = hold / hold2;
                }
                else if (mark == 0)
                {
                    sum = Double.Parse(lblDisplay.Text);
                }
            }

            lblDisplay.Text = sum.ToString();
            if (lblDisplay.Text.Length > 8)
            {
                lblDisplay.Text = "Error";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        if (lblDisplay.Text.Length == 1)
            {
                lblDisplay.Text = "0";
            }
        else
            { 
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
                count = 0;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int per=0;
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            per = 1;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length != 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                }
            }
        }
    }
}
