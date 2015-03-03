using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class CourseRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Register.aspx");
        }

        protected void btnAddDelStud_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Students.aspx");
        }

        protected void btnToCourse_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Courses.aspx");
        }
    }
}