using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        Form previousForm;
        public AdminDashboard()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public AdminDashboard(Form previousForm)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.previousForm = previousForm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourses addCourses = new AddCourses();
            addCourses.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterCourse addClass = new RegisterCourse();
            addClass.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher teacher = new AddTeacher();
            teacher.Show();
            this.Hide();
        }
    }
}
