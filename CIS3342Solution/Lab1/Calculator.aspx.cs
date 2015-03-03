using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;
            string oper = dropOperators.SelectedItem.Text;
            lblResult.Text = "= " + Calculate.calculateNums(num1, num2, oper).ToString();
        }
    }
}