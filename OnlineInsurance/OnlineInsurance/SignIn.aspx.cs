﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineInsurance
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignIn_Click(object sender, EventArgs e)
        {
            Response.Write("Sign in successfully completed");
        }
        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpForm.aspx");
        }
    }
}