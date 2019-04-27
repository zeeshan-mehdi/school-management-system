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
    public partial class AddCourses : MetroFramework.Forms.MetroForm
    {

        Form previousForm;
        public AddCourses()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (valuesValidity()) return;
                string InsertQuery = "INSERT INTO Course(Course_ID,Name) VALUES('" + txtCourseId.Text + "','" + txtCourseName.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SMS.connect;
                cmd.CommandText = InsertQuery;
                SMS.connect.Open();
                int rows = cmd.ExecuteNonQuery();
                SMS.connect.Close();
                if (rows > 0)
                {
                    DiaologForm dialog = new DiaologForm("Course Added Succcessfully");
                    dialog.Show();
                }

                else
                {
                    DiaologForm dialog = new DiaologForm("Something Went Wrong");
                    dialog.Show();
                }
                clearForm();
            }
            catch (Exception exception)
            {
                courseAdded.Text = "Error While Adding Course " +exception.Data;
                clearForm();
            }

        }
        public void clearForm()
        {
            txtCourseName.Text = "";
            txtCourseId.Text = "";
        }

        private void AddCourses_Load(object sender, EventArgs e)
        {

        }
        private bool valuesValidity()
        {
            bool flag = false;
            if (txtCourseId.Text == String.Empty)
            {
                txtCourseId.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtCourseName.Text == String.Empty)
            {
                txtCourseName.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            return flag;
        }
    }
}
