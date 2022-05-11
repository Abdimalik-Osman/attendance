
namespace justAttendanceSystem.pal.forms
{
    partial class emailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailForm));
            this.btnVerify = new Guna.UI.WinForms.GunaAdvenceButton();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.AnimationHoverSpeed = 0.07F;
            this.btnVerify.AnimationSpeed = 0.03F;
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVerify.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVerify.BorderColor = System.Drawing.Color.Black;
            this.btnVerify.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnVerify.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnVerify.CheckedForeColor = System.Drawing.Color.White;
            this.btnVerify.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnVerify.CheckedImage")));
            this.btnVerify.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnVerify.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerify.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerify.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnVerify.Location = new System.Drawing.Point(178, 250);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVerify.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerify.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerify.OnHoverImage = null;
            this.btnVerify.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnVerify.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerify.Size = new System.Drawing.Size(145, 42);
            this.btnVerify.TabIndex = 16;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(131, 207);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(244, 28);
            this.textEmail.TabIndex = 14;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Please Enter Your E-mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.panel4.Controls.Add(this.mini);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 43);
            this.panel4.TabIndex = 41;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.mini.Image = ((System.Drawing.Image)(resources.GetObject("mini.Image")));
            this.mini.Location = new System.Drawing.Point(434, 7);
            this.mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(37, 32);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 34;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(477, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "FORGOT PASSWORD";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // emailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(514, 320);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emailForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btnVerify;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox mini;
    }
}