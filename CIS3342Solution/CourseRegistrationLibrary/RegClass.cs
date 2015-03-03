using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationLibrary
{
    public class RegClass
    {
        string crn;
        double credits;

        public RegClass()
        {
            crn = "";
            credits = 0.00;
        }


        public string Crn
        {
            set { this.crn = value; }
            get { return this.crn; }
        }

        public double Credits
        {
            set { this.credits = value; }
            get { return this.credits; }
        }
    }
}
