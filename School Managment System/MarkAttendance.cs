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
    public partial class MarkAttendance : MetroFramework.Forms.MetroForm
    {
        Form pre;
        List<AttendanceData> students;
        List<RegisteredStudentData> studentsList;
        public MarkAttendance(Form pre)
        {
            InitializeComponent();

            
            this.pre = pre;
            this.studentsList = new List<RegisteredStudentData>();
            this.students = new List<AttendanceData>();
            fetchStudents();
            loadDataInList();
        }

        private void loadDataInList()
        {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");

                dt.Columns.Add("Attendance");

                foreach (var item in studentsList)
                {
                    dt.Rows.Add(new Object[] { item.Name1, "attendance"});

                    AttendanceData att = new AttendanceData();
                    att.Name = item.Name1;
                    att.Attendance = "present";
                    students.Add(att);
                }
               
               attendanceGrid.DataSource = dt;

               this.attendanceGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               this.attendanceGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               Action<DataGridViewRow> enterEditMode = row =>
               {
                  // var cellName = (DataGridViewTextBoxCell)row.Cells[1];
                   var attendance2 = (DataGridViewComboBoxCell)row.Cells[2];
                   //cellName.ReadOnly = false;
                   attendance2.ReadOnly = false;
                  // cellCity.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                   attendanceGrid.CurrentCell =attendance2;
                   attendanceGrid.BeginEdit(true);
                  // cellAction.Value = "Save";
               };

           
           // studentsList.EndUpdate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            pre.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            markAttendance();
            this.Hide();
            pre.Show();
            this.Close();
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

                studentsList.Add(student);

            }

            SMS.connect.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            DataGridViewCell cb = (DataGridViewCell)attendanceGrid.Rows[e.RowIndex].Cells[1];
            if (cb.Value != null)
            {
                // do stuff
                attendanceGrid.Invalidate();
                var index = e.RowIndex;

                students.ElementAt(index).Attendance = cb.Value.ToString();
                students.ElementAt(index).St_id = studentsList.ElementAt(index).Student_ID1;

            }

        }

        public bool checkAttendanceStatus()
        {
            string query = "select * from STUDENT_ATTENDANCE_ where Date_ = '" + DateTime.Now.ToString("d/M/yyyy") + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = query;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                DiaologForm form = new DiaologForm("Todays Attendance Already Marked You cannot Mark Again !!");
                form.Show();
                SMS.connect.Close();
                return false;
            }
            SMS.connect.Close();
            return true;

        }


        public void markAttendance()
        {
            if (!checkAttendanceStatus()) return;

            bool attFlag =false;

            foreach (var item in students)
            {

                string query = "INSERT INTO STUDENT_ATTENDANCE_ values ('" + DateTime.Now.ToString("d/M/yyyy") +"','" + item.St_id + "','" +item.Attendance + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SMS.connect;
                cmd.CommandText = query;
                SMS.connect.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    attFlag = true;
                    DiaologForm dilog = new DiaologForm("Attendance Marked Successfully");
                    dilog.Show();
                }
                else
                {
                    DiaologForm dilog = new DiaologForm("Could not  mark attendance..");
                    dilog.Show();

                }
                SMS.connect.Close();
            }

            if (attFlag)
            {
                DiaologForm dilog = new DiaologForm("Attendance Marked Successfully");
                dilog.Show();
            }
            else
            {
                DiaologForm dilog = new DiaologForm("Could not  mark attendance..");
                dilog.Show();

            }
        }

        
    }
}
