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
    public partial class WelcomForm : Form
    {
        public WelcomForm()
        {
            InitializeComponent();
        }

        private void WelcomForm_Load(object sender, EventArgs e)
        {
            lblname.Text = "Welcome " + deletetbtn.name;
            lbldob.Text = "Your date of birth is " + deletetbtn.dob;
            lblcity.Text = "Your city is " + deletetbtn.city;
            lbllang.Text = "You know language " + deletetbtn.lang;
            lblgender.Text = "Your gender is " + deletetbtn.gender;
            lblcourse.Text = "Your qualification is " + deletetbtn.qual;
        }
    }
}
