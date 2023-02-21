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

namespace Mid_Project_DB.Students
{
    public partial class ViewStudents : Form
    {
        private static int ID = -1;
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select S.Id , S.RegistrationNo , P.FirstName , P.LastName , P.Contact , P.DateOfBirth , P.Email , L.Value \r\nfrom Student as S\r\njoin Person as P\r\non S.Id = P.Id\r\njoin Lookup as L\r\non L.Id = P.Gender");
            cmd.Connection = con;
            SqlDataReader sqlData = cmd.ExecuteReader();
            DataTable dataTable= new DataTable();
            dataTable.Load(sqlData);
            dataGridView1.DataSource = dataTable; 
        }

        private void StudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form form = new AddStudent();
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("delete Student where Id = @ID; delete Person where Id = @ID;");
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
