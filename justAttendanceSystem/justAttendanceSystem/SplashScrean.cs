using justAttendanceSystem.pal.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justAttendanceSystem
{
    public partial class SplashScrean : Form
    {
        public SplashScrean()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width > 590)
            {
                timer1.Stop();
                loginForm login = new loginForm();
                login.Show();
                this.Hide();
            }
        }

        private void SplashScrean_Load(object sender, EventArgs e)
        {

        }
    }
}

