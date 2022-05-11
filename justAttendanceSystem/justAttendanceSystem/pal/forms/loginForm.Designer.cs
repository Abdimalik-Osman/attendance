
namespace justAttendanceSystem.pal.forms
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRollError = new System.Windows.Forms.Label();
            this.lblUserError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.picSecure = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecure)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.panel1.Location = new System.Drawing.Point(419, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 312);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRollError);
            this.groupBox1.Controls.Add(this.lblUserError);
            this.groupBox1.Controls.Add(this.lblPasswordError);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.picShow);
            this.groupBox1.Controls.Add(this.picHide);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblForgotPassword);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 328);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login Here";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRollError
            // 
            this.lblRollError.AutoSize = true;
            this.lblRollError.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollError.ForeColor = System.Drawing.Color.Red;
            this.lblRollError.Location = new System.Drawing.Point(99, 34);
            this.lblRollError.Name = "lblRollError";
            this.lblRollError.Size = new System.Drawing.Size(0, 23);
            this.lblRollError.TabIndex = 17;
            // 
            // lblUserError
            // 
            this.lblUserError.AutoSize = true;
            this.lblUserError.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserError.ForeColor = System.Drawing.Color.Red;
            this.lblUserError.Location = new System.Drawing.Point(147, 100);
            this.lblUserError.Name = "lblUserError";
            this.lblUserError.Size = new System.Drawing.Size(0, 23);
            this.lblUserError.TabIndex = 16;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(120, 169);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 23);
            this.lblPasswordError.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Role:";
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "admin",
            "lecturer",
            "student",
            "examDepart"});
            this.cbRole.Location = new System.Drawing.Point(132, 64);
            this.cbRole.MaxLength = 10;
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(238, 31);
            this.cbRole.TabIndex = 13;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            this.cbRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRole_KeyPress);
            // 
            // picShow
            // 
            this.picShow.BackColor = System.Drawing.SystemColors.Window;
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(312, 198);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(56, 26);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 10;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click_1);
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.SystemColors.Window;
            this.picHide.Image = ((System.Drawing.Image)(resources.GetObject("picHide.Image")));
            this.picHide.Location = new System.Drawing.Point(311, 198);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(56, 26);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 9;
            this.picHide.TabStop = false;
            this.picHide.Visible = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.CheckedImage")));
            this.btnLogin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogin.Location = new System.Drawing.Point(143, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(149, 40);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(138, 235);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(187, 26);
            this.lblForgotPassword.TabIndex = 6;
            this.lblForgotPassword.Text = "Forgot Password";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textPassword.Location = new System.Drawing.Point(131, 199);
            this.textPassword.MaxLength = 6;
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(238, 25);
            this.textPassword.TabIndex = 3;
            this.textPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPassword_KeyPress);
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textUserName.Location = new System.Drawing.Point(134, 128);
            this.textUserName.MaxLength = 7;
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(238, 25);
            this.textUserName.TabIndex = 2;
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            this.textUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textUserName_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.mini);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 59);
            this.panel3.TabIndex = 38;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.mini.Image = ((System.Drawing.Image)(resources.GetObject("mini.Image")));
            this.mini.Location = new System.Drawing.Point(573, 12);
            this.mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(44, 26);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 34;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(633, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(181, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(242, 43);
            this.label14.TabIndex = 33;
            this.label14.Text = "LOGIN FORM";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // picSecure
            // 
            this.picSecure.Image = ((System.Drawing.Image)(resources.GetObject("picSecure.Image")));
            this.picSecure.Location = new System.Drawing.Point(439, 83);
            this.picSecure.Name = "picSecure";
            this.picSecure.Size = new System.Drawing.Size(224, 310);
            this.picSecure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecure.TabIndex = 8;
            this.picSecure.TabStop = false;
            this.picSecure.Click += new System.EventHandler(this.picSecure_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(675, 405);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.picSecure);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picSecure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picHide;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRole;
        public System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label lblUserError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblRollError;
        private System.Windows.Forms.PictureBox mini;
    }
}