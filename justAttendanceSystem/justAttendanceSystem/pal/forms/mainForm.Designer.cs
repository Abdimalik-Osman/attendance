
namespace justAttendanceSystem.pal.forms
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OurPanel = new System.Windows.Forms.Panel();
            this.btnReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStudentReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFacultReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttandance = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerReport = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.OurPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.OurPanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAttandance);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 622);
            this.panel1.TabIndex = 4;
            // 
            // OurPanel
            // 
            this.OurPanel.Controls.Add(this.btnReport);
            this.OurPanel.Controls.Add(this.btnStudentReport);
            this.OurPanel.Controls.Add(this.btnFacultReport);
            this.OurPanel.Location = new System.Drawing.Point(0, 389);
            this.OurPanel.MaximumSize = new System.Drawing.Size(255, 143);
            this.OurPanel.MinimumSize = new System.Drawing.Size(255, 58);
            this.OurPanel.Name = "OurPanel";
            this.OurPanel.Size = new System.Drawing.Size(255, 58);
            this.OurPanel.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.AnimationHoverSpeed = 0.07F;
            this.btnReport.AnimationSpeed = 0.03F;
            this.btnReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnReport.BorderColor = System.Drawing.Color.Black;
            this.btnReport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReport.CheckedForeColor = System.Drawing.Color.White;
            this.btnReport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReport.CheckedImage")));
            this.btnReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReport.Location = new System.Drawing.Point(0, 0);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReport.OnHoverImage = null;
            this.btnReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnReport.Size = new System.Drawing.Size(255, 56);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_2);
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.AnimationHoverSpeed = 0.07F;
            this.btnStudentReport.AnimationSpeed = 0.03F;
            this.btnStudentReport.BaseColor = System.Drawing.Color.Navy;
            this.btnStudentReport.BorderColor = System.Drawing.Color.Black;
            this.btnStudentReport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnStudentReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStudentReport.CheckedForeColor = System.Drawing.Color.White;
            this.btnStudentReport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnStudentReport.CheckedImage")));
            this.btnStudentReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStudentReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudentReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudentReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentReport.ForeColor = System.Drawing.Color.White;
            this.btnStudentReport.Image = null;
            this.btnStudentReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStudentReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStudentReport.Location = new System.Drawing.Point(0, 97);
            this.btnStudentReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnStudentReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudentReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStudentReport.OnHoverImage = null;
            this.btnStudentReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStudentReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudentReport.Size = new System.Drawing.Size(255, 42);
            this.btnStudentReport.TabIndex = 13;
            this.btnStudentReport.Text = "Student Report";
            this.btnStudentReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // btnFacultReport
            // 
            this.btnFacultReport.AnimationHoverSpeed = 0.07F;
            this.btnFacultReport.AnimationSpeed = 0.03F;
            this.btnFacultReport.BaseColor = System.Drawing.Color.Navy;
            this.btnFacultReport.BorderColor = System.Drawing.Color.Black;
            this.btnFacultReport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFacultReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFacultReport.CheckedForeColor = System.Drawing.Color.White;
            this.btnFacultReport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnFacultReport.CheckedImage")));
            this.btnFacultReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFacultReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFacultReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnFacultReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacultReport.ForeColor = System.Drawing.Color.White;
            this.btnFacultReport.Image = null;
            this.btnFacultReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFacultReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFacultReport.Location = new System.Drawing.Point(0, 55);
            this.btnFacultReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFacultReport.Name = "btnFacultReport";
            this.btnFacultReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFacultReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFacultReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFacultReport.OnHoverImage = null;
            this.btnFacultReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFacultReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnFacultReport.Size = new System.Drawing.Size(255, 42);
            this.btnFacultReport.TabIndex = 12;
            this.btnFacultReport.Text = " Facult Report";
            this.btnFacultReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFacultReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATTENDANCE MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAttandance
            // 
            this.btnAttandance.AnimationHoverSpeed = 0.07F;
            this.btnAttandance.AnimationSpeed = 0.03F;
            this.btnAttandance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAttandance.BorderColor = System.Drawing.Color.Black;
            this.btnAttandance.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAttandance.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAttandance.CheckedForeColor = System.Drawing.Color.White;
            this.btnAttandance.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAttandance.CheckedImage")));
            this.btnAttandance.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAttandance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAttandance.FocusedColor = System.Drawing.Color.Empty;
            this.btnAttandance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttandance.ForeColor = System.Drawing.Color.White;
            this.btnAttandance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttandance.Image")));
            this.btnAttandance.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAttandance.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAttandance.Location = new System.Drawing.Point(-1, 340);
            this.btnAttandance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttandance.Name = "btnAttandance";
            this.btnAttandance.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAttandance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAttandance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAttandance.OnHoverImage = null;
            this.btnAttandance.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAttandance.OnPressedColor = System.Drawing.Color.Black;
            this.btnAttandance.Size = new System.Drawing.Size(256, 42);
            this.btnAttandance.TabIndex = 10;
            this.btnAttandance.Text = "Attendance";
            this.btnAttandance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAttandance.Click += new System.EventHandler(this.btnAttandance_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.LineColor = System.Drawing.Color.Navy;
            this.btnDashboard.Location = new System.Drawing.Point(0, 285);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Size = new System.Drawing.Size(255, 42);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(118, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(43, 28);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "(?)";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.gunaPanel1.Controls.Add(this.mini);
            this.gunaPanel1.Controls.Add(this.pictureBox2);
            this.gunaPanel1.Controls.Add(this.lblTimer);
            this.gunaPanel1.Location = new System.Drawing.Point(255, 1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(976, 63);
            this.gunaPanel1.TabIndex = 8;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.mini.Image = ((System.Drawing.Image)(resources.GetObject("mini.Image")));
            this.mini.Location = new System.Drawing.Point(864, 12);
            this.mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(44, 42);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 13;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(917, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(255, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 557);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // timerReport
            // 
            this.timerReport.Interval = 20;
            
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1229, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            
            this.panel1.ResumeLayout(false);
            this.OurPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.Panel OurPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public Guna.UI.WinForms.GunaAdvenceButton btnAttandance;
        public Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        public Guna.UI.WinForms.GunaAdvenceButton btnReport;
        public Guna.UI.WinForms.GunaAdvenceButton btnFacultReport;
        public Guna.UI.WinForms.GunaAdvenceButton btnStudentReport;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}