using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    
    public partial class Admin_dsh_usercontrol : UserControl
    {
        private static Admin_dsh_usercontrol _instance;

        public static Admin_dsh_usercontrol Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Admin_dsh_usercontrol();
                }
                return Admin_dsh_usercontrol._instance; 
            }
        }

        public Admin_dsh_usercontrol()
        {
            InitializeComponent();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            RegisterCourse addClass = new RegisterCourse();
            addClass.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AddTeacher teacher = new AddTeacher();
            teacher.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Applications application = new Applications();
            application.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            AddCourses addCourses = new AddCourses();
            addCourses.Show();
        }

        private void btnStudentsList_Click(object sender, EventArgs e)
        {
            studentslist list = new studentslist();
            list.Show();
        }

        private void btnTeachersList_Click(object sender, EventArgs e)
        {
            teacherslist list = new teacherslist();
            list.Show();
        }     


    }
}
