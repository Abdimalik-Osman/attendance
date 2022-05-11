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
using justAttendanceSystem.pal.forms;
using System.Text.RegularExpressions;

namespace justAttendanceSystem
{
   

    public partial class studentReport : UserControl
    {
        private string sql = @"Data Source=.;Initial Catalog=justAttendanceSystem;Integrated Security=True";
        SqlDataReader dr;
        public studentReport()
        {
            InitializeComponent();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("Select student.stdID,student.stdName, class.className, course.courseName, attendance.date, attendance.status from attendance inner join student on attendance.stdID = student.stdID inner join class on class.classID = attendance.classID inner join course on course.courseID = attendance.courseID where  student.stdID = '" + getUsers.MyUser + "' and course.courseName = '" + cmbCourse.Text + "';", DataGridView1, sql);
            }
        }
        private void getstdcourse()
        {

            Attendance.Attendance.FillComboBox("select course.courseName FRom course where semID = (select class.semID from class inner join student on student.classID = class.classID where student.stdID='" + getUsers.MyUser + "') ", cmbCourse, sql);
        }

        private void studentReport_Load(object sender, EventArgs e)
        {
            getstdcourse();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            print();
        }
        private void print()
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Attendance Sheet" + "\n" + "\n";

            if (cmbCourse.SelectedIndex != -1)
            {
                if (cmbCourse.Text.Trim() == string.Empty)
                {
                    printer.SubTitle += cmbCourse.Text.Trim() + " Student Report \n" + "\n" + dateTimePicker1.Text + "\n" + "\n" + "\n";

                }
                else
                {

                    var present = DataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column12"].Value.ToString() == "Present");
                    var absent = DataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column12"].Value.ToString() == "Absent");
                    int Total = present + absent;
                    double absentAvg = Math.Round((double.Parse(absent.ToString()) / double.Parse(Total.ToString())) * 100, 2);


                    printer.SubTitle += dateTimePicker1.Text + "\n" + "\n";
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

                cmbCourse.Text = "";

            }
            else
            {
                MessageBox.Show("Fill the blanks..");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to logout", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {

                loginForm login = new loginForm();
                login.Show();
                this.Hide();
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
    }
}
