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
    public partial class Inventry : MaterialSkin.Controls.MaterialForm
    {
        public Inventry()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Inventry_Load(object sender, EventArgs e)
        {

        }

        private void valuesValidity()
        {
            if (textBox1.Text == String.Empty)
            {
                textBox1.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
            }

            if (textBox3.Text == String.Empty)
            {
                textBox3.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
            }


            if (textBox2.Text == String.Empty)
            {
                textBox2.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
            }


            if (numericUpDown1.Value == null)
            {
                numericUpDown1.ForeColor = Color.Red;
                DiaologForm dialog = new DiaologForm("this field is madatory,please fill all the fields");
                dialog.Show();
            }
        }
    }
}
