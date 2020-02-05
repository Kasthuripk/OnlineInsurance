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
            string customerName = textCustomerName.Text;
            int customerId = int.Parse(textCustomerId.Text);
            long policyNumber = long.Parse(TextPolicyNumber.Text);
            long mobileNumber = long.Parse(textphoneNumber.Text);
            DateTime DOB = Convert.ToDateTime(textDOB.Text);
            string mailId = textMailId.Text;
            string password = textPassword.Text;
            UserRepository user = new UserRepository();
            int rows = user.AddCustomer(customerName, customerId, policyNumber, mobileNumber, DOB, mailId, password);
            if (rows >= 1)
                Response.Redirect("SingUp.aspx");

        }
    }
}