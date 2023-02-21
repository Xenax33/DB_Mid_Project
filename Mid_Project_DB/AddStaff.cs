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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mid_Project_DB
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        public AddStaff(string FirstName , string LastName , string Contact , string email , int Salary , int Gender , int Designations)
        {
            InitializeComponent();
            txtContact.Text = Contact;
            txtEmail.Text = email;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;    
            Genders.SelectedIndex = Gender;
            Designation.SelectedIndex = Designations;
        }

        private bool checkID(string s)
        {
            for (int i = 0; i < s.Length; i++)
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
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen();
        }

        private void AddAdvisor_Click(object sender, EventArgs e)
        {
            Salary.Visible = false;
            if (string.IsNullOrEmpty(txtSalary.Text) || Designation.SelectedIndex == 0 || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please Fill All Queries...");
            }
            else
            {

                if (!checkID(txtSalary.Text))
                {
                    Salary.Text = "*Salary can only consist of digits.";
                    Salary.Visible = true;
                }
                else
                {
                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("							INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) VALUES (@FirstName,@LastName, @Contact,@Email,@DOB, @Gender) "+
                            "insert into Advisor(Id, Salary, Designation) VALUES((SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email AND DateOfBirth = @DOB AND Gender = @Gender), @Salary, @Designation); ", con);
                        cmd.Parameters.AddWithValue("@Salary", int.Parse(txtSalary.Text));
                        cmd.Parameters.AddWithValue("@Designation", Designation.SelectedIndex + 5);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Gender", Genders.SelectedIndex);
                        DOBpicker.Format = DateTimePickerFormat.Custom;
                        DOBpicker.CustomFormat = "yyyy-MM-dd";
                        cmd.Parameters.AddWithValue("@DOB", DOBpicker.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ID must be unique");
                    }

                }
            
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TabStopChanged(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOBpicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Salary_Click(object sender, EventArgs e)
        {

        }
    }
}
