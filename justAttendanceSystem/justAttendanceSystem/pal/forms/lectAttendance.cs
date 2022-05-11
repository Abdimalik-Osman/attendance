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
    public partial class lectAttendance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True");
        SqlDataReader dr;

        public lectAttendance()
        {
            InitializeComponent();
            


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            
            BindData();
            //display();
            BindCourse();
        }
        private void BindData()
        {
            SqlCommand cmd = new SqlCommand("select class.className From class inner join lecturerSubjects on lecturerSubjects.classID = class.classID where lecturerSubjects.lecID ='"+getUsers.MyUser+"'", con);
            con.Open();
          dr=  cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbClass.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClicked((CheckBox)sender);
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Leave(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void cmbClass_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string id = "", status = "", course = "", className = "";
            DateTime MyDate;
            if (cmbClass.Text != "" && cmbCourse.Text != "")
            {

                DateTime myTime = DateTime.Now;
                var shortDate = myTime.ToShortDateString();
                if (dateTimePickerDate.Value.ToShortDateString() != shortDate)
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
                                MyDate = dateTimePickerDate.Value;
                                status = "Present";
                                course = cmbCourse.Text;
                                className = cmbClass.Text;
                            }
                            else
                            {
                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == null)
                                    continue;
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = dateTimePickerDate.Value;
                                status = "Absent";
                                course = cmbCourse.Text;
                                className = cmbClass.Text;
                            }
                            try
                            {
                                SqlCommand cmd = new SqlCommand("update attendance set classID=(select classID from class where className ='" + className + "'),courseID=(select courseID from course where courseName= '" + course + "'),status='" + status + "',date='" + MyDate + "' where stdID='" + id + "'", con);
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
                        cmbClass.Text = "";
                        cmbCourse.Text = "";

                    }
                    else
                    {
                        for (int i = 0; i <= dataGridView1.RowCount - 2; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                            {
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = dateTimePickerDate.Value;
                                status = "Present";
                                course = cmbCourse.Text;
                                className = cmbClass.Text;
                            }
                            else
                            {
                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == null)
                                    continue;
                                id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                MyDate = dateTimePickerDate.Value;
                                status = "Absent";
                                course = cmbCourse.Text;
                                className = cmbClass.Text;
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
                        cmbClass.Text = "";
                        cmbCourse.Text = "";
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
            cmbCourse.Items.Clear();
            try
            {

                SqlCommand cmd = new SqlCommand("select course.courseName  from lecturerSubjects inner join course on course.courseID = lecturerSubjects.courseID inner join class on lecturerSubjects.classID= class.classID where lecID='"+getUsers.MyUser+"' and class.className='"+cmbClass.SelectedItem+"'", con );
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbCourse.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        int cou = 0;
        void checkcourseID()
        {
            SqlCommand cmd = new SqlCommand("select count(courseID) from attendance where courseID=(select courseID from course where courseName='" + cmbCourse.SelectedItem + "')", con);
            con.Open();
            cou = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int date = 0;
        void checkDate()
        {
            SqlCommand cmd = new SqlCommand("select count(Date) from attendance where date='" + dateTimePickerDate.Text + "'", con);
            con.Open();
            date = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        int cl = 0;
        void checkClass()
        {
            SqlCommand cmd = new SqlCommand("select count(Date) from attendance where classID=(select classID from class where className='" + cmbClass.SelectedItem + "')", con);
            con.Open();
            cl = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
        }
        private void display()
        {
            SqlDataAdapter da = new SqlDataAdapter("select stdID,stdName from student ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"];
        }

        private void cmbClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select  student.stdID,student.stdName from Student inner join class on student.classID = class.classID where class.classID=(select classID from class where className ='"+cmbClass.Text+"' )", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["Student"];
            BindCourse();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to logout", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Stop();
                loginForm login = new loginForm();
                login.Show();
                this.Hide();
            }
        }
        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbClass_TextChanged(object sender, EventArgs e)
        {
            if (cmbClass.Text.Length > 0)
            {
                string first = cmbClass.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    cmbClass.Text = string.Empty;
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

        private void cmbCourse_TextChanged(object sender, EventArgs e)
        {
            if (cmbCourse.Text.Length > 0)
            {
                string first = cmbCourse.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    cmbCourse.Text = string.Empty;
                    MessageBox.Show("Course Name Must Start Start a Character, Choose from Combox..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
