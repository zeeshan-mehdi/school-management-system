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
    public partial class student_loginform : MaterialSkin.Controls.MaterialForm
    {
        Form previousForm;
        public static string cnic;
        public student_loginform()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        public student_loginform(Form previousForm)
        {
            InitializeComponent();

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            this.previousForm = previousForm;
            
        }

        private void student_loginform_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            //cnic = txtCNIC_.Text;
            //string password = txtPassword.Text;


            //this.Hide();
            //Student_portal portal = new Student_portal(this);
            //portal.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            previousForm.Show();
           
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            if (valuesValidity()) return;

            if (verifyStudent(txtCNIC_.Text, txtPassword.Text))
            {
                this.Hide();
                Student_portal portal = new Student_portal(this, txtCNIC_.Text);
                portal.Show();
            }
            else
            {
                DiaologForm dialog = new DiaologForm("User does not exist with these credentials");
                dialog.Show();
            }

        
        }

        public bool verifyStudent(string cnic,string password){
            string qry = "Select * from Student where Student_ID = '"+cnic+"' and password = '"+password+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            previousForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool valuesValidity()
        {
            bool flag = false;
            if (txtCNIC_.Text == String.Empty)
            {
                txtCNIC_.ForeColor = Color.Red;
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

            return flag;

        }
    }
}
