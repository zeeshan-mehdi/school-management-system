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

namespace School_Managment_System
{
    public partial class teacher_portal : MetroFramework.Forms.MetroForm
    {
        Form pre;
        List<CourseData> courses = new List<CourseData>();
        string cnic;
        public teacher_portal()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public teacher_portal(Form pre, string cnic)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.pre = pre;
            this.cnic = cnic;

            fetchTeacherInfo();
            fetchCourses();
            fillGrid();
        }
        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignGrades grades = new AssignGrades(this);
            grades.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            pre.Show();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            MarkAttendance mark = new MarkAttendance(this);
            mark.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            pre.Show();
        }

        public void fetchTeacherInfo()
        {
            string qry = "Select DISTINCT * from Teacher_ where Staff_ID = '" + cnic + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                lblName.Text ="Name :               "+ (string)reader["Name"];

                lblDesignation.Text = "Designation :                "+ (string)reader["Designation"];

                labelCNIC.Text = "CNIC :              " + (string)reader["Staff_ID"];

                lblClass.Text = "Class_ID :             "+(string)reader["Class_ID"];

            }
            SMS.connect.Close();
        }

        public void fetchCourses()
        {
            string qry = "Select * from Course where Course_ID IN(Select Course_ID from CourseClass where Class_ID =  (SELECT Distinct Class_ID FROM Teacher_ where Staff_ID = '" + cnic + "'))";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CourseData course = new CourseData();
                course.Course_ID1 = (string)reader["Course_ID"];
                course.Name1 = (string)reader["Name"];
                // course.Class_ID1 = (string)reader["Class_ID"];
                courses.Add(course);

            }

            SMS.connect.Close();
        }

        public void fillGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Course ID");
            dt.Columns.Add("CourseName");


            foreach (var item in courses)
            {
                dt.Rows.Add(new Object[] { item.Course_ID1,item.Name1});
            }

            coursesGrid.DataSource = dt;
            this.coursesGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.coursesGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void teacher_portal_Load(object sender, EventArgs e)
        {

        }

       


    }
}
