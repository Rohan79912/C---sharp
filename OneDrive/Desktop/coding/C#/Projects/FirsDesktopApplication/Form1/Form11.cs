using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtnum1.Text);
                int num2 = Convert.ToInt32(txtnum2.Text);
                int result = num1 + num2;
                label4.Visible = true;
                label4.Text = "Result is:" + result;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Please enter first and second number";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtnum1.Text);
                int num2 = Convert.ToInt32(txtnum2.Text);
                int result = num1 * num2;
                label4.Visible = true;
                label4.Text = "Result is :" + result;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Please enter first and second number";
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtnum1.Text);
                int num2 = Convert.ToInt32(txtnum2.Text);
                int result = num1 - num2;
                label4.Visible = true;
                label4.Text = "Result is :" + result;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Please enter first and second number";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnum1.Text != "" && txtnum2.Text != "")
                {
                    int num1 = Convert.ToInt32(txtnum1.Text);
                    int num2 = Convert.ToInt32(txtnum2.Text);
                    int result = num1 / num2;
                    label4.Visible = true;
                    label4.Text = "Result is :" + result;
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Please enter first and second number";
                }
            }
            catch(DivideByZeroException )
            {
                if (txtnum1.Text != "" && txtnum2.Text != "")
                {
                    label4.Visible = true;
                    label4.Text="We Cannot divide by Zero";
                }
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
