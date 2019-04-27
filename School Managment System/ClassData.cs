using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Managment_System
{
    class ClassData
    {
        string Class_ID, Class_Name, C_Group, Courses, Section;

        public string Section1
        {
            get { return Section; }
            set { Section = value; }
        }

        public string Courses1
        {
            get { return Courses; }
            set { Courses = value; }
        }

        public string C_Group1
        {
            get { return C_Group; }
            set { C_Group = value; }
        }

        public string Class_Name1
        {
            get { return Class_Name; }
            set { Class_Name = value; }
        }

        public string Class_ID1
        {
            get { return Class_ID; }
            set { Class_ID = value; }
        }
    }
}
