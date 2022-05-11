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
using System.Text.RegularExpressions;

namespace justAttendanceSystem
{

    public partial class TakeAttendance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True");
        SqlDataReader dr;
        public TakeAttendance()
        {
            InitializeComponent();

        }

        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
           // display();
            BindData();
           // BindCourse();
        }
        CheckBox HeaderCheckBox = null;
        bool isHeaderCheckBoxClicked = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }
        private void HeaderCheckBoxClicked(CheckBox HCheckBox)
        {
            isHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow Row in dataGridView1.Rows) ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;
            dataGridView1.RefreshEdit();
            isHeaderCheckBoxClicked = false;
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClicked((CheckBox)sender);
        }
        private void display()
        {
            SqlDataAdapter da = new SqlDataAdapter("select stdID,stdName from student ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "attendance");
            dataGridView1.DataSource = ds.Tables["attendance"];
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select  stdID,stdName from Student  where classID=(select classID from class where className ='" + cbClass.SelectedItem + "')", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["Student"];
            BindCourse();


        }
        private void BindData()
        {
            SqlCommand cmd = new SqlCommand("select  distinct(className) from class", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbClass.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            string id = "", status = "", course = "", className = "";
            DateTime MyDate;
            if (cbClass.Text != "" && CbCourse.Text != "")
            {

                DateTime myTime = DateTime.Now;
                var shortDate = myTime.ToShortDateString();
                if (DateTime22.Value.ToShortDateString() != shortDate)
                {
                    MessageBox.Show("only current date can take attendance..");
                }
                else
                {
                    checkcourseID();
                    checkDate();
                    checkClass();
                    if (date > 0 && cou > 0 && cl > 0)
                    {
                        for (int i = 0; i <= dataGridView1.RowCount - 2; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                            {
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = DateTime22.Value;
                                status = "Present";
                                course = CbCourse.Text;
                                className = cbClass.Text;
                            }
                            else
                            {
                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == null)
                                    continue;
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = DateTime22.Value;
                                status = "Absent";
                                course = CbCourse.Text;
                                className = cbClass.Text;
                            }
                            try
                            {
                                SqlCommand cmd = new SqlCommand("update attendance set classID=(select classID from class where className= '" + className + "'),courseID=(select courseID from course where courseName= '" + course + "'),status='" + status + "',date='" + MyDate + "' where stdID='" + id + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                                con.Close();
                            }
                        }
                        MessageBox.Show("updated...");
                        cbClass.Text = "";
                        CbCourse.Text = "";

                    }
                    else
                    {
                        for (int i = 0; i <= dataGridView1.RowCount - 2; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                            {
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = DateTime22.Value;
                                status = "Present";
                                course = CbCourse.Text;
                                className = cbClass.Text;
                            }
                            else
                            {
                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == null)
                                    continue;
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = DateTime22.Value;
                                status = "Absent";
                                course = CbCourse.Text;
                                className = cbClass.Text;
                            }
                            try
                            {
                                SqlCommand cmd = new SqlCommand("insert  into attendance values('" + id + "', (select classID from class where className='" + className + "'),(select courseID from course where courseName ='" + course + "'),'" + status + "','" + MyDate + "')", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                                con.Close();
                            }
                        }
                        MessageBox.Show("Inserted...");
                        cbClass.Text = "";
                        CbCourse.Text = "";
                    }
                }

                
                

            }


            else
            {
                MessageBox.Show("please fill combo boxes");
            }
        }
        private void BindCourse()
        {
            CbCourse.Items.Clear();
            try
            {

                SqlCommand cmd = new SqlCommand("select distinct (course.courseName)  from semester inner join course on semester.semID=course.semID inner join class on semester.semID = class.semID where course.semID=(select semID from class where classID=(select classID from class where className ='" + cbClass.SelectedItem + "') and course.facID= (select ID from class where classID = (select classID from class where className ='" + cbClass.Text + "')))", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CbCourse.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int cou = 0;
        void checkcourseID()
        {
            SqlCommand cmd = new SqlCommand("select count(courseID) from attendance where courseID=(select courseID from course where courseName='"+CbCourse.SelectedItem+"')",con);
            con.Open();
            cou = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int date = 0;
        void checkDate()
        {
            SqlCommand cmd = new SqlCommand("select count(Date) from attendance where date='"+DateTime22.Text+"'", con);
            con.Open();
            date = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int cl = 0;
        void checkClass()
        {
            SqlCommand cmd = new SqlCommand("select count(Date) from attendance where classID=(select classID from class where className='"+cbClass.SelectedItem+"')", con);
            con.Open();
            cl = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }

        private void DateTime22_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbClass_TextChanged(object sender, EventArgs e)
        {
            if (cbClass.Text.Length > 0)
            {
                string first = cbClass.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    cbClass.Text = string.Empty;
                    MessageBox.Show("Class Name Must Start Start a Character, Choose from Combox..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CbCourse_TextChanged(object sender, EventArgs e)
        {
            if (CbCourse.Text.Length > 0)
            {
                string first = CbCourse.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    CbCourse.Text = string.Empty;
                    MessageBox.Show("Course Name Must Start Start a Character, Choose from Combox..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
