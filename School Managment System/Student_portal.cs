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
    public partial class Student_portal :MetroFramework.Forms.MetroForm
    {
        Form pre;
        List<CourseData> courses = new List<CourseData>();
        List<GradesData> grades = new List<GradesData>();
        string cnic;

        public Student_portal(Form sMS,string cnic)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.pre = sMS;
            this.cnic = cnic;
            fetchStudentInfo();
            fetchCourses();
            fetchGrades();
            fillGrid();
            
        }

        public Student_portal()
        {
        }

        public void fetchStudentInfo()
        {
            string qry = "Select DISTINCT * from Student where Student_ID = '" +cnic + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RegisteredStudentData student = new RegisteredStudentData();

                student.Name1 = (string)reader["Name"];

                lblStudentName.Text = student.Name1;

                student.Class_ID1 = (string)reader["Class_ID"];
                lblEnrolledIn.Text = student.Class_ID1;

                lblStudentEmail.Text = cnic;

            }
            SMS.connect.Close();
        }

        private void Student_portal_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider3_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            pre.Show();
            this.Close();
        }


        private void btnContactTeacher_Click(object sender, EventArgs e)
        {

        }

        public void fetchCourses()
        {
            string qry = "Select * from Course where Course_ID IN(Select Course_ID from CourseClass where Class_ID =  (SELECT Distinct Class_ID FROM Student where Student_ID = '"+cnic+"'))";
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

        public void fetchGrades()
        {
            string qry = "Select distinct * from Student_Grades where Student_ID = '" + cnic + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                GradesData grade = new GradesData();
                grade.Student_ID1 = (string)reader["Student_ID"];
                grade.CourseID = (string)reader["Course_ID"];
                grade.Marks = (string)reader["Marks"];
                grade.Total1 = ((Int32)reader["Total"]).ToString();
                // course.Class_ID1 = (string)reader["Class_ID"];
                grades.Add(grade);

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
                dt.Rows.Add(new Object[] { item.Course_ID1, item.Name1 });
            }

            coursesGrid.DataSource = dt;
            this.coursesGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.coursesGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Student ID");
            dt1.Columns.Add("Course ID");
            dt1.Columns.Add("Marks");
            dt1.Columns.Add("Total");

            foreach (var item in grades)
            {
                dt1.Rows.Add(new Object[] { item.Student_ID1, item.CourseID,item.Marks,item.Total1 });
            }

            gradesGrid.DataSource = dt1;
            this.gradesGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gradesGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gradesGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gradesGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

      
    }
}
