namespace Mid_Project_DB
{
    partial class AddStaff
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.Genders = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Designation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DOBpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AddAdvisor = new Guna.UI2.WinForms.Guna2Button();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Salary = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSalary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtContact, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.DOBpicker, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Genders, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Designation, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.AddAdvisor, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.Salary, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.110275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.13771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.379237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.13771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.379237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.13771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.379237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.13771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.110275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 597);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // txtSalary
            // 
            this.txtSalary.BorderRadius = 15;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(106, 162);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "Salary...";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(305, 88);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 15;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(106, 34);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "First Name..";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(305, 88);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.TabStopChanged += new System.EventHandler(this.txtFirstName_TabStopChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderRadius = 15;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(624, 34);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Last Name...";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(305, 88);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.BorderRadius = 15;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Location = new System.Drawing.Point(106, 290);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "Contact...";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(305, 88);
            this.txtContact.TabIndex = 5;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(624, 162);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email...";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(305, 88);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // Genders
            // 
            this.Genders.BackColor = System.Drawing.Color.Transparent;
            this.Genders.BorderRadius = 15;
            this.Genders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Genders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Genders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genders.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Genders.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Genders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Genders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Genders.ItemHeight = 30;
            this.Genders.Items.AddRange(new object[] {
            "Gender...",
            "Male",
            "Female"});
            this.Genders.Location = new System.Drawing.Point(106, 417);
            this.Genders.Name = "Genders";
            this.Genders.Size = new System.Drawing.Size(305, 36);
            this.Genders.StartIndex = 0;
            this.Genders.TabIndex = 7;
            this.Genders.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // Designation
            // 
            this.Designation.BackColor = System.Drawing.Color.Transparent;
            this.Designation.BorderRadius = 15;
            this.Designation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Designation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Designation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Designation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Designation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Designation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Designation.ItemHeight = 30;
            this.Designation.Items.AddRange(new object[] {
            "Designation...",
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.Designation.Location = new System.Drawing.Point(624, 417);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(305, 36);
            this.Designation.StartIndex = 0;
            this.Designation.TabIndex = 8;
            this.Designation.SelectedIndexChanged += new System.EventHandler(this.Designation_SelectedIndexChanged);
            // 
            // DOBpicker
            // 
            this.DOBpicker.BorderRadius = 15;
            this.DOBpicker.Checked = true;
            this.DOBpicker.CustomFormat = "yyyy-mm-dd";
            this.DOBpicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DOBpicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DOBpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBpicker.Location = new System.Drawing.Point(624, 289);
            this.DOBpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOBpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(305, 36);
            this.DOBpicker.TabIndex = 6;
            this.DOBpicker.Value = new System.DateTime(2023, 2, 20, 6, 30, 49, 887);
            this.DOBpicker.ValueChanged += new System.EventHandler(this.DOBpicker_ValueChanged);
            // 
            // AddAdvisor
            // 
            this.AddAdvisor.BorderRadius = 15;
            this.AddAdvisor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAdvisor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAdvisor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAdvisor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAdvisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAdvisor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddAdvisor.ForeColor = System.Drawing.Color.White;
            this.AddAdvisor.Location = new System.Drawing.Point(935, 543);
            this.AddAdvisor.Name = "AddAdvisor";
            this.AddAdvisor.Size = new System.Drawing.Size(99, 51);
            this.AddAdvisor.TabIndex = 9;
            this.AddAdvisor.Text = "ADD ADVISOR";
            this.AddAdvisor.Click += new System.EventHandler(this.AddAdvisor_Click);
            // 
            // Exit
            // 
            this.Exit.BorderRadius = 15;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(3, 543);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(97, 51);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "EXIT";
            this.Exit.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Dock = System.Windows.Forms.DockStyle.Top;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.ForeColor = System.Drawing.Color.Red;
            this.Salary.Location = new System.Drawing.Point(106, 254);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(305, 20);
            this.Salary.TabIndex = 13;
            this.Salary.Text = "label1";
            this.Salary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salary.Visible = false;
            this.Salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2ComboBox Genders;
        private Guna.UI2.WinForms.Guna2ComboBox Designation;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBpicker;
        private Guna.UI2.WinForms.Guna2Button AddAdvisor;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private System.Windows.Forms.Label Salary;
    }
}