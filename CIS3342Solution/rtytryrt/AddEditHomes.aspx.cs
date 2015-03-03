using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_3
{
    public partial class AddEditHomes : System.Web.UI.Page
    {
        localhost.RealityService pxy = new localhost.RealityService();
        DataSet myDS;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Default.aspx");
        }

        protected void btnViewHouses_Click(object sender, EventArgs e)
        {
            String realtorID = dropRealtor.SelectedItem.Text;
            gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorID);
            gvHouseListings.DataBind();
        }

        protected void btnAddHouses_Click(object sender, EventArgs e)
        {
            string realtorId = dropRealtor.SelectedItem.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = dropState.SelectedItem.Value;
            string listPrice = txtListingPrice.Text;
            string avail = dropAvail.SelectedItem.Text;
            string sqft = txtSqFt.Text;
            string baths = dropBaths.SelectedItem.Text;
            string beds = dropBeds.SelectedItem.Text;
            string type = txtType.Text;
            String errorMessage = "";
            bool canProcess = true;
            if (address == "" || city == "" || state == "" || listPrice == "" || sqft == "" || avail == "" || beds == "" || baths == "" || type == "")
            {
                canProcess = false;
                errorMessage += "Please make sure all fields are filled to edit \n";
            }
            double num;
            if (!double.TryParse(listPrice, out num))
            {
                canProcess = false;
                errorMessage += "Please make sure list price is a numerical representation  <br />";
            }
            if (!double.TryParse(sqft, out num))
            {
                canProcess = false;
                errorMessage += "Please make sure square feet is a numerical representation  <br />";
            }
            int num2;
            if (!Int32.TryParse(beds, out num2))
            {
                canProcess = false;
                errorMessage += "Please make sure beds is a numerical representation  <br />";
            }
            if (!double.TryParse(baths, out num))
            {
                canProcess = false;
                errorMessage += "Please make sure baths is a numerical representation  <br />";
            }
            if (canProcess)
            {
                lblMessage.Text = pxy.AddHome(realtorId, address, city, state, listPrice, avail, sqft, baths, beds, type);
                gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorId);
                gvHouseListings.DataBind();
            }
            else
            {
                lblMessage.Text = errorMessage;
            }

        }

        protected void gvHouseListings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvHouseListings_PageIndexChanging(Object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvHouseListings.PageIndex = e.NewPageIndex;
            myDS = (DataSet)Session["theDataSet"];
            gvHouseListings.DataSource = myDS;
            gvHouseListings.DataBind();
            String realtorID = dropRealtor.SelectedItem.Text;
            gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorID);
            gvHouseListings.DataBind();
        }

        protected void gvHouseListings_RowEditing(Object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            // Set the row to edit-mode in the GridView
            gvHouseListings.EditIndex = e.NewEditIndex;

            String realtorID = dropRealtor.SelectedItem.Text;
            gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorID);
            gvHouseListings.DataBind();
        }

        // RowUpdating event handler that fires when the CommandField Update button is clicked.
        // There is no double-click that will produce this handler
        protected void gvHouseListings_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {


            // retrieve the row index for which the Update button was clicked
            // and retrieve the ProductNumber from the first column (BoundField) in that row.
            int rowIndex = e.RowIndex;
            String homeId = gvHouseListings.Rows[rowIndex].Cells[0].Text;
            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TextBox TBox;
            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[1].Controls[0];
            String address = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[2].Controls[0];
            String city = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[3].Controls[0];
            String state = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[4].Controls[0];
            String listPrice = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[5].Controls[0];
            String sqft = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[6].Controls[0];
            String avail = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[7].Controls[0];
            String beds = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[8].Controls[0];
            String baths = TBox.Text;

            TBox = (TextBox)gvHouseListings.Rows[rowIndex].Cells[10].Controls[0];
            String type = TBox.Text;
            String errorMessage = "";
            bool canProcess = true;
            if(address == "" || city == "" || state == "" || listPrice == "" || sqft == "" ||avail == "" || beds == "" || baths == "" ||  type == "" ){
                canProcess = false;
                errorMessage += "Please make sure all fields are filled to edit <br />";
            }
            double num;
            if (!double.TryParse(listPrice, out num))
            {
                canProcess = false;
                errorMessage += "Please make sure list price is a numerical representation  <br />";
            }
            if (!double.TryParse(sqft, out num))
            {
                canProcess = false;
                errorMessage += "Please make sure square feet is a numerical representation  <br />";
            }
            int num2;
            if (!Int32.TryParse(beds, out num2))
            {
                canProcess = false;
                errorMessage += "Please make sure beds is a numerical representation  <br />";
            }
            if (!double.TryParse(baths, out num))
            {
                canProcess = false;
                errorMessage += "Please make sure baths is a numerical representation  <br />";
            }

            String strSQL = "UPDATE Home SET Address = '" + address + "', " +
                "City = '" + city + "', " +
                "ListingPrice = " + listPrice + ", " +
                "SquareFeet = " + sqft + ", " +
                "Availability = '" + avail + "', " +
                "Beds = " + beds + ", " +
                "Baths = " + baths + ", " +
                "Type = '" + type + "' " +
                "WHERE Id ='" + homeId + "';";

            //lblMessage.Text = strSQL;
            if (canProcess)
            {
                if (pxy.UpdateHome(strSQL))
                {
                    lblMessage.Text = "UPDATE SUCCESS";
                }
                else
                {
                    lblMessage.Text = "UPDATE FAIL";
                }
            }
            else
            {
                lblMessage.Text = errorMessage;
            }


            // Set the GridView back to the original state.
            // No rows currently being edited.
            gvHouseListings.EditIndex = -1;

            String realtorID = dropRealtor.SelectedItem.Text;
            gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorID);
            gvHouseListings.DataBind();
        }

        // RowCancelingEdit event handler that fires when the CommandField Cancel button is clicked.
        // There is no double-click that will produce this handler
        protected void gvHouseListings_RowCancelingEdit(Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            // Set the GridView back to the original state
            // No rows currently being editted
            gvHouseListings.EditIndex = -1;

            String realtorID = dropRealtor.SelectedItem.Text;
            gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorID);
            gvHouseListings.DataBind();
        }

        protected void gvHouseListings_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String homeId = gvHouseListings.Rows[rowIndex].Cells[0].Text;
            //DELETE FUNTION HERE
            lblMessage.Text = pxy.DeleteHome(homeId);

            String realtorID = dropRealtor.SelectedItem.Text;
            gvHouseListings.DataSource = pxy.GetRealtorsListings(realtorID);
            gvHouseListings.DataBind();
        }
    }
}