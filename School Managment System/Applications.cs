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
    public partial class Applications : MetroFramework.Forms.MetroForm
    {
        Form pre;
        List<StudentData> applications;
        public Applications()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.applications = new List<StudentData>();
            fetchApplications();
            loadApplications();
        }

        private void loadApplications()
        {
            for (int i = 0; i < applications.Count; i++)
            {
                cbApplications.Items.Add(applications.ElementAt(i).Name1);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Applications_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnRejectApplication_Click(object sender, EventArgs e)
        {
            removeApplication();
        }

        public void removeApplication()
        {
            int index = cbApplications.SelectedIndex;
            StudentData student = applications.ElementAt(index);

            string qry = "DELETE from APPLICATIONS WHERE CNIC = '"+student.CNIC1+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();

            int rows = cmd.ExecuteNonQuery();

            SMS.connect.Close();
        }

        public void fetchApplications()
        {
            string qry = "Select * from APPLICATIONS";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                StudentData student = new StudentData();

                student.CNIC1 = (string)reader["CNIC"];
                student.Name1 = (string)reader["Name"];
                student.FathersName1 = (string)reader["FATHERS_NAME"];
                student.Dob1 = (string)reader["DOB"];
                student.LastDegree = (string)reader["LAST_DEGREE"];
                student.LastSchool = (string)reader["LAST_SCHOOL"];
                student.MarksObt = (string)reader["MARKS_OBT"];
                student.TotalMarks = (string)reader["TOTAL_MARKS"];
                student.Class_ = (string)reader["CLASS"];
                student.Group = (string)reader["GROUP_"];
                student.Email = (string)reader["EMAIL"];
                student.Password = (string)reader["PASSWORD"];
                student.RollNo = (string)reader["ROLL_NO"];
                student.Board = (string)reader["BOARD"];

                applications.Add(student);

            }

            SMS.connect.Close();
        }

        private void cbApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbApplications.SelectedIndex;
            StudentData student = applications.ElementAt(index);

            lblBoard.Text = student.Board;

            lblFathersName.Text = student.FathersName1;

            lblGroup.Text = student.Group;

            lblMarksObt.Text = student.MarksObt;

            lblName.Text = student.Name1;

            lblPreviousDegree.Text = student.LastDegree;

            lblPreviousSchool.Text = student.LastSchool;

            lblTargetClass.Text = student.Class_;

            lblRollNo.Text = student.RollNo;

            lblTotal.Text = student.TotalMarks;
        }

        private void btnApproveApplication_Click(object sender, EventArgs e)
        {
            addStudentToDB();
            
        }

        private void addStudentToDB(){
            try
            {
                int index = cbApplications.SelectedIndex;
                StudentData student = applications.ElementAt(index);

                string InsertQuery = "INSERT INTO Student (Student_ID,Name,St_Father_Name,Class_ID,password)VALUES('" + student.CNIC1 + "','" + student.Name1 + "','" + student.FathersName1 + "','" + student.Class_ + "','"+student.Password+"')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SMS.connect;
                cmd.CommandText = InsertQuery;
                SMS.connect.Open();
                int rows = cmd.ExecuteNonQuery();
                SMS.connect.Close();
                if (rows > 0){
                     DiaologForm dialogForm = new  DiaologForm("Student Approved Successfully");
                     dialogForm.Show();
                     removeApplication();
                    }
                   
                else{
                    DiaologForm dialogForm = new DiaologForm("Could Not Approve Student");
                    dialogForm.Show();
                }
                clearForm();
            }
            catch (Exception exception)
            {
                DiaologForm dialogForm = new DiaologForm("Something Went Wrong" + exception.ToString());
                    dialogForm.Show();
                clearForm();
            }
        }
        public void clearForm()
        {
            lblBoard.Text=lblFathersName.Text =lblGroup.Text = lblMarksObt.Text = lblName.Text = lblPreviousDegree.Text = lblPreviousSchool.Text =lblTargetClass.Text=lblRollNo.Text =lblTotal.Text ="";
        }
        

        
    }
}
