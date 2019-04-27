using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Managment_System
{
    class GradesData
    {
        string Student_ID, marks, courseID, Total;

        public string Total1
        {
            get { return Total; }
            set { Total = value; }
        }

        public string CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        public string Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string Student_ID1
        {
            get { return Student_ID; }
            set { Student_ID = value; }
        }
    }
}
