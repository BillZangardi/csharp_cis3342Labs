using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_3
{
    public partial class AddEditRealtors : System.Web.UI.Page
    {
        localhost.RealityService pxy = new localhost.RealityService();
        DataSet myDS;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myDS= pxy.GetRealtors();
                gvRealtors.DataSource = myDS;
                gvRealtors.DataBind();
            }
        }

        protected void gvRealtors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvRealtors.SelectedRow.Cells[0].Text;
            gvShowingRequests.DataSource = pxy.GetListingRequests(id);
            gvShowingRequests.DataBind();
        }

        protected void gvRealtors_PageIndexChanging(Object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvRealtors.PageIndex = e.NewPageIndex;
            myDS = (DataSet)Session["theDataSet"];
            gvRealtors.DataSource = myDS;
            gvRealtors.DataBind();
        }

        protected void gvRealtors_RowEditing(Object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            // Set the row to edit-mode in the GridView
            gvRealtors.EditIndex = e.NewEditIndex;


            gvRealtors.DataSource = pxy.GetRealtors();
            gvRealtors.DataBind();
        }

        // RowUpdating event handler that fires when the CommandField Update button is clicked.
        // There is no double-click that will produce this handler
        protected void gvRealtors_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {


            // retrieve the row index for which the Update button was clicked
            // and retrieve the ProductNumber from the first column (BoundField) in that row.
            int rowIndex = e.RowIndex;
            String realtorId = gvRealtors.Rows[rowIndex].Cells[0].Text;
            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TextBox TBox;
            TBox = (TextBox)gvRealtors.Rows[rowIndex].Cells[1].Controls[0];
            String name = TBox.Text;

            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TBox = (TextBox)gvRealtors.Rows[rowIndex].Cells[2].Controls[0];
            String company = TBox.Text;

            TBox = (TextBox)gvRealtors.Rows[rowIndex].Cells[3].Controls[0];
            String phoneNum = TBox.Text;

            String strSQL = "UPDATE Realtor SET Name = '" + name + "', " +
                "Company = '" + company + "', " +
                "PhoneNum = '" + phoneNum + "' " +
                "WHERE Id ='" + realtorId + "';";

            //lblMessage.Text = strSQL;

            pxy.UpdateRealtor(strSQL);


            // Set the GridView back to the original state.
            // No rows currently being edited.
            gvRealtors.EditIndex = -1;

            gvRealtors.DataSource = pxy.GetRealtors();
            gvRealtors.DataBind();
        }

        // RowCancelingEdit event handler that fires when the CommandField Cancel button is clicked.
        // There is no double-click that will produce this handler
        protected void gvRealtors_RowCancelingEdit(Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            // Set the GridView back to the original state
            // No rows currently being editted
            gvRealtors.EditIndex = -1;

            gvRealtors.DataSource = pxy.GetRealtors(); ;
            gvRealtors.DataBind();
        }

        protected void gvRealtors_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String realtorId = gvRealtors.Rows[rowIndex].Cells[0].Text;
            //DELETE FUNTION HERE
            lblMessage.Text = pxy.DeleteRealtor(realtorId);

            gvRealtors.DataSource = pxy.GetRealtors(); ;
            gvRealtors.DataBind();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Default.aspx");
        }

        protected void btnAddRealtor_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string company = txtCompany.Text;
            string phone = txtPhone.Text;

            //RealityServiceSVC1.Realtor objRealtor = new RealityServiceSVC1.Realtor();
            //objCustomer.Name = name;
            //objCustomer.Company = company;
            //objCustomer.Phone = phone;
            lblRealtorId.Text =pxy.AddRealtor(name, company, phone);
            gvRealtors.DataSource = pxy.GetRealtors();
            gvRealtors.DataBind();
        }
    }
}