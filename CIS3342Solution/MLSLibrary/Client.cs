using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLSLibrary
{
    public class Client
    {
        string name;
        string phone;

        public Client()
        {
            name = "";
            phone = "";
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Phone
        {
            set { this.phone = value; }
            get { return this.phone; }
        }


    }
}