using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class AddTimetable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (((string)Session["type"] != "admin") && ((string)Session["type"] != "coordinator"))
                {
                    Response.Redirect("Default.aspx");
                }
                DDL_SJName.DataSourceID = "SqlDataSource1";
                DDL_SJName.DataTextField = "SJName";
                DDL_SJName.DataValueField = "SJName";
                DDL_SJName.DataBind();
            }
        }

        protected void btnAddTimetable_Click(object sender, EventArgs e)
        {
            string sjn = DDL_SJName.SelectedValue;
            string day = DDL_Day.SelectedValue;
            string period = DDL_Period.SelectedValue;
            string cn = DDL_SJName.SelectedValue;

            DBConnectivity.AddTimetable(sjn, day, period, cn);
            Label2.Text = "Timetable Added Successful!";
        }
    }
}