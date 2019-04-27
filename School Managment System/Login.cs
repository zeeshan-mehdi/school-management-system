using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        Form previousForm;
        public Login()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public Login(Form previousForm)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.previousForm = previousForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valuesValidity()) return;

            if (txtUser.Text.Equals("admin") && txtPass.Text.Equals("admin"))
            {
                this.Hide();
                //AdminDashboard adminDashboard = new AdminDashboard(this);
                //adminDashboard.Show();
                new Admin(this).Show();
            }
            else
            {
                DiaologForm form = new DiaologForm("User Email or Password Not correct");
                form.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private bool valuesValidity()
        {
            bool flag = false;
            if (txtUser.Text == String.Empty)
            {
                txtUser.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtPass.Text == String.Empty)
            {
                txtPass.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            return flag;
        }
    }
}
