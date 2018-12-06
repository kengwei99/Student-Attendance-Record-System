using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class AddSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((string)Session["type"] != "admin" && (string)Session["type"] != "coordinator")
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void btnAddSubject_Click(object sender, EventArgs e)
        {
            string sjn = txtSubjectName.Text;
            string cn = DDL_Course.SelectedValue;
            if (DBConnectivity.ValidateSubject(sjn))
            {
                DBConnectivity.AddSubject(sjn, cn);
                Label2.Text = "Subject Added";
            }
            else
            Label2.Text = "Subject Already Taken!";
        }
    }
}