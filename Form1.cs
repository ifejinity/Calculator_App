using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Calculator : Form
    {
        int state = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "DEVELOPED BY: JEFFREY LONZANIDA";
            state = 1;
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "+";
            }
            else
            {
                guna2TextBox1.Text += "+";
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "-";
            }
            else
            {
                guna2TextBox1.Text += "-";
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "*";
            }
            else
            {
                guna2TextBox1.Text += "*";
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "/";
            }
            else
            {
                guna2TextBox1.Text += "/";
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            try
            {
                string TextVal = guna2TextBox1.Text;
                double Expression = Convert.ToDouble(new DataTable().Compute(TextVal, ""));
                guna2TextBox1.Text = Expression.ToString();
            }
            catch
            {
                guna2TextBox1.Text = "Syntax Error";
                state = 1;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "7";
            }
            else
            {
                guna2TextBox1.Text += "7";
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "8";
            }
            else
            {
                guna2TextBox1.Text += "8";
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "9";
            }
            else
            {
                guna2TextBox1.Text += "9";
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "4";
            }
            else
            {
                guna2TextBox1.Text += "4";
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "5";
            }
            else
            {
                guna2TextBox1.Text += "5";
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "6";
            }
            else
            {
                guna2TextBox1.Text += "6";
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "1";
            }
            else
            {
                guna2TextBox1.Text += "1";
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "2";
            }
            else
            {
                guna2TextBox1.Text += "2";
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "3";
            }
            else
            {
                guna2TextBox1.Text += "3";
            }
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += ".";
            }
            else
            {
                guna2TextBox1.Text += ".";
            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                guna2TextBox1.Text = "";
                guna2TextBox1.Text += "0";
            }
            else
            {
                guna2TextBox1.Text += "0";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
