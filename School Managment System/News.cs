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
    public partial class News : MaterialSkin.Controls.MaterialForm
    {
        SMS pre;   

        public News(SMS sMS)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.pre = sMS;
        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void News_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            pre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFootball football = new ReadFootball();
            football.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadAffiliation aff = new ReadAffiliation();
            aff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadMusic music = new ReadMusic();

            music.Show();
        }
    }
}
