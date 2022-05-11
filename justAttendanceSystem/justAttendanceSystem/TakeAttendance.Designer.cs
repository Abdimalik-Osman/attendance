
namespace justAttendanceSystem
{
    partial class TakeAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAttendance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTime22 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.cbClass = new Guna.UI.WinForms.GunaComboBox();
            this.CbCourse = new Guna.UI.WinForms.GunaComboBox();
            this.BtnSave = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Take Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // DateTime22
            // 
            this.DateTime22.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime22.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime22.Location = new System.Drawing.Point(36, 80);
            this.DateTime22.Name = "DateTime22";
            this.DateTime22.Size = new System.Drawing.Size(188, 30);
            this.DateTime22.TabIndex = 2;
            this.DateTime22.ValueChanged += new System.EventHandler(this.DateTime22_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHOOSE CLASS:";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.White;
            this.tt.Location = new System.Drawing.Point(482, 47);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(227, 30);
            this.tt.TabIndex = 4;
            this.tt.Text = "CHOOSE COURSE:";
            // 
            // cbClass
            // 
            this.cbClass.BackColor = System.Drawing.Color.Transparent;
            this.cbClass.BaseColor = System.Drawing.Color.White;
            this.cbClass.BorderColor = System.Drawing.Color.Silver;
            this.cbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FocusedColor = System.Drawing.Color.Empty;
            this.cbClass.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.ForeColor = System.Drawing.Color.Black;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(251, 82);
            this.cbClass.Name = "cbClass";
            this.cbClass.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbClass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbClass.Size = new System.Drawing.Size(190, 28);
            this.cbClass.TabIndex = 5;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            this.cbClass.TextChanged += new System.EventHandler(this.cbClass_TextChanged);
            // 
            // CbCourse
            // 
            this.CbCourse.BackColor = System.Drawing.Color.Transparent;
            this.CbCourse.BaseColor = System.Drawing.Color.White;
            this.CbCourse.BorderColor = System.Drawing.Color.Silver;
            this.CbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCourse.FocusedColor = System.Drawing.Color.Empty;
            this.CbCourse.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCourse.ForeColor = System.Drawing.Color.Black;
            this.CbCourse.FormattingEnabled = true;
            this.CbCourse.Location = new System.Drawing.Point(487, 80);
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbCourse.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbCourse.Size = new System.Drawing.Size(191, 28);
            this.CbCourse.TabIndex = 6;
            this.CbCourse.SelectedIndexChanged += new System.EventHandler(this.CbCourse_SelectedIndexChanged);
            this.CbCourse.TextChanged += new System.EventHandler(this.CbCourse_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.AnimationHoverSpeed = 0.07F;
            this.BtnSave.AnimationSpeed = 0.03F;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.BtnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(202)))), ((int)(((byte)(234)))));
            this.BtnSave.BorderColor = System.Drawing.Color.Black;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSave.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Image = null;
            this.BtnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSave.Location = new System.Drawing.Point(343, 572);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSave.OnHoverBorderColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverImage = null;
            this.BtnSave.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSave.Size = new System.Drawing.Size(136, 44);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(1, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(823, 440);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 3;
            this.chk.Name = "chk";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.gunaPanel1.Controls.Add(this.mini);
            this.gunaPanel1.Controls.Add(this.pictureBox2);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Location = new System.Drawing.Point(1, 1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(823, 41);
            this.gunaPanel1.TabIndex = 10;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.mini.Image = ((System.Drawing.Image)(resources.GetObject("mini.Image")));
            this.mini.Location = new System.Drawing.Point(734, 7);
            this.mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(37, 32);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 38;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(779, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // TakeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(826, 628);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CbCourse);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTime22);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeAttendance";
            this.Load += new System.EventHandler(this.TakeAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTime22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tt;
        private Guna.UI.WinForms.GunaComboBox cbClass;
        private Guna.UI.WinForms.GunaComboBox CbCourse;
        private Guna.UI.WinForms.GunaButton BtnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox mini;
    }
}