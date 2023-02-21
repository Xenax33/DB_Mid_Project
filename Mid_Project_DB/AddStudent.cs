using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mid_Project_DB
{
    public partial class AddStudent : Form
    {
        private static string date1;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool checkID(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DOBLabel.Visible = false;
            FirstName.Visible = false;
            RegNo.Visible = false;
            LastName.Visible = false;
            Email.Visible = false;
            Contact.Visible = false;
            Exit.Visible = false;
            bool flag = true;

            if (flag)
            {
                if (string.IsNullOrEmpty(txtContactNumber.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtRegNo.Text))
                {
                    MessageBox.Show("Please Fill All The Queries...");
                    flag = false;
                }
            }
            try
            {
                if (flag)
                {
                    if (!string.IsNullOrEmpty(txtContactNumber.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtRegNo.Text) && Gender.SelectedIndex != 0)
                    {
                        int gender = 0;
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) VALUES (@FirstName,@LastName, @Contact,@Email,@DOB, @Gender)", con);
                        SqlCommand cmd1 = new SqlCommand("insert into Student(Id,RegistrationNo) VALUES ((SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName=@LastName AND Contact=@Contact AND Email=@Email AND DateOfBirth=@DOB AND Gender=@Gender) ,@RegistrationNo)", con);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtContactNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@RegistrationNo", txtRegNo.Text);
                        cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd1.Parameters.AddWithValue("@Contact", txtContactNumber.Text);
                        cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd1.Parameters.AddWithValue("@RegistrationNo", txtRegNo.Text);
                        if (Gender.SelectedIndex == 1)
                        {
                            gender = 1;
                        }
                        if (Gender.SelectedIndex == 2)
                        {
                            gender = 2;
                        }
                        guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
                        guna2DateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", guna2DateTimePicker1.Text);
                        cmd1.Parameters.AddWithValue("@Gender", gender);
                        cmd1.Parameters.AddWithValue("@DOB", guna2DateTimePicker1.Text);
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen();
            DOBLabel.Visible= false;
            FirstName.Visible = false;
            RegNo.Visible = false;
            LastName.Visible = false;
            Email.Visible = false;
            Contact.Visible = false;
            Exit.Visible = false;
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
