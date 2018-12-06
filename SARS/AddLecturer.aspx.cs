using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class AddLecturer : System.Web.UI.Page
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

        protected void btnAddLecturer_Click(object sender, EventArgs e)
        {
            string un = txtUsername.Text;
            string pw = txtPassword.Text;
            string ln = txtLecturerName.Text;
            string cn = DDL_Course.SelectedValue;

            if (DBConnectivity.ValidateLecturerUsername(un))
            {
                DBConnectivity.AddLecturer(un, pw, ln, cn);
                Label1.Text = "Lecturer Added Successfully!";
            }
            else
            {
                Label1.Text = "Username has been taken!";
            }
        }
    }
}