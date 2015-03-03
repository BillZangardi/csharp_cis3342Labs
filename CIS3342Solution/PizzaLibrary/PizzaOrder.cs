using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;
using System.Data;

namespace PizzaLibrary
{
    public class PizzaOrder
    {

        public static double PizzaPrice (string size, double price, int quantity, string pizzaType)
        {
            Dictionary<string, double> pizzaSizes = new Dictionary<string, double>();
            pizzaSizes.Add("Small", 0);
            pizzaSizes.Add("Medium", 1.5);
            pizzaSizes.Add("Large", 2.25);
            pizzaSizes.Add("X-Large", 3);
            double totalCost = (price + pizzaSizes[size]) * quantity;
            UpdatePriceDB(pizzaType, quantity, totalCost);
            return totalCost;

        }

        public static void UpdatePriceDB(string pizzaType, int quantity, double totalCost)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "UPDATE Pizzas SET TotalSales = TotalSales +" + totalCost + ", TotalQuantityOrdered = TotalQuantityOrdered + " + quantity + " WHERE PizzaType LIKE '" + pizzaType + "';";
            objDB.DoUpdate(strSQL);
        }

        public static double TotalSales(string pizzaType)
        {
            double total;
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT TotalSales FROM Pizzas WHERE PizzaType LIKE '" + pizzaType + "';";
            DataSet myDS = objDB.GetDataSet(strSQL);
            total = double.Parse(myDS.Tables["Pizzas"].Rows[0]["TotalSales"].ToString());
            return total;
        }

        public static double TotalQuantityOrdered(string pizzaType)
        {
            double total;
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT TotalQuantityOrdered FROM Pizzas WHERE PizzaType LIKE '" + pizzaType + "';";
            DataSet myDS = objDB.GetDataSet(strSQL);
            total = double.Parse(myDS.Tables["Pizzas"].Rows[0]["TotalQuantityOrdered"].ToString());
            return total;
        }

    }
}
