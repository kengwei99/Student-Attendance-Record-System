using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class AddCoordinator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (((string)Session["type"] != "admin"))
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void btnAddCoordinator_Click(object sender, EventArgs e)
        {
            string un = txtUsername.Text;
            string pw = txtPassword.Text;
            string cn = txtCoordinatorName.Text;

            if (DBConnectivity.ValidateUsername(un)) {
                DBConnectivity.AddCoordinator(un, pw, cn);
                Label1.Text = "Coordinator Added Successfully!";
            }
            else
            {
                Label1.Text = "Username has been taken!";
            }
        }
    }
}