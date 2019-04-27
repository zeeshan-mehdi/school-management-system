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
    public partial class Staff_Loginform : MaterialSkin.Controls.MaterialForm
    {
        Form previousForm;
        public Staff_Loginform()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public Staff_Loginform(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Loginform_Load(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (valuesValidity()) return;
            Account_staff staff = new Account_staff(this);
            staff.Show();
            this.Hide();
        }

        private bool valuesValidity()
        {
            bool flag = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (textBox2.Text == String.Empty)
            {
                textBox2.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }
            return flag;
        }
    }
}
