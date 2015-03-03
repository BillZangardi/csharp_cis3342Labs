using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddRealtor_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("AddEditRealtors.aspx");
        }

        protected void btnAddHome_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("AddEditHomes.aspx");
        }

        protected void btnSearchHome_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Homes.aspx");
        }
    }
}