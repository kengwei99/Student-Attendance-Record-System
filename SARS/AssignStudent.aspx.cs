using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class AssignStudent : System.Web.UI.Page
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

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            string sn = DropDownList1.SelectedValue;
            string tid = DropDownList2.SelectedValue;
            string Label2 = DropDownList2.SelectedItem.Text;
            if (DBConnectivity.ValidateAssign(sn,tid))
            {
                DBConnectivity.AssignStudent(sn, tid);
                Label1.Text = "Assign Successed!";
            }
            else
            {
                Label1.Text = "The Student and Class is added!";
            }
        }
    }
}