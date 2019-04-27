using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Managment_System
{
    class StudentData
    {
        string CNIC, Name, FathersName, Dob, lastDegree, lastSchool, marksObt, totalMarks, class_, group, email, password, rollNo, board;

        public string Board
        {
            get { return board; }
            set { board = value; }
        }

        public string RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public string Class_
        {
            get { return class_; }
            set { class_ = value; }
        }

        public string TotalMarks
        {
            get { return totalMarks; }
            set { totalMarks = value; }
        }

        public string MarksObt
        {
            get { return marksObt; }
            set { marksObt = value; }
        }

        public string LastSchool
        {
            get { return lastSchool; }
            set { lastSchool = value; }
        }

        public string LastDegree
        {
            get { return lastDegree; }
            set { lastDegree = value; }
        }

        public string Dob1
        {
            get { return Dob; }
            set { Dob = value; }
        }

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }

        public string FathersName1
        {
            get { return FathersName; }
            set { FathersName = value; }
        }

        public string CNIC1
        {
            get { return CNIC; }
            set { CNIC = value; }
        }

    }
}
