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
    public partial class AssignGrades :MetroFramework.Forms.MetroForm
    {
        List<RegisteredStudentData> students;
        List<ClassData> classes;
        List<CourseData> courses;
       

        Form pre;
        public AssignGrades()
        {
            InitializeComponent();
        }
        public AssignGrades(Form pre)
        {
            InitializeComponent();
            this.pre = pre;
            students = new List<RegisteredStudentData>();
            classes = new List<ClassData>();
            courses = new List<CourseData>();

            fetchClasses();
            fetchStudents();
            loadStudentsComboBox();
        }

        private void btnAssignGrade_Click(object sender, EventArgs e)
        {
            string marksObt = txtMarksObt.Text;
            string totalMarks = txtTotalMarks.Text;

            string stId = students.ElementAt(cbSelectedStudent.SelectedIndex).Student_ID1;
            string courseId = courses.ElementAt(cbSelectedCourse.SelectedIndex).Course_ID1;



            assignGradesToStudent(stId,courseId,marksObt,totalMarks);
        }

        public bool isGradeAlreadyAssigned(string stId,string courseId){
            string query = "select * from Student_Grades where Student_ID ='"+stId+"' and Course_ID = '"+courseId+"'";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = query;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader() ;
            if (reader.Read())
            {
                SMS.connect.Close();
                return true;
            }
            else
            {
                SMS.connect.Close();
                return false;
            }
        }

        private void assignGradesToStudent(string stId, string courseId,string marksObt,string totalMarks)
        {
            if (valuesValidity()) return;

            if (isGradeAlreadyAssigned(stId, courseId))
            {
                DiaologForm form = new DiaologForm("This Course is Already Assigned Marks ..");
                form.Show();
                return;
            }

            string query = "INSERT INTO Student_Grades values ('" + stId + "','" + marksObt + "','" + courseId + "','" + totalMarks + "')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = query;
            SMS.connect.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                DiaologForm dilog = new DiaologForm("Marks Successfully Assigned");
                dilog.Show();
                clearForm();
            }
            else
            {
                DiaologForm dilog = new DiaologForm("Could not assign marks..");
                dilog.Show();

            }
            SMS.connect.Close();
        }

        public void clearForm()
        {
            cbSelectedCourse.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            pre.Show();
        }

        public void fetchStudents()
        {
            string qry = "Select * from Student";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RegisteredStudentData student = new RegisteredStudentData();

                student.Student_ID1 = (string)reader["Student_ID"];
                student.Name1 = (string)reader["Name"];
                student.St_Father_Name1 = (string)reader["St_Father_Name"];
                student.Class_ID1 = (string)reader["Class_ID"];
                //student.Reg_ID1 = (string)reader["Reg_ID"];

                students.Add(student);

            }

            SMS.connect.Close();
        }

        public void fetchClasses()
        {
            string qry = "Select * from Class";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ClassData class_ = new ClassData();

                class_.Class_ID1 = (string)reader["Class_ID"];
                class_.Class_Name1 = (string)reader["Class_Name"];
                //class_.Courses1 = (string)reader["Courses"];
                class_.Section1 = (string)reader["Section"];
                class_.C_Group1 = (string)reader["C_Group"];

                classes.Add(class_);

            }

            SMS.connect.Close();
        }

        public void fetchCourses_(string class_id)
        {
            string qry = "Select distinct * from CourseClass where Class_ID = '"+class_id+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> courses_ = new List<string>();

            while (reader.Read())
            {
               // ClassData class_ = new ClassData();

                string courseId = (string)reader["Course_ID"];
                //class_.Class_Name1 = (string)reader["Class_ID"];
               // classes.Add(class_);
                courses_.Add(courseId);
                

            }

            SMS.connect.Close();
            courses = new List<CourseData>();

            for(int i=0;i<courses_.Count;i++){
                fetchCourses(courses_.ElementAt(i));
            }

            loadComboBoxes();
        }

        public void fetchCourses(string courseId)
        {
            string qry = "Select * from Course where Course_ID ='"+courseId+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            if (SMS.connect != null && SMS.connect.State == ConnectionState.Closed)
            {
                SMS.connect.Open();
            }
            
            SqlDataReader reader= cmd.ExecuteReader();

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

        public void loadStudentsComboBox(){
            for (int i = 0; i < students.Count; i++)
            {
                cbSelectedStudent.Items.Add(students.ElementAt(i).Name1);
            }
        }

        public void loadComboBoxes()
        {
            cbSelectedCourse.Items.Clear();

            for (int i = 0; i < courses.Count; i++)
            {
                cbSelectedCourse.Items.Add(courses.ElementAt(i).Name1);
            }
        }

        private void cbSelectedStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSelectedStudent.SelectedIndex;

            RegisteredStudentData student = students.ElementAt(index);
            string courseId = student.Class_ID1;
                 
            fetchCourses_(courseId);

        }
        private bool valuesValidity()
        {
            bool flag = false;
            if (cbSelectedStudent.SelectedIndex == -1)
            {
                cbSelectedStudent.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (cbSelectedCourse.SelectedIndex == -1)
            {
                cbSelectedCourse.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }

            if (txtMarksObt.Text == String.Empty)
            {
                txtMarksObt.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }

            if (txtTotalMarks.Text == String.Empty)
            {
                txtTotalMarks.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }
            return flag;
        }

    }
}
