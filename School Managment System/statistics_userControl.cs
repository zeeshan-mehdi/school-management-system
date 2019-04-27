using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Managment_System
{

    public partial class statistics_userControl : UserControl
    {
        private static statistics_userControl _instance;

        public static statistics_userControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new statistics_userControl();
                }
                return statistics_userControl._instance;
            }
        }
        public statistics_userControl()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            string InsertQuery = "select count(*) from Student";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SMS.connect;
            cmd.CommandText = InsertQuery;
            SMS.connect.Open();
            int rows = (int)cmd.ExecuteScalar();

            studentsProgress.Value = rows;

            SMS.connect.Close();
            InsertQuery = "select count(*) from Teacher_";

            cmd.Connection = SMS.connect;
            cmd.CommandText = InsertQuery;
            SMS.connect.Open();
            rows = (int)cmd.ExecuteScalar();

            teachersProgress.Value = rows;

           

            SMS.connect.Close();
        }
    }
}
