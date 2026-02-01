using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public static string uname;
        public static string pass;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uname = txtusername.Text;
            pass = txtpassword.Text;
            if(uname == "Rohan" && pass == "1234")
            {
                MessageBox.Show("Login Sucessfully");
                WelcomeForm wf = new WelcomeForm();
                wf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect user_name or password");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;


        }
    }
}
