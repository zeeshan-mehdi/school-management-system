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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        List<ClassData> classes;
        Form pre;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public Form1(Form pre)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.pre = pre;
            classes = new List<ClassData>();
            fetchClasses();
            loadDataInForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCnic_Click(object sender, EventArgs e)
        {

        }

        public void loadDataInForm()
        {
            for (int i = 0; i < classes.Count; i++)
            {
                cbClasses.Items.Add(classes.ElementAt(i).Class_Name1);
            }
            cbGroup.Items.Add("Science");
            cbGroup.Items.Add("Arts");

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            pre.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (valuesValidity()) return;

            string group = "";
            if (cbGroup.SelectedIndex == 0)
            {
                group = "Science";
            }
            else
            {
                group = "Arts";
            }

            if (!txtPassword.Text.Equals(txtConfirmPass.Text))
            {
                DiaologForm dialog = new DiaologForm("Passwords Dont Match ..");
                dialog.Show();
                return;
            }

            string section = getSection(classes.ElementAt(cbClasses.SelectedIndex).Class_Name1);


            string insertQry = "INSERT INTO APPLICATIONS values ('" + CNICTxt.Text + "','" + txtName.Text + "','" + txtFatherName.Text + "','" + txtDOB.Text + "','" + txtLastDegree.Text + "','" + txtInstitution.Text + "','" + txtMarksObtained.Text + "','" + txtTotalMarks.Text + "','" + classes.ElementAt(cbClasses.SelectedIndex).Class_Name1+section + "','" + group + "','" + txtEMail.Text + "','" + txtPassword.Text + "','" + txtRollNo.Text + "','" + txtBoard.Text + "')";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = SMS.connect;
            cmd.CommandText = insertQry;
            SMS.connect.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                clearForm();
                DiaologForm dialog = new DiaologForm("Application Sent Successfully..");
                dialog.Show();
            }

            SMS.connect.Close();
        }

        public void clearForm()
        {
            txtRollNo.Text = txtBoard.Text = txtPassword.Text = txtConfirmPass.Text = txtEMail.Text = CNICTxt.Text =txtName.Text=txtFatherName.Text=txtDOB.Text =txtLastDegree.Text=txtInstitution.Text=txtMarksObtained.Text=txtTotalMarks.Text="";
            cbGroup.SelectedIndex = cbClasses.SelectedIndex =-1;
        }

        private string getSection(string class_)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = SMS.connect;
            cmd.CommandText = "SELECT COUNT(*) FROM Class where Class_ID = '"+class_+'A'+"'";
            SMS.connect.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();

            SMS.connect.Close();
            if (count < 50)
            {
                return "A";
            }
            else
            {
                cmd.Connection = SMS.connect;
                cmd.CommandText = "SELECT COUNT(*) FROM Class where Class_ID = '" + class_ + 'B' + "'";
                SMS.connect.Open();
                count = (Int32)cmd.ExecuteScalar();

                if (count < 50)
                {
                    return "B";
                }
                else
                {
                    cmd.Connection = SMS.connect;
                    cmd.CommandText = "SELECT COUNT(*) FROM Class where Class_ID = '" + class_ + 'C' + "'";
                    SMS.connect.Open();
                    count = (Int32)cmd.ExecuteScalar();

                    SMS.connect.Close();
                    if (count < 50)
                    {
                        return "C";
                    }
                    else
                    {
                        return "D";
                    }
                }
            }

            SMS.connect.Close();

        }
        private bool valuesValidity()
        {
            bool flag = false;
            if (CNICTxt.Text == String.Empty)
            {
                CNICTxt.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtName.Text == String.Empty)
            {
                txtName.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtFatherName.Text == String.Empty)
            {
                txtFatherName.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtDOB.Text == String.Empty)
            {
                txtDOB.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtLastDegree.Text == String.Empty)
            {
                txtLastDegree.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtInstitution.Text == String.Empty)
            {
                txtInstitution.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtMarksObtained.Text == String.Empty)
            {
                txtMarksObtained.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtTotalMarks.Text == String.Empty)
            {
                txtTotalMarks.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (cbClasses.SelectedItem == null)
            {
                cbClasses.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (cbGroup.SelectedItem == null)
            {
                cbGroup.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtEMail.Text == String.Empty)
            {
                txtEMail.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtPassword.Text == String.Empty)
            {
                txtPassword.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtConfirmPass.Text == String.Empty)
            {
                txtConfirmPass.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtRollNo.Text == String.Empty)
            {
                txtRollNo.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtBoard.Text == String.Empty)
            {
                txtBoard.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            return flag;
        }
    }
}
