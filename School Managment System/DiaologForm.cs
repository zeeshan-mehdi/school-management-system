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
    public partial class DiaologForm : MaterialSkin.Controls.MaterialForm
    {
        public DiaologForm()
        {
            InitializeComponent();
        }

        public DiaologForm(string message)
        {
            InitializeComponent();
            messageTxt.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        
    }
}
