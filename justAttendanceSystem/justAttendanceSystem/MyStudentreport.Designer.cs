
namespace justAttendanceSystem
{
    partial class MyStudentreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyStudentreport));
            this.studentReport1 = new justAttendanceSystem.studentReport();
            this.mini = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            this.SuspendLayout();
            // 
            // studentReport1
            // 
            this.studentReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.studentReport1.Location = new System.Drawing.Point(0, 2);
            this.studentReport1.Name = "studentReport1";
            this.studentReport1.Size = new System.Drawing.Size(922, 588);
            this.studentReport1.TabIndex = 0;
            this.studentReport1.Load += new System.EventHandler(this.studentReport1_Load);
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.mini.Image = ((System.Drawing.Image)(resources.GetObject("mini.Image")));
            this.mini.Location = new System.Drawing.Point(830, 13);
            this.mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(37, 32);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 37;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // MyStudentreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 592);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.studentReport1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyStudentreport";
            this.Text = "MyStudentreport";
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private studentReport studentReport1;
        private System.Windows.Forms.PictureBox mini;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}