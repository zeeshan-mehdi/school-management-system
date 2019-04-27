using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Managment_System
{
    class AttendanceData
    {
        string name, attendance, st_id;

        public string St_id
        {
            get { return st_id; }
            set { st_id = value; }
        }

        public string Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
