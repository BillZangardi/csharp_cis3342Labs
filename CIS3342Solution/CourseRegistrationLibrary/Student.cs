using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationLibrary
{
    public class Student
    {
        int studentId;
        string name;
        double tuitionOwed;

        public Student()
        {
            studentId = 0;
            name = "";
            tuitionOwed = 0.00;
        }

        public int StudentId
        {
            set { this.studentId = value; }
            get { return this.studentId; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public double TuitionOwed
        {
            set { this.tuitionOwed = value; }
            get { return this.tuitionOwed; }
        }

    }
}
