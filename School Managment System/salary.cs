using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Managment_System
{
    class salary
    {
        String Staff_ID;

        public String Staff_ID1
        {
            get { return Staff_ID; }
            set { Staff_ID = value; }
        }
        int Salary_amount, Bonus, tax;

        public int Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public int Bonus1
        {
            get { return Bonus; }
            set { Bonus = value; }
        }

        public int Salary_amount1
        {
            get { return Salary_amount; }
            set { Salary_amount = value; }
        }
    }
}
