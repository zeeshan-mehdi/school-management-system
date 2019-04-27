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
    public partial class AddTeacher : MetroFramework.Forms.MetroForm
    {
        List<ClassData> classes;
        Form form;
        public AddTeacher()
        {
            InitializeComponent();
            classes = new List<ClassData>();
            fetchClasses();
            loadCourses();

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            insertTeacher();
        }

        public void insertTeacher()
        {
            if (valuesValidity()) return;

            string classId = classes.ElementAt(txtTeacherClass.SelectedIndex).Class_ID1;
            string qry = "INSERT INTO Teacher_ values ('" + txtTeacherCNIC.Text + "','" + txtTeacherName.Text + "','" + txtTeacherDesignation.Text + "','" + classId + "','" + DateTime.Now.ToString("M/d/yyyy") + "','"+txtTeacherPassword.Text+"')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            int rows = cmd.ExecuteNonQuery();
            SMS.connect.Close();
            if (rows > 0)
            {
                DiaologForm dialog = new DiaologForm("Teacher Added Successfully .. ");
                dialog.Show();
            }
            else { 
                DiaologForm dialog = new DiaologForm("Teacher Could not be added.. ");
                dialog.Show();
            }
            clearForm();
        }

        private void clearForm()
        {
            txtTeacherCNIC.Text = txtTeacherName.Text = txtTeacherDesignation.Text = txtTeacherPassword.Text= "";
            txtTeacherClass.SelectedIndex = -1; 
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
                ClassData course = new ClassData();
                course.Class_ID1 = (string)reader["Class_ID"];
                course.Class_Name1 = (string)reader["Class_Name"];
                // course.Class_ID1 = (string)reader["Class_ID"];
                 classes.Add(course);

            }

            SMS.connect.Close();
        }

        public void loadCourses()
        {
            for (int i = 0; i < classes.Count; i++)
            {
                ClassData item = classes.ElementAt(i);
                txtTeacherClass.Items.Add(item.Class_ID1);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private bool  valuesValidity()
        {
            bool flag = false;
            if (txtTeacherCNIC.Text == String.Empty)
            {
                txtTeacherCNIC.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtTeacherName.Text == String.Empty)
            {
                txtTeacherName.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtTeacherDesignation.Text == String.Empty)
            {
                txtTeacherDesignation.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            if (txtTeacherPassword.Text == String.Empty)
            {
                txtTeacherPassword.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            if (txtTeacherClass.SelectedIndex == 0)
            {
                txtTeacherClass.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }
            return flag;

        }
    }
}
