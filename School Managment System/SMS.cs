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
    public partial class SMS : Form
    {
        string constr = "Data Source=DESKTOP-U5E9REE\\SQLEXPRESS;Initial Catalog=School_Management_System;Integrated Security=True";
        public static SqlConnection connect;
        public SMS()
        {
            InitializeComponent();
            connect = new SqlConnection(constr);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin admin = new AdminLogin();
            admin.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher_loginform teacher = new teacher_loginform();
            teacher.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_loginform student = new student_loginform();
            student.Show();
        }

        private void SMS_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Form1 registration = new Form1(this);
            this.Hide();
            registration.Show();

        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            News News = new News(this);
            this.Hide();
            News.Show();

        }

        private void btnStudentLife_Click(object sender, EventArgs e)
        {
            StudentLife st = new StudentLife();
            st.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule Schedule = new Schedule(this);
            this.Hide();
            Schedule.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            contactUs contactUs = new contactUs(this);
            this.Hide();
            contactUs.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Login adminLogin = new Login(this);
            this.Hide();
            adminLogin.Show();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            teacher_loginform teacherLogin = new teacher_loginform(this);
            this.Hide();
            teacherLogin.Show();
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            

            
            Staff_Loginform staffLogin = new Staff_Loginform(this);
            this.Hide();
            staffLogin.Show();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff_Loginform staffLogin = new Staff_Loginform(this);
            this.Hide();
            staffLogin.Show();
            
        }

        private void btnStudentPortal_Click(object sender, EventArgs e)
        {
            student_loginform studentLogin = new student_loginform(this);
            this.Hide();
            studentLogin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
