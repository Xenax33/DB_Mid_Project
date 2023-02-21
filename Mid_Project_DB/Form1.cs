using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mid_Project_DB.Students;
using Mid_Project_DB.Advisors;
namespace Mid_Project_DB
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        bool sidebadexpand;
        bool StudentSubMenu;
        bool AdvisorsSubMenu;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (sidebadexpand)
            { 
                StudentsTimer.Start(); 
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (sidebadexpand)
            {
                AdvisorTimer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebadexpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebadexpand = false;
                    SidebadAnimation.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebadexpand = true;
                    SidebadAnimation.Stop() ;
                }
            }
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            AdvisorsSubMenu = false;
            StudentSubMenu = false;
            StudentsTimer.Start();
            AdvisorTimer.Start();
            SidebadAnimation.Start();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void StudentsTimer_Tick(object sender, EventArgs e)
        {
            if (StudentSubMenu)
            {
                StudentPanel.Height += StudentPanel.Height;
                if (StudentPanel.Height == StudentPanel.MaximumSize.Height)
                {
                    StudentSubMenu = false;
                    StudentsTimer.Stop();
                }
            }
            else
            {
                StudentPanel.Height -= StudentPanel.Height;
                if (StudentPanel.Height == StudentPanel.MinimumSize.Height)
                {
                    StudentSubMenu = true;
                    StudentsTimer.Stop();
                }
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudent());
            OpenChildForm(new ViewStudents());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAdvisors());
        }

        private void AdvisorTimer_Tick(object sender, EventArgs e)
        {
            if (AdvisorsSubMenu)
            {
                AdvisorsPanel.Height += AdvisorsPanel.Height;
                if (AdvisorsPanel.Height == AdvisorsPanel.MaximumSize.Height)
                {
                    AdvisorsSubMenu= false; 
                    AdvisorTimer.Stop();
                }
            }
            else
            {
                AdvisorsPanel.Height -= AdvisorsPanel.Height;
                if (AdvisorsPanel.Height == AdvisorsPanel.MinimumSize.Height)
                {
                    AdvisorsSubMenu = true;
                    AdvisorTimer.Stop();
                }
            }
        }
    }
}
