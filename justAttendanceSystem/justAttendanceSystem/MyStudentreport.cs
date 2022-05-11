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
    public partial class MyStudentreport : Form
    {
        public MyStudentreport()
        {
            InitializeComponent();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void studentReport1_Load(object sender, EventArgs e)
        {

        }
    }
}
