using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        Form pre;
        public Admin(Form pre)
        {
            InitializeComponent();
            this.pre = pre;
            if (!panel2.Controls.Contains(Admin_dsh_usercontrol.Instance))
            {
                panel2.Controls.Add(Admin_dsh_usercontrol.Instance);
                Admin_dsh_usercontrol.Instance.Dock = DockStyle.Fill;
                Admin_dsh_usercontrol.Instance.BringToFront();
            }
            else
            {
                Admin_dsh_usercontrol.Instance.BringToFront();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Admin_dsh_usercontrol.Instance))
            {
                panel2.Controls.Add(Admin_dsh_usercontrol.Instance);
                Admin_dsh_usercontrol.Instance.Dock = DockStyle.Fill;
                Admin_dsh_usercontrol.Instance.BringToFront();
            }
            else
            {
                Admin_dsh_usercontrol.Instance.BringToFront();
            }
           
            //new Admin_dsh_usercontrol().BringToFront();
            //new statistics_userControl().SendToBack();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(statistics_userControl.Instance))
            {
                panel2.Controls.Add(statistics_userControl.Instance);
                statistics_userControl.Instance.Dock = DockStyle.Fill;
                statistics_userControl.Instance.BringToFront();
            }
            else
            {
                statistics_userControl.Instance.BringToFront();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            pre.Show();
        }
    }
}
