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
namespace justAttendanceSystem.pal.forms
{
    public partial class emailForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True");
        public emailForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to logout", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                loginForm log = new loginForm();
                log.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to logout", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                
                loginForm login = new loginForm();
                login.Show();
                this.Hide();

            }
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (textEmail.Text != "")
            {
                if (getEmail.Password=="admin")
                {
                    string password = "";
                    getAdminEmail();
                    if(email > 0)
                    {
                        SqlCommand cmd = new SqlCommand("select password from admin where email='" + textEmail.Text + "'", conn);
                        conn.Open();
                        password = cmd.ExecuteScalar().ToString();
                        conn.Close();
                        MessageBox.Show("Your password is: " + password);
                    }
                    else
                    {
                        MessageBox.Show("invalid...");
                    }
                }
                else if (getEmail.Password == "student")
                {
                    string password = "";
                    getstdEmail();
                    if (std > 0)
                    {
                        SqlCommand cmd = new SqlCommand("select password from student where email='" + textEmail.Text + "'", conn);
                        conn.Open();
                        password = cmd.ExecuteScalar().ToString();
                        conn.Close();
                        MessageBox.Show("Your password is: " + password);
                    }
                    else
                    {
                        MessageBox.Show("invalid...");
                    }
                }
                else if (getEmail.Password == "lecturer")
                {
                    string password = "";
                    getlectEmail();
                    if (lect > 0)
                    {
                        SqlCommand cmd = new SqlCommand("select password from lecturer where email='" + textEmail.Text + "'", conn);
                        conn.Open();
                        password = cmd.ExecuteScalar().ToString();
                        conn.Close();
                        MessageBox.Show("Your password is: " + password);
                    }
                    else
                    {
                        MessageBox.Show("invalid...");
                    }
                }
                else if (getEmail.Password == "examDepart")
                {
                    string password = "";
                    getExamEmail();
                    if (Exam > 0)
                    {
                        SqlCommand cmd = new SqlCommand("select password from examDepartment where gmail='" + textEmail.Text + "'", conn);
                        conn.Open();
                        password = cmd.ExecuteScalar().ToString();
                        conn.Close();
                        MessageBox.Show("Your password is: " + password);
                    }
                    else
                    {
                        MessageBox.Show("invalid...");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Enter your gmail...");
            }
        }
        int email = 0;
        private void getAdminEmail()
        {
            SqlCommand cmd = new SqlCommand("select count(email) from Admin where adminID='"+getEmail.User+"'and email='" +textEmail.Text + "'", conn);
            conn.Open();
           email = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }
        int std = 0;
        private void getstdEmail()
        {
            SqlCommand cmd = new SqlCommand("select count(email) from student where stdID='" + getEmail.User + "'and email='" + textEmail.Text + "'", conn);
            conn.Open();
            std = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }
        int lect = 0;
        private void getlectEmail()
        {
            SqlCommand cmd = new SqlCommand("select count(email) from lecturer where lecID='" + getEmail.User + "'and email='" + textEmail.Text + "'", conn);
            conn.Open();
            lect = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }
        int Exam = 0;
        private void getExamEmail()
        {
            SqlCommand cmd = new SqlCommand("select count(gmail) from examDepartment where depID='" + getEmail.User + "'and gmail='" + textEmail.Text + "'", conn);
            conn.Open();
            Exam = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
