using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3WS
{
    public class Home
    {
        string address;
        string city;
        string state;
        double listPrice;
        double squareFeet;
        string availability;
        int bedrooms;
        double baths;


        public Home()
        {
            address = "";
            city = "";
            state = "";
            listPrice = 0.0;
            squareFeet = 0.0;
            availability = "";
            bedrooms =0;
            baths = 0.0;
        }

        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string State
        {
            set { this.state = value; }
            get { return this.state; }
        }

        public double ListPrice
        {
            set { this.listPrice = value; }
            get { return this.listPrice; }
        }

        public double SquareFeet
        {
            set { this.squareFeet = value; }
            get { return this.squareFeet; }
        }

        public string Availability
        {
            set { this.availability = value; }
            get { return this.availability; }
        }

        public int Bedrooms
        {
            set { this.bedrooms = value; }
            get { return this.bedrooms; }
        }

        public double Baths
        {
            set { this.baths = value; }
            get { return this.baths; }
        }
    }
}