using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDesktopApplication
{
    public partial class CalculatorApp : Form
    {
        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtnum1.Text != "" && txtnum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtnum1.Text);
                int num2 = Convert.ToInt32(txtnum2.Text);

                int result = num1 + num2;
                label4.Visible = true;
                label4.Text = "Resullt is " + result;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Please Enter first and second number";
            }
           
        }

        private void btnsub_Click(object sender, EventArgs e)
        {

        }
    }
}
