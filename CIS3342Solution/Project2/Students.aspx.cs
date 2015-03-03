using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;

using CourseRegistrationLibrary;

namespace Project2
{
    public partial class Students : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        DataSet myDS;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String strSQL = "SELECT * FROM Students";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvStudents.DataSource = myDS;
                gvStudents.DataBind();

                Session["theDataSet"] = myDS;
            }

        }

        protected void btnAddStud_Click(object sender, EventArgs e)
        {

        }

        protected void refreshTable()
        {
            String strSQL = "SELECT * FROM Students";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvStudents.DataSource = myDS;
            gvStudents.DataBind();
        }

        protected void gvStudents_PageIndexChanging(Object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            // Set the GridView to display the correct page
            gvStudents.PageIndex = e.NewPageIndex;
            myDS = (DataSet)Session["theDataSet"];
            gvStudents.DataSource = myDS;
            gvStudents.DataBind();
        }

        protected void gvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvStudents.SelectedRow.Cells[0].Text;
            lblRosterName.Text = gvStudents.SelectedRow.Cells[1].Text;
            DataSet sr = RegistrationFunctions.GetStudentRoster(id);
            gvStudentRoster.DataSource = sr;
            gvStudentRoster.DataBind();
            DataSet tuition = RegistrationFunctions.GetTuition(id);
            gvTuition.DataSource = tuition;
            gvTuition.DataBind();
        }

        protected void btnAddStud_Click1(object sender, EventArgs e)
        {
            string name = txtStudName.Text;
            string major = txtStudMajor.Text;
            string id = RegistrationFunctions.AddStudent(name, major);
            lblStudID.Text = "StudentID: " + id;
            refreshTable();
        }

    }
}