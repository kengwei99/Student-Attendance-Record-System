using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((string)Session["type"] != "admin" && (string)Session["type"] != "lecturer")
                {
                    Response.Redirect("Default.aspx");
                }
            }
            String weekno = (String)(Request.QueryString["day"]);
            if ((DateTime.Now.DayOfWeek.ToString()) != weekno)
            {
                Response.Write("<h4>Sorry! Today is not the day you selected! Please use Back button of browser and try again!</h4>");
                Response.End();
            }
            lblToday.Text = DateTime.Now.ToShortDateString();
            lblWeekno.Text = Request.QueryString["day"];
            lblPeriod.Text = Request.QueryString["period"];
            lblSubject.Text = Request.QueryString["sjname"];
        }

        protected void Btn_Record_Click(object sender, EventArgs e)
        {
            string status;
            string sj = lblSubject.Text;
            string day = lblWeekno.Text;
            string period = lblPeriod.Text;
            string ln = (String)Session["name"];

            
            RadioButton rb;
            foreach (GridViewRow r in GridView1.Rows)
            {
                status = "l";
                rb = (RadioButton)r.FindControl("rbPresent");
                if (rb.Checked)
                    status = "Present";
                else
                {
                    rb = (RadioButton)r.FindControl("rbAbsent");
                    if (rb.Checked)
                        status = "Absent";
                }
                string sid = r.Cells[0].Text;
                string sn = r.Cells[1].Text;
                DBConnectivity.RecordAttendance(sid, sn, ln, sj, day, period, status, lblToday.Text);
            }
            lbl_attendance.Text = "Record Successful!";
        }
    }
}