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
using System.Text.RegularExpressions;
namespace justAttendanceSystem.pal.forms
{

    public partial class loginForm : Form

    {

        
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True");
        public loginForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to logout", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            toolTip1.SetToolTip(picHide, "Close");
        }

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Show password");
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = false;
            picShow.Hide();
            picHide.Show();
        }
        

        private void picHide_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picHide, "Hide password");
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
            picShow.Show();
            picHide.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(cbRole.SelectedIndex != -1 && textUserName.Text != "" && textPassword.Text != "")
            {
                if (cbRole.Text == "student")
                {
                    checkstudent();
                    if (std > 0)
                    {
                        getUsers.MyUser = textUserName.Text;
                        MyStudentreport sr = new MyStudentreport();
                        sr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student...");
                    }
                }
                else if (cbRole.Text == "admin")
                {
                    admin();
                    if (admini > 0)
                    {
                        mainForm frm = new mainForm();
                        frm.btnStudentReport.Hide();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin...");
                    }
                }
                else if (cbRole.Text == "lecturer")
                {
                    checkLect();
                    if (lec > 0)
                    {
                        getUsers.MyUser = textUserName.Text;
                        lectAttendance tk = new lectAttendance();
                        tk.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Lecturer...");
                    }
                }
                else if (cbRole.Text == "examDepart")
                {
                    checkexamdepartment();
                    if (examdep > 0)
                    {
                        facultyReport frm = new facultyReport();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Exam department...");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the blanks...");
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            picHide.Show();
            picShow.Hide();
        }
        
       
        int std = 0;
        private void checkstudent()
        {
            SqlCommand cmd = new SqlCommand("select count(stdID) from student where stdID='" + textUserName.Text + "' and password='" + textPassword.Text + "'",conn);

            conn.Open();
            std =int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }
        int lec = 0;
        private void checkLect()
        {
            SqlCommand cmd = new SqlCommand("select count(lecID) from lecturer where lecID='" + textUserName.Text + "' and password='" + textPassword.Text + "'",conn);
            conn.Open();
            lec=int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }
        int examdep = 0;
        private void checkexamdepartment()
        {
            SqlCommand cmd = new SqlCommand("select count(depID) from examDepartment where depID='" + textUserName.Text + "' and password='" + textPassword.Text + "'",conn);
            conn.Open();
            examdep = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }
        int admini = 0;
        private void admin()
        {
            SqlCommand cmd = new SqlCommand("select count(adminID) from admin where adminID='" + textUserName.Text + "' and password='" + textPassword.Text + "'",conn);
            conn.Open();
            admini = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && e.KeyChar != '.'  && e.KeyChar != '-')
            {
                e.Handled = true;
                lblPasswordError.Text = "Only Numbers Are Allowed..";
               
            }
            else
            {
                e.Handled = false;
                lblPasswordError.Text = "";
            }
            if (textPassword.Text.Length > 6)
            {
                MessageBox.Show("Only 6 Numbers Are Allowed...","warning.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void textUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (textUserName.Text.Length > 7)
            {
                MessageBox.Show("Only 7 Character and Digits Are Allowed...", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picSecure_Click(object sender, EventArgs e)
        {

        }

        private void cbRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                lblRollError.Text = "Only Characters Are Allowed..";
                MessageBox.Show("Choose from Combox..");

            }
            else
            {
                e.Handled = false;
                lblRollError.Text = "";
            }
            if (cbRole.Text.Length > 10)
            {
                MessageBox.Show("Only 10 characters Are Allowed...", "warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            if(cbRole.SelectedIndex != -1 && textUserName.Text!="")
            {
                getEmail.Password = cbRole.Text;
                getEmail.User = textUserName.Text;
                emailForm email = new emailForm();
                email.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please choose your role to get your password or fill User textbox...");
            }
        }

        private void picShow_Click_1(object sender, EventArgs e)
        {
            textPassword.PasswordChar = ('\0');
            picHide.Visible = true;
            picShow.Visible = false;
        }

        private void picHide_Click_1(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
            picShow.Visible = true;
            picHide.Visible = false;
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {
            if (textUserName.Text.Length > 0)
            {
                string first = textUserName.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    textUserName.Text = string.Empty;
                    lblUserError.Text = "Username can not start a number..";
                }
                else
                {
                    lblUserError.Text = "";
                }
            }
        }
        public static bool isAlpha(string v)
        {
            Regex rg = new Regex("^[a-zA-Z] *$");
            if (rg.IsMatch(v))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
