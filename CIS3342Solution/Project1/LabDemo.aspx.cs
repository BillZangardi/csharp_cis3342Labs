using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;

namespace Project1
{
    public partial class LabDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Pizzas";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvPizzas.DataSource = myDS;
            gvPizzas.DataBind();


        }
    }
}