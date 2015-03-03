using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;
using PizzaLibrary;
using System.Drawing; 


namespace Project1
{
    public partial class MyPizzaShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * FROM Pizzas";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvPizzas.DataSource = myDS;
                gvPizzas.DataBind();
            }

        }

        protected void gvPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            bool orderGood = true;
            string str = "";
            string name = txtName.Text;
            if (name == "")
            {
                orderGood = false;
                str += "Add your Name; ";
            }
            string address = txtAddress.Text;
            if (address == "")
            {
                orderGood = false;
                str += "Add your Address; ";
            }
            string phone = txtPhone.Text;
            if (phone == "")
            {
                orderGood = false;
                str += "Add your phone; ";
            }
            string delivery = dropDelivery.SelectedItem.Text;
            
            ArrayList arrOrder = new ArrayList();
            int count = 0;

            for (int row = 0; row < gvPizzas.Rows.Count; row++)
            {
                CheckBox CBox;
                CBox = (CheckBox)gvPizzas.Rows[row].FindControl("chkSelect");

                if (CBox.Checked)
                {

                    string pizzaType = gvPizzas.Rows[row].Cells[1].Text;
                    double price;
                    double.TryParse(gvPizzas.Rows[row].Cells[2].Text, out price);

                    TextBox TBox;
                    TBox = (TextBox)gvPizzas.Rows[row].FindControl("txtQuantity");
                    int quantity;
                    if (!int.TryParse(TBox.Text, out quantity))
                    {
                        orderGood = false;
                        str = "Add a quantity; ";
                    }
                    DropDownList Dd;
                    Dd = (DropDownList)gvPizzas.Rows[row].FindControl("dropSize");
                    string size = Dd.SelectedValue.ToString();
                    Pizza pizza = new Pizza();
                    pizza.PizzaType = pizzaType;
                    pizza.Price = price;
                    pizza.Size = size;
                    pizza.Quantity = quantity;
                    pizza.TotalCost = PizzaOrder.PizzaPrice(pizza.Size, pizza.Price, pizza.Quantity, pizza.PizzaType);
                    arrOrder.Add(pizza);

                    count = count + 1;
                }
            }
            if (count == 0)
            {
                orderGood = false;
                str += "Select a Pizza; ";
            }
            if (orderGood)
            {
                //PizzaOrder order = new PizzaOrder();

                double totalPrice = 0.0;
                int pizzaCount = 0;
                foreach (Pizza pizzas in arrOrder)
                {
                    totalPrice += pizzas.TotalCost;
                    pizzaCount += pizzas.Quantity;
                }
                lblOrder.Text = "Thank you for your order, " + name + ". You selected an order for " + delivery + ". Your address is " + address + ". And your phone number is " + phone + ". Your order is below.";
                gvOrder.DataSource = arrOrder;
                gvOrder.DataBind();
                gvOrder.Columns[0].FooterText = "Totals:";
                gvOrder.Columns[2].FooterText = pizzaCount.ToString();
                gvOrder.Columns[4].FooterText = totalPrice.ToString();
                gvOrder.Columns[0].FooterStyle.ForeColor = Color.Red;
                gvOrder.Columns[2].FooterStyle.ForeColor = Color.Red;
                gvOrder.Columns[4].FooterStyle.ForeColor = Color.Red;
                gvOrder.DataBind();
                gvPizzas.Visible = false;
            }
            else
            {
                lblOrder.Text = str;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Pizzas ORDER BY TotalQuantityOrdered DESC";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvManager.DataSource = myDS;
            gvManager.DataBind();
        }
    }
}