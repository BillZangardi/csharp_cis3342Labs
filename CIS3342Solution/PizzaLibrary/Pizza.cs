using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaLibrary
{
    public class Pizza
    {
        int quantity;
        double price;
        string pizzaType;
        string size;
        double totalCost;

        public Pizza()
        {
            quantity = 0;
            price = 0.00;
            pizzaType = "";
            size = "";
            totalCost = 0.00;
        }

        public int Quantity
        {
            set { this.quantity = value; }
            get { return this.quantity; } 
        }

        public double Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public string PizzaType
        {
            set { this.pizzaType = value; }
            get { return this.pizzaType; }
        }

        public string Size
        {
            set { this.size = value; }
            get { return this.size; }
        }

        public double TotalCost
        {
            set { this.totalCost = value; }
            get { return this.totalCost; }
        }
    }
}
