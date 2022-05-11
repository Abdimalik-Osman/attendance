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
using justAttendanceSystem.pal.forms;

namespace justAttendanceSystem
{
    public partial class dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True");
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            StudentCount();
            LecturerCount();
            AdminCount();
            ClassCount();
            FacultyCount();
            CourseCount();
            lblStudentCount.Text = stdcount.ToString();
            lblLecturerCount.Text = leccount.ToString();
            lblAdminCount.Text = adcount.ToString();
            lblClassCount.Text = classescount.ToString();
            lblFacultiesCount.Text = facultiescount.ToString();
            lblCoursesCount.Text = coursescount.ToString();
        }
        int stdcount = 0;
        private void StudentCount()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from student",con);
            con.Open();
            stdcount=int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int leccount = 0;
        private void LecturerCount()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from lecturer", con);
            con.Open();
            leccount = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int adcount = 0;
        private void AdminCount()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from admin", con);
            con.Open();
            adcount = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int classescount = 0;
        private void ClassCount()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from class", con);
            con.Open();
            classescount = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int facultiescount = 0;
        private void FacultyCount()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from faculty", con);
            con.Open();
            facultiescount = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int coursescount = 0;
        private void CourseCount()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from course", con);
            con.Open();
            coursescount = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }
    }
}
