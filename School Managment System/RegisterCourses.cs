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
    public partial class RegisterCourse : MetroFramework.Forms.MetroForm
    {
        List<CourseData> courses;
        List<CourseData> selectedCourses;
        Form previousForm;
        public RegisterCourse()
        {
            InitializeComponent();
            courses = new List<CourseData>();
            selectedCourses = new List<CourseData>();
            fetchCourses();
            loadCourses();
        }

        private void RegisterCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
            this.Close();
        }

        public void loadCourses()
        {
            for (int i = 0; i < courses.Count;i++ )
            {
                CourseData item = courses.ElementAt(i);
                cbCourses.Items.Add(item.Course_ID1+ " "+item.Name1);
            }
        }

        public void fetchCourses()
        {
            string qry = "Select * from Course";
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

        private void button1_Click(object sender, EventArgs e)
        {
            selectedCourses.Add(courses.ElementAt(cbCourses.SelectedIndex));
            cbCourses.SelectedIndex = 0;
            fillGrid();
        }

        public void fillGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Course ID");
            dt.Columns.Add("CourseName");

            foreach(var item in selectedCourses){
                dt.Rows.Add(new Object[]{item.Course_ID1,item.Name1});
            }

            selectedCoursesGrid.DataSource = dt;

            this.selectedCoursesGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.selectedCoursesGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnCreatCkass_Click(object sender, EventArgs e)
        {

            if (valuesValidity()) return;
                connectCoursesWithClasses(txtClassName.Text + txtSection.Text);
                string classId = txtClassName.Text + txtSection.Text;

                string query = "INSERT INTO Class(Class_ID,Class_Name,Section,C_Group) values ('" + classId + "','" + txtClassName.Text + "','" + txtSection.Text + "','" + txtGroup.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SMS.connect;
                cmd.CommandText = query;
                SMS.connect.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    lblStatus.Text = "Class Successfully Created";
                    clearForm();
                }
                else
                {
                    lblStatus.Text = "Class Could not be Created";

                }
                SMS.connect.Close();
            

        }
        public void clearForm()
        {
            txtClassName.Text = txtGroup.Text = txtSection.Text = " ";
        }

        public void connectCoursesWithClasses(string classId)
        {

            foreach(var element in selectedCourses){
                 string courseId = element.Course_ID1;

                 string insertQry = "INSERT INTO CourseClass(Course_ID,Class_ID) values ('" + courseId + "','" +classId + "')";
                 SqlCommand cmd = new SqlCommand(); 
                 cmd.Connection = SMS.connect;
                 cmd.CommandText = insertQry;
                 SMS.connect.Open();
                 int rows = cmd.ExecuteNonQuery();
                 SMS.connect.Close();
            }
        }

        private bool valuesValidity()
        {
            bool flag = false;
            if (txtClassName.Text == String.Empty)
            {
                txtClassName.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtSection.Text == String.Empty)
            {
                txtSection.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtGroup.Text == String.Empty)
            {
                txtGroup.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            return flag;

        }


    }
}
