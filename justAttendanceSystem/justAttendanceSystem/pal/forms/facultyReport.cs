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
using DGVPrinterHelper;
using System.Text.RegularExpressions;

namespace justAttendanceSystem.pal.forms
{
    public partial class facultyReport : Form
    {
        
        private string sql = @"Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True";
        SqlDataReader dr;
        public facultyReport()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
           
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentReport_Click(object sender, EventArgs e)
        {

        }

        private void cmbClass_Click(object sender, EventArgs e)
        {
            cmbClass.Items.Clear();
            Attendance.Attendance.FillComboBox("select distinct(className) from class;", cmbClass, sql);
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (cmbCourse.SelectedIndex != -1 && cmbClass.SelectedIndex != -1 && cmbStudent.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("Select student.stdID,student.stdName, class.className, course.courseName, attendance.date, attendance.status from attendance inner join student on attendance.stdID = student.stdID inner join class on class.classID = attendance.classID inner join course on course.courseID = attendance.courseID where  student.stdID = '" + cmbStudent.Text + "' and course.courseName = '" + cmbCourse.Text + "';", DataGridView1, sql);
            }
        }

        private void cmbStudent_Click(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex != -1 && cmbCourse.SelectedIndex != -1)
            {
                cmbStudent.Items.Clear();
                Attendance.Attendance.FillComboBox("select student.stdID, class.className from student inner join class on student.classID=class.classID where class.className= '" + cmbClass.Text + "'", cmbStudent, sql);
            }
        }
     
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cmbCourse.SelectedIndex != -1 && cmbCourse.SelectedIndex != -1 ) 
            {

                Attendance.Attendance.DisplayAndSearchAllData("Select student.stdID,student.stdName, class.className, course.courseName, attendance.date, attendance.status from attendance inner join student on attendance.stdID = student.stdID inner join class on class.classID = attendance.classID inner join course on course.courseID = attendance.courseID where  class.className = '" + cmbClass.Text + "' and course.courseName = '" + cmbCourse.Text + "';", DataGridView1, sql);
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (cmbClass.SelectedIndex != -1)
            {
                
                Attendance.Attendance.DisplayAndSearchAllData("Select student.stdID,student.stdName, class.className, course.courseName, attendance.date, attendance.status from attendance inner join student on attendance.stdID = student.stdID inner join class on class.classID = attendance.classID inner join course on course.courseID = attendance.courseID where  class.className = '" + cmbClass.Text + "' and course.courseName = '" + cmbCourse.Text + "';", DataGridView1, sql);
            }
        }
     
        private void print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Attendance Sheet" + "\n" + "\n" ;

            if (cmbCourse.SelectedIndex != -1 && cmbClass.SelectedIndex != -1)
            {
                if (cmbClass.Text.Trim() == string.Empty && cmbCourse.Text.Trim() == string.Empty)
                {
                    printer.SubTitle += cmbClass.Text.Trim() + " Student Report \n" + "\n" + dateTimePicker1.Text + "\n" + "\n" + "\n";
                   
                }
                else
                {

                    var present = DataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column12"].Value.ToString() == "Present");
                    var absent = DataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column12"].Value.ToString() == "Absent");
                    int Total = present + absent;
                    double absentAvg =Math.Round((double.Parse(absent.ToString())/double.Parse(Total.ToString())) * 100,2);
                    

                    printer.SubTitle += dateTimePicker1.Text + "\n" + "\n" ;
                    printer.SubTitle += "Total Periods: " + Total + "\n";
                    printer.SubTitle += "Present Periods: " + present + "\n";
                    printer.SubTitle += "Absent Periods: " + absent + "\n";
                    printer.SubTitle += "Attendance Rate: " + absentAvg + "%" + "\n";

                }

                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.TitleColor = Color.Red;
                printer.SubTitleColor = Color.FromArgb(2, 136, 217);


                printer.Footer = "CopyRight By Our Group";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(DataGridView1);
                MessageBox.Show("Printed....");
                cmbClass.Text = "";
                cmbCourse.Text = "";
                cmbStudent.Text = "";
            }
            else
            {
                MessageBox.Show("Fill the blanks..");
            }
            
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            print();
        }

        private void cmbCourse_Click(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex  != 1)
            {
                cmbCourse.Items.Clear();
                cmbStudent.Items.Clear();
                Attendance.Attendance.FillComboBox("select distinct (course.courseName) from semester inner join course on semester.semID=course.semID inner join class on semester.semID = class.semID where course.semID=(select semID from class where className='" + cmbClass.SelectedItem + "' and course.facID= (select ID from class where className = '" + cmbClass.Text + "'))", cmbCourse, sql);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmbClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnGetData_Click(object sender, EventArgs e)
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

        private void cmbStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbStudent.Text.Length > 0)
            {
                string first = cmbStudent.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    cmbStudent.Text = string.Empty;
                    MessageBox.Show("Student ID Must start a Character, Choose from Combox..","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

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
                    MessageBox.Show("Course Name Must Start a Character, Choose from Combox..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbStudent_TextChanged(object sender, EventArgs e)
        {
            if (cmbStudent.Text.Length > 0)
            {
                string first = cmbStudent.Text.Substring(0, 1);
                if (!isAlpha(first))
                {
                    cmbStudent.Text = string.Empty;
                    MessageBox.Show("Student ID Must start a Character, Choose from Combox..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
    
}
