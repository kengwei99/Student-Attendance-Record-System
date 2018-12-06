using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                Label1.Text = "Welcome " + Session["name"].ToString() + "! You are " + Session["type"].ToString();
            }
            else
            {
                Label1.Text = "Welcome! You are guest, please login first.";
            }
        }
    }
}