using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justAttendanceSystem.pal.forms
{
    public partial class mainForm : Form
    {
        private bool isCollapsed;
        public mainForm()
        {
            InitializeComponent();
            timer1.Start();
        }
        bool expand;

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblTimer.Text = now.ToString("f");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.ShowDialog();
            
        }

       

        private void btnAttandance_Click(object sender, EventArgs e)
        {
            TakeAttendance attendance = new TakeAttendance();
            attendance.Show();
            
           
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            facultyReport fr = new facultyReport();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void mini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            MyStudentreport std = new MyStudentreport();
            std.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                OurPanel.Height += 10;
                if (OurPanel.Size == OurPanel.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                OurPanel.Height -= 10;
                if (OurPanel.Size == OurPanel.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnReport_Click_2(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
