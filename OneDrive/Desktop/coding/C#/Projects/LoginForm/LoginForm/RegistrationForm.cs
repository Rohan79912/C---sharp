using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class RegistrationForm : Form
    {
        public static string name = "";
        public static string fname = "";
        public static string mname = "";
        public static string mail = "";
        public static string mob = "";
        public static string address = "";
        public static string gender = "";
        public static string dob = "";
        public static string lang = "";
        public static string qual = "";
        public static string city = "";
        public static string country = "";
        public static string age = "";
        public static string ms = "";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            name = txtname.Text;
            fname = txtfname.Text;
            mname = txtmname.Text;
            mail = txtmail.Text;
            address = txtaddress.Text;
            mob = txtmobile.Text;
            dob = dtpdob.Text;
            if (rbfemale.Checked == true)
            {
                gender = rbfemale.Text;
            }
            else if (rbmale.Checked == true)
            {
                gender = rbmale.Text;
            }
            else if (rbother.Checked == true)
            {
                gender = rbother.Text;
            }
            else
            {
                gender = "Please select gender";
            }
            qual = cmbqualification.Text;
            city = cmbcity.Text;
            country = cmbcountry.Text;
            age = cmbage.Text;
            ms = cmbms.Text;
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void rbother_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbhindi_CheckedChanged(object sender, EventArgs e)
        {
            if(cbhindi.Checked == true){
                lang += cbhindi.Text;
            }
            else{
                lang = "";
            }
        }

        private void cbenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (cbenglish.Checked == true)
            {
                lang += cbenglish.Text;
            }
            else
            {
                lang = "";
            }
        }

        private void cburdu_CheckedChanged(object sender, EventArgs e)
        {
            if (cburdu.Checked == true)
            {
                lang += cburdu.Text;
            }
            else
            {
                lang = "";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           // textBox1.Text = string.Empty;
           // textBox2.Text = string.Empty;


        }
    }
}
