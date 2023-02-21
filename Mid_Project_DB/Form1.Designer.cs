namespace Mid_Project_DB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.AddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.AdvisorsPanel = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SidebadAnimation = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.StudentsTimer = new System.Windows.Forms.Timer(this.components);
            this.AdvisorTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Students = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Sidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.StudentPanel.SuspendLayout();
            this.AdvisorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.AllowDrop = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(24)))), ((int)(((byte)(96)))));
            this.Sidebar.Controls.Add(this.guna2Panel1);
            this.Sidebar.Controls.Add(this.StudentPanel);
            this.Sidebar.Controls.Add(this.AdvisorsPanel);
            this.Sidebar.Controls.Add(this.guna2Button3);
            this.Sidebar.Controls.Add(this.guna2Button4);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(169, 0);
            this.Sidebar.MinimumSize = new System.Drawing.Size(70, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(70, 625);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.MenuButton);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(166, 62);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // StudentPanel
            // 
            this.StudentPanel.Controls.Add(this.Students);
            this.StudentPanel.Controls.Add(this.AddStudent);
            this.StudentPanel.Location = new System.Drawing.Point(3, 71);
            this.StudentPanel.MaximumSize = new System.Drawing.Size(168, 104);
            this.StudentPanel.MinimumSize = new System.Drawing.Size(168, 58);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(168, 58);
            this.StudentPanel.TabIndex = 1;
            // 
            // AddStudent
            // 
            this.AddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.AddStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent.ForeColor = System.Drawing.Color.White;
            this.AddStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddStudent.ImageSize = new System.Drawing.Size(40, 40);
            this.AddStudent.Location = new System.Drawing.Point(0, 64);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(169, 39);
            this.AddStudent.TabIndex = 1;
            this.AddStudent.Text = "VIEW STUDENT";
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // AdvisorsPanel
            // 
            this.AdvisorsPanel.Controls.Add(this.guna2Button1);
            this.AdvisorsPanel.Controls.Add(this.guna2Button2);
            this.AdvisorsPanel.Location = new System.Drawing.Point(3, 135);
            this.AdvisorsPanel.MaximumSize = new System.Drawing.Size(169, 106);
            this.AdvisorsPanel.MinimumSize = new System.Drawing.Size(169, 59);
            this.AdvisorsPanel.Name = "AdvisorsPanel";
            this.AdvisorsPanel.Size = new System.Drawing.Size(169, 59);
            this.AdvisorsPanel.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(0, 65);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(169, 39);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "VIEW ADVISORS";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(3, 200);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(169, 59);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "ADD PROJECT";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // SidebadAnimation
            // 
            this.SidebadAnimation.Interval = 5;
            this.SidebadAnimation.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(70, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1073, 625);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint_1);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 50;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // StudentsTimer
            // 
            this.StudentsTimer.Interval = 200;
            this.StudentsTimer.Tick += new System.EventHandler(this.StudentsTimer_Tick);
            // 
            // AdvisorTimer
            // 
            this.AdvisorTimer.Interval = 200;
            this.AdvisorTimer.Tick += new System.EventHandler(this.AdvisorTimer_Tick);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.FillColor = System.Drawing.Color.Transparent;
            this.MenuButton.Image = global::Mid_Project_DB.Properties.Resources.menu;
            this.MenuButton.ImageRotate = 0F;
            this.MenuButton.Location = new System.Drawing.Point(0, 9);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(68, 44);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.UseTransparentBackground = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Students
            // 
            this.Students.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Students.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Students.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Students.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Students.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.Students.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.Image = ((System.Drawing.Image)(resources.GetObject("Students.Image")));
            this.Students.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Students.ImageSize = new System.Drawing.Size(40, 40);
            this.Students.Location = new System.Drawing.Point(-3, 0);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(169, 59);
            this.Students.TabIndex = 0;
            this.Students.Text = "STUDENTS";
            this.Students.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Students.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Mid_Project_DB.Properties.Resources.student;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(169, 59);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "ADVISORS";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::Mid_Project_DB.Properties.Resources.Exit;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.IndicateFocus = true;
            this.guna2Button4.Location = new System.Drawing.Point(3, 265);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(169, 59);
            this.guna2Button4.TabIndex = 2;
            this.guna2Button4.Text = "EXIT";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1143, 625);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.Sidebar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sidebar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.StudentPanel.ResumeLayout(false);
            this.AdvisorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Students;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox MenuButton;
        private System.Windows.Forms.Timer SidebadAnimation;
        private System.Windows.Forms.Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Timer StudentsTimer;
        private System.Windows.Forms.Panel StudentPanel;
        private Guna.UI2.WinForms.Guna2Button AddStudent;
        private System.Windows.Forms.Panel AdvisorsPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Timer AdvisorTimer;
    }
}

