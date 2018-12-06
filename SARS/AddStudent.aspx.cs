using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (((string)Session["type"] != "admin") && ((string)Session["type"] != "coordinator"))
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            string un = txtUsername.Text;
            string pw = txtPassword.Text;
            string sn = txtStudentName.Text;
            string cn = DDL_Course.SelectedValue;
            if (DBConnectivity.ValidateStudentUsername(un))
            {
                DBConnectivity.AddStudent(un, pw, sn, cn);
                Label1.Text = "Student Added Successfully!";
            }
            else
            {
                Label1.Text = "Username has been taken!";
            }
        }
    }
}