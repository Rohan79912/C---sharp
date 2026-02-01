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
    public partial class deletetbtn : Form
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
        public static int age;
        public static string ms = "";
        public deletetbtn()
        {
            InitializeComponent();
        }

        private void dataBind()
        {
            string CS = "Data Source = LAPTOP-RMTS0624\\SQLEXPRESS ; Database = EMP; User ID = sa; Password = tiger";
            SqlConnection con = new SqlConnection(CS);
            string aql = "Select *  from student";
            SqlDataAdapter sda = new SqlDataAdapter(aql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private string getGender()
        {
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
            return gender;
        }
        private void btnsubmit(object sender, EventArgs e)
        {
            name = txtname.Text;
            fname = txtfname.Text;
            mname = txtmname.Text;
            mail = txtmail.Text;
            address = txtaddress.Text;
            // mob = int.Parse(txtmobile.Text);
            mob = txtmobile.Text;
            dob = dtpdob.Value.ToString();
            string g = getGender();
            qual = cmbqualification.Text;
            city = cmbcity.Text;
            country = cmbcountry.Text;
            age = int.Parse(cmbage.Text);
            ms = cmbms.Text;
            string CS = "Data Source = LAPTOP-RMTS0624\\SQLEXPRESS ; Database = EMP; User ID = sa; Password = tiger";
            SqlConnection con = new SqlConnection(CS);
            string querry = "insert into student values(@sname,@fname,@mname,@dob,@address,@qual,@city,@country,@gender,@mail,@mob,@age,@marr,@lang)";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@sname", txtname.Text);
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@mname", txtmname.Text);
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dtpdob.Text));
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@qual", cmbqualification.Text);
            cmd.Parameters.AddWithValue("@city", cmbcity.Text);
            cmd.Parameters.AddWithValue("@country", cmbcountry.Text);
            cmd.Parameters.AddWithValue("@gender", g);
            cmd.Parameters.AddWithValue("@mail", txtmail.Text);
            cmd.Parameters.AddWithValue("@mob", txtmobile.Text);
            cmd.Parameters.AddWithValue("@age", cmbage.Text);
            cmd.Parameters.AddWithValue("@marr", cmbms.Text);
            cmd.Parameters.AddWithValue("@lang", lang);
            try
            {
                con.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show(row + " Record Inserted Sucessfully!!");
                    dataBind();
                }
                else
                {
                    MessageBox.Show("Failed to Insert");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            //WelcomForm wf = new WelcomForm();
            //wf.Show();
            //this.Hide();
        }

        private void cbhindi_CheckedChanged(object sender, EventArgs e)
        {
            if(cbhindi.Checked == true)
            {
                lang += cbhindi.Text;
            }
            else
            {
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string g = getGender();

           

        string CS = "Data Source = LAPTOP-RMTS0624\\SQLEXPRESS ; Database = EMP; User ID = sa; Password = tiger";
            SqlConnection con = new SqlConnection(CS);
            string querry = "update student set sname=@sname, fname=@fname, mname=@mname, sdob=@dob,saddress=@address,squal=@qual,scity=@city,scountry=@country,sgender=@gender,semail=@mail,smobile=@mob,sage=@age,smarrstatus=@marr,slangknown=@lang where sid=@sid ";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@sid", cmbid.Text);
            cmd.Parameters.AddWithValue("@sname", txtname.Text);
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@mname", txtmname.Text);
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dtpdob.Text));
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@qual", cmbqualification.Text);
            cmd.Parameters.AddWithValue("@city", cmbcity.Text);
            cmd.Parameters.AddWithValue("@country", cmbcountry.Text);
            cmd.Parameters.AddWithValue("@gender", g);
            cmd.Parameters.AddWithValue("@mail", txtmail.Text);
            cmd.Parameters.AddWithValue("@mob", txtmobile.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(cmbage.Text));
            cmd.Parameters.AddWithValue("@marr", cmbms.Text);
            cmd.Parameters.AddWithValue("@lang", lang);
            try
            {
                con.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show(row + " Record Updated Sucessfully!!");
                    dataBind();
                }
                else
                {
                    MessageBox.Show("Failed to Update");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void deletetbtn_Load(object sender, EventArgs e)
        {
             //TODO: This line of code loads data into the 'eMPDataSet1.student' table. You can move, or remove it, as needed.
           // this.studentTableAdapter1.Fill(this.eMPDataSet1.student);
            // TODO: This line of code loads data into the 'eMPDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.eMPDataSet.student);

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtfname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtmname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dtpdob.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbqualification.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmbcity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            cmbcountry.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtmail.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtmobile.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            cmbage.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            cmbms.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
