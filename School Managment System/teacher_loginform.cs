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
    public partial class teacher_loginform : MaterialSkin.Controls.MaterialForm
    {
        Form previousForm;
        public teacher_loginform()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public teacher_loginform(Form previousForm)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.previousForm = previousForm;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (valuesValidity()) return;

                this.Hide();
                teacher_portal portal = new teacher_portal(this, txtCnic_.Text);
                portal.Show();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            
                previousForm.Show();
                this.Hide();
                this.Close();
            
            

            
        }

        private void teacher_loginform_Load(object sender, EventArgs e)
        {

        }

        private bool valuesValidity()
        {
            bool flag = false;
            if (txtCnic_.Text == String.Empty)
            {
                txtCnic_.ForeColor = Color.Red;
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
