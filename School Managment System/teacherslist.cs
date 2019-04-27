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
    public partial class teacherslist : MetroFramework.Forms.MetroForm
    {
        List<RegisteredStudentData> students = new List<RegisteredStudentData>();
        public teacherslist()
        {
            InitializeComponent();
            fetchStudentInfo();
            fillGrid();
        }

        public void fetchStudentInfo()
        {
            string qry = "Select DISTINCT * from Teacher_ ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RegisteredStudentData student = new RegisteredStudentData();


                student.Name1 = (string)reader["Name"];

                student.Class_ID1 = (string)reader["Class_ID"];

                students.Add(student);

            }
            SMS.connect.Close();
        }

        public void fillGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Class");

            foreach (var item in students)
            {
                dt.Rows.Add(new Object[] { item.Name1, item.Class_ID1 });
            }

            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }


}
