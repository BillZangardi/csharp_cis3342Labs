using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3WS
{
    public class Realtor
    {
        string name;
        string company;
        string phone;

        public Realtor()
        {
            name = "";
            company = "";
            phone = "";
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Company
        {
            set { this.company = value; }
            get { return this.company; }
        }

        public string Phone
        {
            set { this.phone = value; }
            get { return this.phone; }
        }

    }
}