using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace OnlineInsurance
{
    public partial class GridView : System.Web.UI.Page
    {   
        UserManager userManager = new UserManager();
      public  string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGridView();
            }
        }
        void PopulateGridView()
        {   
            DataTable table =userManager.ViewCustomerDetail();
            UserData.DataSource = table;
            UserData.DataBind();
        }
        protected void UserGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            UserData.EditIndex = -1;
            PopulateGridView();
        }

        protected void UserGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int CustomerId = Convert.ToInt32(UserData.DataKeys[e.RowIndex].Values["customerId"].ToString());
            userManager.DeleteCustomerDetail(CustomerId);
            PopulateGridView();
        }

        protected void UserGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {

            UserData.EditIndex = e.NewEditIndex;
            PopulateGridView();
        }

        protected void UserGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string customerName = ((UserData.Rows[e.RowIndex].FindControl("textCustomerName") as TextBox).Text);
                int customerId = Convert.ToInt32(UserData.DataKeys[e.RowIndex].Values["customerId"].ToString());
                int policyNumber = Convert.ToInt32((UserData.Rows[e.RowIndex].FindControl("textPolicyNumber") as TextBox).Text);
                long phoneNumber = Convert.ToInt32((UserData.Rows[e.RowIndex].FindControl("textPhoneNumber") as TextBox).Text) ;
                string dateOfBirth = ((UserData.Rows[e.RowIndex].FindControl("textDateOfBirth") as TextBox).Text) ;
                string mailId = ((UserData.Rows[e.RowIndex].FindControl("textMailId") as TextBox).Text);
                string password = ((UserData.Rows[e.RowIndex].FindControl("textPassword") as TextBox).Text);
                string role = ((UserData.Rows[e.RowIndex].FindControl("textRole") as TextBox) .Text);
                UserEntity user = new UserEntity(customerName, policyNumber, phoneNumber, dateOfBirth, mailId, password, role);
                userManager.UpdateCustomerDetail(user);
                UserData.EditIndex = -1;
                PopulateGridView();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void linkInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = ((UserData.FooterRow.FindControl("txtCustomerNameFooter") as TextBox).Text);
                int policyNumber = Convert.ToInt32((UserData.FooterRow.FindControl("txtpolicyNumberFooter") as TextBox).Text);
                long phoneNumber = Convert.ToInt64((UserData.FooterRow.FindControl("txtPhoneNumberFooter") as TextBox).Text);
                string dateofBirth = (UserData.FooterRow.FindControl("txtDateOfBirthFooter") as TextBox).Text;
                string mailId = ((UserData.FooterRow.FindControl("txtMailIdFooter") as TextBox).Text);
                string password =((UserData.FooterRow.FindControl("txtPasswordFooter") as TextBox).Text);
                string role =(UserData.FooterRow.FindControl("txtRoleFooter") as TextBox).Text;
                UserEntity user = new UserEntity(customerName, policyNumber, phoneNumber, dateofBirth, mailId, password, role);
                userManager.InsertCustomerDetail(user);
                UserData.EditIndex = -1;
                PopulateGridView();
            }
         catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}