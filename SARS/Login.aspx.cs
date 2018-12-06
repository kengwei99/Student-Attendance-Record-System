﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SARS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                if (Session["userid"] != null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DBConnectivity.Login(TextBox1.Text, TextBox2.Text))
            {
                Response.Redirect("Default.aspx");
            }
            else { Label1.Text = "Login Failed, Please Check Your Id or Password"; }
        }
        }
    }