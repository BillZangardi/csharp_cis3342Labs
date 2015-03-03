using System;
using System.Collections;
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
    public partial class Register : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        DataSet myDS;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCourseSearch_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string day = dropDayCode.SelectedItem.Text;
            string dept = dropDept.SelectedItem.Text;
            String strSQL = "";
            if (chkSelectAllDays.Checked && chkSelectAllDept.Checked)
            {
                strSQL = "SELECT * FROM Course WHERE NumberSeatsAvailable > 0;";
            }
            else if (!chkSelectAllDays.Checked && chkSelectAllDept.Checked)
            {
                strSQL = "SELECT * FROM Course WHERE DayCode LIKE '" + day + "' AND NumberSeatsAvailable > 0;";
            }
            else if (chkSelectAllDays.Checked && !chkSelectAllDept.Checked)
            {
                strSQL = "SELECT * FROM Course WHERE DepartmentID LIKE '" + dept + "' AND NumberSeatsAvailable > 0";
            }
            else
            {
                strSQL = "SELECT * FROM Course WHERE DepartmentID LIKE '" + dept + "' AND DayCode LIKE '" + day + "' AND NumberSeatsAvailable > 0;";
            }
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvCourses.DataSource = myDS;
            gvCourses.DataBind();

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            ArrayList classes = new ArrayList();
            string studID = txtStudentID.Text;
            double credits =0;
            double tuition =0;
            if (studID == "")
            {
                isValid = false;
            }
            if (isValid)
            {
                for (int row = 0; row < gvCourses.Rows.Count; row++)
                {
                    CheckBox CBox;
                    CBox = (CheckBox)gvCourses.Rows[row].FindControl("chkRegister");

                    if (CBox.Checked)
                    {
                        RegClass reg = new RegClass();
                        reg.Crn = gvCourses.Rows[row].Cells[0].Text;
                        reg.Credits =double.Parse(gvCourses.Rows[row].Cells[7].Text);
                        tuition = reg.Credits * 250;
                        classes.Add(reg);
                    }
                }
                lblError.Text = RegistrationFunctions.RegisterClasses(classes, studID, tuition);
                //lblError.Text = "Registration Successfull";
            }
            else
            {
                lblError.Text = "Please Provide Student ID";
            }
        }

        protected void dropDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}