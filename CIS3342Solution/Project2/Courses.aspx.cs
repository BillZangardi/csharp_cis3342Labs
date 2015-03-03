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
    public partial class Courses : System.Web.UI.Page
    {


        DBConnect objDB = new DBConnect();
        DataSet myDS;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * FROM Course";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvAllCourses.DataSource = myDS;
                gvAllCourses.DataBind();

                Session["theDataSet"] = myDS;
            }

        }

        protected void RefreshGridView()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Course";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvAllCourses.DataSource = myDS;
            gvAllCourses.DataBind();
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            Course course = new Course();
            course.Crn = txtCRN.Text;
            course.CourseTitle = txtCourseTitle.Text;
            course.DepartmentId = dropDept.SelectedItem.Text;
            course.Section = txtSection.Text;
            course.Professor = txtProfessor.Text;
            course.DayCode = dropDayCode.SelectedItem.Text;
            course.TimeCode = txtTimeCode.Text;
            double credHours;
            if(double.TryParse(txtCreditHours.Text, out credHours)){
                course.CreditHours = credHours;
            } else {
                isValid = false;
            }
            int maxSeats;
            if(Int32.TryParse(txtMaxNumSeats.Text, out maxSeats)){
                course.MaxSeats = maxSeats;
            } else {
                isValid = false;
            }
            if (course.Crn == "" || course.CourseTitle == "" || course.DepartmentId == "" || course.Section == "" || course.Professor == "" || course.DayCode == "" || course.TimeCode == "")
            {
                isValid=false;
            }
            if (isValid)
            {
                RegistrationFunctions.AddCourse(course);
                lblError.Text = "Course Added Successfully";
                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * FROM Course";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvAllCourses.DataSource = myDS;
                gvAllCourses.DataBind();
            }
            else
            {
                lblError.Text = "Please correct fields";
            }
            
        }

        protected void gvAllCourses_PageIndexChanging(Object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            // Set the GridView to display the correct page
            gvAllCourses.PageIndex = e.NewPageIndex;
            myDS = (DataSet)Session["theDataSet"];
            gvAllCourses.DataSource = myDS;
            gvAllCourses.DataBind();
        }

        protected void btnAddDept_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string deptName = txtDeptName.Text;
            string deptID = txtDeptID.Text;
            string location = txtLocation.Text;
            string error = "";

            if (deptID == "" || deptName == "" || location == "")
            {
                isValid = false;
                error += "Please Fill Out All Fields. ";
            }
            if (!(deptID.Length == 3))
            {
                isValid = false;
                error += "Department I.D. must be 3 characters long";
            }
            if (isValid)
            {
                RegistrationFunctions.AddDepartment(deptID, deptName, location);
                lblDeptError.Text = "Department Added Successfully";
                Response.BufferOutput = true;
                Response.Redirect("Courses.aspx");
            }
            else
            {
                lblDeptError.Text = "Please correct fields";
            }
        }

        protected void gvAllCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        // RowEditing event handler that fires when the CommandField Edit button is clicked.
        // There is no double-click that will produce this handler
        protected void gvAllCourses_RowEditing(Object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            // Set the row to edit-mode in the GridView
            gvAllCourses.EditIndex = e.NewEditIndex;

            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Course";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvAllCourses.DataSource = myDS;
            gvAllCourses.DataBind();

            lblDeptError.Text = "";
        }

        // RowUpdating event handler that fires when the CommandField Update button is clicked.
        // There is no double-click that will produce this handler
        protected void gvAllCourses_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {

            DBConnect objDB = new DBConnect();

            // retrieve the row index for which the Update button was clicked
            // and retrieve the ProductNumber from the first column (BoundField) in that row.
            int rowIndex = e.RowIndex;
            String crn = gvAllCourses.Rows[rowIndex].Cells[0].Text;
            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TextBox TBox;
            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[1].Controls[0];
            String name = TBox.Text;

            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[2].Controls[0];
            String dept = TBox.Text;

            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[3].Controls[0];
            String section = TBox.Text;

            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[4].Controls[0];
            String prof = TBox.Text;

            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[5].Controls[0];
            String dayCode = TBox.Text;

            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[6].Controls[0];
            String timeCode = TBox.Text;

            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[7].Controls[0];
            double credits =Convert.ToDouble(TBox.Text);

            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[8].Controls[0];
            int seatsAvail = Convert.ToInt32(TBox.Text);

            // Retrieve a reference to a TextBox created by the GridView when it's in edit-mode
            TBox = (TextBox)gvAllCourses.Rows[rowIndex].Cells[8].Controls[0];
            int maxSeats = Convert.ToInt32(TBox.Text);

            String strSQL = "UPDATE Course SET CourseTitle = '" + name + "', " +
                            "DepartmentID = '" + dept + "', " +
                            "Section = '" + section + "', " +
                            "Professor = '" + prof + "', " +
                            "DayCode = '" + dayCode + "', " +
                            "TimeCode = '" + timeCode + "', " +
                            "CreditHours = " + credits + ", " +
                            "NumberSeatsAvailable = " + seatsAvail + ", " +
                            "MaximumSeats = " + maxSeats + " " + 
                            "WHERE CRN = '" + crn + "';";

            if (objDB.DoUpdate(strSQL) >= 1)
            {
                lblDisplay.Text = "UPDATE SUCCESSFUL";
            }
            else
            {
                lblDisplay.Text = "UPDATE FAIL";
            }

            // Set the GridView back to the original state.
            // No rows currently being edited.
            gvAllCourses.EditIndex = -1;

            strSQL = "SELECT * FROM Course";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvAllCourses.DataSource = myDS;
            gvAllCourses.DataBind();
        }

        // RowCancelingEdit event handler that fires when the CommandField Cancel button is clicked.
        // There is no double-click that will produce this handler
        protected void gvAllCourses_RowCancelingEdit(Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            // Set the GridView back to the original state
            // No rows currently being editted
            gvAllCourses.EditIndex = -1;

            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Course";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvAllCourses.DataSource = myDS;
            gvAllCourses.DataBind();

            lblDisplay.Text = "";
        }

        protected void gvAllCourses_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String CRN = gvAllCourses.Rows[rowIndex].Cells[0].Text;
            //lblDisplay.Text = CRN;
            RegistrationFunctions.DeleteCourse(CRN);
            String strSQL = "SELECT * FROM Course";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvAllCourses.DataSource = myDS;
            gvAllCourses.DataBind();
        }
        
    }
}