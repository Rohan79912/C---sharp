using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstDesktopApplication
{
    public partial class LoginForm : Form
    {
        public static string uname;
        public static string pass;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string CS = "Data Source=DESKTOP-HTR7DLD\\SQLEXPRESS ; Database=EMP ; User Id=sa ; Password=tiger";
            SqlConnection con = new SqlConnection(CS);
            string sql = "  select * from employee where username=@uname and pwd=@pwd";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uname", txtusername.Text);
            cmd.Parameters.AddWithValue("@pwd", txtpassword.Text);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    MessageBox.Show("Login Success!...");
                }
                else
                {
                    MessageBox.Show("Incorrect Username or password");
                }
            }
            catch(SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
            //if (string.IsNullOrEmpty(txtusername.Text))
            //{
            //    txtusername.Focus();
            //    errorProvider1.SetError(this.txtusername, "Please provide user name");
            //}
            //else if (string.IsNullOrEmpty(txtpassword.Text))
            //{
            //    txtpassword.Focus();
            //    errorProvider2.SetError(this.txtpassword, "Please provide password");
            //}
            //else 
            //{
            //    timer1.Start();
            //    errorProvider1.Clear();
            //    errorProvider2.Clear();
            //    MessageBox.Show("Login Successfully");
            //    WelcomForm wf = new WelcomForm();
            //    wf.Show();
            //    this.Hide();
            //}
            //uname = txtusername.Text;
            //pass = txtpassword.Text;
            //if(uname == "admin" && pass == "1234")
            //{
            //    MessageBox.Show("Login Successfully");
            //    WelcomForm wf = new WelcomForm();
            //    wf.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Username and Password!....");
            //}
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtusername.Text))
            {
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername, "Please provide user name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                txtpassword.Focus();
                errorProvider1.SetError(this.txtpassword, "Please provide password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsNumber(c))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
