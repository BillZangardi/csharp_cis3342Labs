using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationLibrary
{
    public class Course
    {
        string crn;
        string courseTitle;
        string departmentId;
        string section;
        string professor;
        string dayCode;
        string timeCode;
        double creditHours;
        int numSeatsAvail;
        int maxSeats;
        

        public Course()
        {
            crn = "";
            courseTitle = "";
            departmentId = "";
            section = "";
            professor = "";
            dayCode = "";
            timeCode = "";
            creditHours = 0.00;
            numSeatsAvail = 0;
            maxSeats = 0;
        }

        public string Crn
        {
            set { this.crn = value; }
            get { return this.crn; }
        }

        public string CourseTitle
        {
            set { this.courseTitle = value; }
            get { return this.courseTitle; }
        }

        public string DepartmentId
        {
            set { this.departmentId = value; }
            get { return this.departmentId; }
        }

        public string Section
        {
            set { this.section = value; }
            get { return this.section; }
        }

        public string Professor
        {
            set { this.professor = value; }
            get { return this.professor; }
        }

        public string DayCode
        {
            set { this.dayCode = value; }
            get { return this.dayCode; }
        }

        public string TimeCode
        {
            set { this.timeCode = value; }
            get { return this.timeCode; }
        }

        public double CreditHours
        {
            set { this.creditHours = value; }
            get { return this.creditHours; }
        }

        public int NumSeatsAvail
        {
            set { this.numSeatsAvail = value; }
            get { return this.numSeatsAvail; }
        }

        public int MaxSeats
        {
            set { this.maxSeats = value; }
            get { return this.maxSeats; }
        }

    }
}
