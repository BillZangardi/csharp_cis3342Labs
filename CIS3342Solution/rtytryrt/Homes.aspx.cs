using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;

namespace Project_3
{
    public partial class Homes : System.Web.UI.Page
    {
        localhost.RealityService pxy = new localhost.RealityService();
        DataSet myGridDs;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvHomes.DataSource = pxy.GetHomes();
                gvHomes.DataBind();

                myGridDs = pxy.GetHouseCities();
                dropCity.DataSource = myGridDs.Tables[0];
                dropCity.DataTextField = "City";
                dropCity.DataValueField = "City";
                dropCity.DataBind();

                DataSet myDs = pxy.GetHouseStates();
                dropState.DataSource = myDs.Tables[0];
                dropState.DataTextField = "State";
                dropState.DataValueField = "State";
                dropState.DataBind();

                myDs = pxy.GetHouseTypes();
                dropType.DataSource = myDs.Tables[0];
                dropType.DataTextField = "Type";
                dropType.DataValueField = "Type";
                dropType.DataBind();
            }
        }

        protected void gvHomes_PageIndexChanging(Object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvHomes.PageIndex = e.NewPageIndex;
            myGridDs = (DataSet)Session["myGridDs"];
            gvHomes.DataSource = pxy.GetHomes();
            gvHomes.DataBind();
        }

        protected void btnSearchHomes_Click(object sender, EventArgs e)
        {
            bool needsANDinQuery = false;
            bool itemSelected = false;
            String sql = "SELECT * FROM Home WHERE ";
            string labelText = "<b>Houses With Preferenecs:</b><br/>";
            if (chkCity.Checked) {
                sql += "City LIKE '" + dropCity.SelectedItem.Text + "' ";
                labelText += "City: " + dropCity.SelectedItem.Text + "<br/>";
                needsANDinQuery = true;
                itemSelected = true;
            }
            if (chkState.Checked)
            {
                if (needsANDinQuery)
                {
                    sql += "AND State LIKE '" + dropState.SelectedItem.Text + "' ";
                    labelText += "State: " + dropState.SelectedItem.Text + "<br/>";
                }
                else { 
                    sql += "State LIKE '" + dropState.SelectedItem.Text + "' ";
                    labelText += "State: " + dropState.SelectedItem.Text + "<br/>";
                    needsANDinQuery = true;
                }
                itemSelected = true;
            }
            if (chkType.Checked)
            {
                if (needsANDinQuery)
                {
                    sql += "AND Type LIKE '" + dropType.SelectedItem.Text + "' ";
                    labelText += "Type: " + dropType.SelectedItem.Text + "<br/>";
                }
                else
                {
                    sql += "Type LIKE '" + dropType.SelectedItem.Text + "' ";
                    labelText += "Type: " + dropType.SelectedItem.Text + "<br/>";
                    needsANDinQuery = true;
                }
                itemSelected = true;
            }
            if (chkPrice.Checked)
            {
                if (needsANDinQuery)
                {
                    sql += "AND ListingPrice <= " + dropPriceMax.SelectedItem.Text + " ";
                    labelText += "Price: " + dropPriceMax.SelectedItem.Text + "<br/>";
                }
                else
                {
                    sql += "ListingPrice <= " + dropPriceMax.SelectedItem.Text + " ";
                    labelText += "Price: " + dropPriceMax.SelectedItem.Text + "<br/>";
                    needsANDinQuery = true;
                }
                itemSelected = true;
            }
            if (chkBeds.Checked)
            {
                if (needsANDinQuery)
                {
                    sql += "AND Beds >= " + dropBeds.SelectedItem.Text + " ";
                    labelText += "Beds: " + dropBeds.SelectedItem.Text + "<br/>";
                }
                else
                {
                    sql += "Beds >= " + dropBeds.SelectedItem.Text + " ";
                    labelText += "Beds: " + dropBeds.SelectedItem.Text + "<br/>";
                    needsANDinQuery = true;
                }
                itemSelected = true;
            }
            if (chkBaths.Checked)
            {
                if (needsANDinQuery)
                {
                    sql += "AND Baths >= " + dropBaths.SelectedItem.Text + " ";
                    labelText += "Baths: " + dropBaths.SelectedItem.Text + "<br/>";
                }
                else
                {
                    sql += "Baths >= " + dropBaths.SelectedItem.Text + " ";
                    labelText += "Baths: " + dropBaths.SelectedItem.Text + "<br/>";
                    needsANDinQuery = true;
                }
                itemSelected = true;
            }
            if (chkSqFt.Checked)
            {
                if (needsANDinQuery)
                {
                    sql += "AND SquareFeet >= " + dropSqFt.SelectedItem.Text + " ";
                    labelText += "Sq.Ft: " + dropSqFt.SelectedItem.Text + "<br/>";
                }
                else
                {
                    sql += "SquareFeet >= " + dropSqFt.SelectedItem.Text + " ";
                    labelText += "Sq.Ft: " + dropSqFt.SelectedItem.Text + "<br/>";
                    needsANDinQuery = true;
                }
                itemSelected = true;
            }
            if (itemSelected)
            {
                lblSearchQuery.Text = labelText;
                //lblSQLQuery.Text = sql;
                myGridDs = pxy.GetHomesByPreference(sql);
                gvHomes.DataSource = myGridDs;
                gvHomes.DataBind();
            }
            else
            {
                lblSearchQuery.Text = "<p style=\"color:red\">Please make at least one selection above</p>";
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Default.aspx");
        }

        protected void btnViewRequest_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            ArrayList classes = new ArrayList();
            string name = txtName.Text;
            string phone = txtPhone.Text;
            String homeId;
            String realtorId;
            if (name == "" || phone == "")
            {
                isValid = false;
            }
            if (isValid)
            {
                for (int row = 0; row < gvHomes.Rows.Count; row++)
                {
                    CheckBox CBox;
                    CBox = (CheckBox)gvHomes.Rows[row].FindControl("chkRequest");

                    if (CBox.Checked)
                    {
                        homeId = gvHomes.Rows[row].Cells[0].Text;
                        realtorId = gvHomes.Rows[row].Cells[10].Text;
                        string sql = pxy.HomeViewRequest(realtorId, homeId, name, phone);
                        lblError.Text = "SUCCESS";
                    }
                }
            }
            else
            {
                lblError.Text = "Please Provide Name/Phone";
            }
        }
    }
}