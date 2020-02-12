using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineInsurance
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Signup_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            UserEntity user = new UserEntity(textCustomerName.Text, Convert.ToInt32(textPolicyNumber.Text), Convert.ToInt64(textphoneNumber.Text), textDateOfBirth.Text, textMailId.Text, textPassword.Text, textRole.Text);
            if (userManager.InsertCustomerDetail(user) == true)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Fails')</script>");
            }

        }
    }
}