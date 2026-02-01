using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class StandardCalculator : Form
    {
        string str = "";
        double num1, num2, res = 0;
        string op = "";
        public StandardCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = clsbtn.Text;
            resulttext.Text = op;
            label1.Text = label1.Text + "" + resulttext.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = deletebtn.Text;
            resulttext.Text = op;
            label1.Text = label1.Text + "" + resulttext.Text;
        }
        
        private void sevenbtn_Click(object sender, EventArgs e)
        {
            str = str + sevenbtn.Text;
            resulttext.Text = str;
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            str = str + eightbtn.Text;
            resulttext.Text = str;
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            str = str + ninebtn.Text;
            resulttext.Text = str;
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            str = str + fourbtn.Text;
            resulttext.Text = str;
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            str = str + fivebtn.Text;
            resulttext.Text = str;
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            str = str + sixbtn.Text;
            resulttext.Text = str;
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            str = str + onebtn.Text;
            resulttext.Text = str;
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            str = str + twobtn.Text;
            resulttext.Text = str;
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            str = str + threebtn.Text;
            resulttext.Text = str;
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = divbtn.Text;
            resulttext.Text = op ;
            label1.Text = label1.Text + "" + resulttext.Text;
        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = mulbtn.Text;
            resulttext.Text = op;
            label1.Text = label1.Text + "" + resulttext.Text;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            resulttext.Clear();
            label1.Text = "";
            num1 = 0;
            num2 = 0;
            res = 0;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = addbtn.Text;
            resulttext.Text = op;
            label1.Text = label1.Text + "" + resulttext.Text;
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = subbtn.Text;
            resulttext.Text = op;
            label1.Text = label1.Text + "" + resulttext.Text;
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            switch (op)
            {
                case "/":
                    res = num1 / num2;
                    break;
                case "%":
                    res = num1 % num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
            }
            str = "";
            resulttext.Text = "" + res;
            label1.Text = label1.Text + "" + resulttext.Text;

        }

        private void modulusbtn_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(resulttext.Text);
            label1.Text = label1.Text + "" + resulttext.Text;
            resulttext.Clear();
            op = modulusbtn.Text;
            resulttext.Text = op;
            label1.Text = label1.Text + "" + resulttext.Text;
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {

        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            str = str + zerobtn.Text;
            resulttext.Text = str;
        }

        private void StandardCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
