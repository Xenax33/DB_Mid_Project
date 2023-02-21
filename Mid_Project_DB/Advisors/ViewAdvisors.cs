using Bunifu.UI.WinForms;
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

namespace Mid_Project_DB.Advisors
{
    public partial class ViewAdvisors : Form
    {
        int ID = -1;
        string FirstName;
        string LastName, Contact, Email;
        int salary, GEnder, Designation;

        public ViewAdvisors()
        {
            InitializeComponent();
        }

        private void ViewAdvisors_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select P1.Id , P1.FirstName , P1.LastName ,L.Value as Gender, P1.Contact , P1.Email , P1.DateOfBirth , P1.Designation \r\nfrom Lookup as L\r\njoin (select A.Id , P.FirstName , P.LastName , P.Contact , P.Email , P.DateOfBirth , L.Value as Designation , P.Gender\r\nfrom Advisor as A\r\njoin Person  as P\r\non P.Id = A.Id\r\njoin Lookup as L\r\non L.Id = A.Designation) as P1\r\non P1.Gender = L.Id");
            cmd.Connection = con;
            SqlDataReader sqlData = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlData);
            dataGridView1.DataSource = dataTable;
        }

        private void ViewAdvisors_Load_1(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select P1.Id , P1.FirstName , P1.LastName ,L.Value as Gender, P1.Contact , P1.Email , P1.DateOfBirth , P1.Designation \r\nfrom Lookup as L\r\njoin (select A.Id , P.FirstName , P.LastName , P.Contact , P.Email , P.DateOfBirth , L.Value as Designation , P.Gender\r\nfrom Advisor as A\r\njoin Person  as P\r\non P.Id = A.Id\r\njoin Lookup as L\r\non L.Id = A.Designation) as P1\r\non P1.Gender = L.Id");
            cmd.Connection = con;
            SqlDataReader sqlData = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlData);
            dataGridView1.DataSource = dataTable;
        }

        private void guna2DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form form = new AddStaff();
            form.Show();
        }

        private void Delete_Advisor_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("delete Advisor where Id = @ID; delete Person where Id = @ID;");
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Has Been Deleted Successfully...");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select A Row To Deleteo...");
            }
        }

        private void guna2DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void Edit_Advisor_Click(object sender, EventArgs e)
        {
            Form form = new AddStaff();
            form.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            FirstName = 
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
