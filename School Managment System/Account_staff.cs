using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Account_staff : MetroFramework.Forms.MetroForm
    {
        Form pre;
        public Account_staff(Form pre)
        {
            InitializeComponent();
            this.pre = pre;
            
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Collect_fee cf = new Collect_fee();
            this.Hide();
            cf.Show();
            this.Close();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SMS sms = new SMS();
            sms.Show();
            this.Close();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Release_Salaries rs = new Release_Salaries();
            rs.Show();
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses ex = new Expenses();
            ex.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "Select * from Account_Staff";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = qry;
            SMS.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
            }

            SMS.connect.Close();
        }

        private void Account_staff_Load(object sender, EventArgs e)
        {

        }
    }
}
