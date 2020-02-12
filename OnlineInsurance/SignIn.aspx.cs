using System;
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
            string username = textUserId.Text;
            string password = textPassword.Text;
            UserEntity user = new UserEntity(username,password);
            UserManager userManager = new UserManager();
            userManager.ValidateSignIn(user);
            if (true)
                Response.Write("Sign in successfully completed");
            else
                Response.Write("Sign in not completed..Please create your account");

        }
        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}