using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class Collect_fee : MaterialSkin.Controls.MaterialForm
    {
        List<ClassData> classes;
        List<RegisteredStudentData> students;
        public Collect_fee()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.classes = new List<ClassData>();
            this.students = new List<RegisteredStudentData>();
            fetchClasses();
            fetchStudents();
            loadDataInForm();
        }


        private void Collect_fee_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Account_staff ac = new Account_staff(this);
            ac.Show();
            this.Hide();
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

                students.Add(student);

            }

            SMS.connect.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (valuesValidity()) return;

            string InsertQuery = "INSERT INTO Fees(Student_ID,Amount,F_Status) VALUES('" + students.ElementAt(txtStudent.SelectedIndex).Student_ID1 + "','" + txtAmount2.Text + "','" + txtstatus.Text + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = InsertQuery;
            SMS.connect.Open();
            int rows = cmd.ExecuteNonQuery();

            SMS.connect.Close();

            //fees f = new fees();
            //f.F_Status1 = txtstatus.Text;
            //f.Student_ID1 = students.ElementAt(txtStudent.SelectedIndex).Student_ID1;
            //f.Amount1 = int.Parse(txtamount.Text);
            //f.remaining_amount1 = int.Parse(txtremainingamount.Text);
            //f.Class_id = cbclass.SelectedIndex;


            clearForm();

            
        }
        public void loadDataInForm()
        {
            for (int i = 0; i < classes.Count; i++)
            {
                cbclass.Items.Add(classes.ElementAt(i).Class_ID1);
            }

            for (int i = 0; i < students.Count; i++)
            {
                txtStudent.Items.Add(students.ElementAt(i).Student_ID1 + " "+students.ElementAt(i).Name1);
            }
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
                ClassData class1 = new ClassData();
                class1.Class_ID1 = (string)reader["Class_ID"];
                class1.Class_Name1 = (string)reader["Class_Name"];
                class1.Section1 = (string)reader["Section"];
                class1.C_Group1 = (string)reader["C_Group"];
                // course.Class_ID1 = (string)reader["Class_ID"];
                classes.Add(class1);

            }

            SMS.connect.Close();
        }


        void clearForm()
        {
            txtStudent.SelectedIndex = -1;
            txtamount.Text = "";
            txtstatus.Text = "";
            txtremainingamount.Text = "";
            cbclass.SelectedIndex = 0;
        }

        bool  valuesValidity()
        {
            bool flag = false;
            if (txtStudent.SelectedIndex == -1)
            {
                txtStudent.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;

            }

            if (txtAmount2.Text ==String.Empty)
            {
                txtamount.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }

            if (txtstatus.Text == String.Empty)
            {
                txtamount.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }

            if (txtremainingamount.Text == String.Empty)
            {
                txtamount.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }

            if (cbclass.SelectedIndex == 0)
            {
                txtamount.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show(); flag = true;
            }
            return flag;

        }

        private void cbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string InsertQuery = "SELECT Class_ID FROM Class";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = SMS.connect;
            //cmd.CommandText = InsertQuery;
            //SMS.connect.Open();
            //int rows = cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //cbclass.DataSource = ds;
            //cbclass.ValueMember = "Class_ID";
            //cbclass.Enabled = true;
            //SMS.connect.Close();

        }
    }
}
