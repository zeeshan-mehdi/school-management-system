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
    public partial class Release_Salaries : MaterialSkin.Controls.MaterialForm
    {
        public Release_Salaries()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void Release_Salaries_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Account_staff ac = new Account_staff(this);
            this.Hide();
            ac.Show();
            this.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (valuesValidity()) return;

            string InsertQuery = "INSERT INTO Salary(Staff_ID,Salary_amount,Bonus,tax) VALUES('" + txtstaffid.Text + "','" + txtsalary.Text + "','" + txtbonus.Text + "','" + txttax.Text + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = InsertQuery;
            SMS.connect.Open();
            int rows = cmd.ExecuteNonQuery();

            SMS.connect.Close();

            salary s = new salary();
            s.Staff_ID1= txtstaffid.Text;
            s.Salary_amount1 = int.Parse(txtsalary.Text);
            s.Bonus1 = int.Parse(txtbonus.Text);
            s.Tax = int.Parse(txttax.Text);


            clearForm();

           
        }

        void clearForm()
        {
            txtstaffid.Text = "";
            txtsalary.Text = "";
            txtbonus.Text = "";
            txttax.Text = "";
        }

        bool valuesValidity()
        {
            bool flag = false;

            if (txtstaffid.Text == String.Empty)
            {
                txtstaffid.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtsalary.Text == String.Empty)
            {
                txtsalary.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txtbonus.Text == String.Empty)
            {
                txtbonus.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            if (txttax.Text == String.Empty)
            {
                txttax.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
                flag = true;
            }

            return flag;
        }
    }
}
