using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineInsurance
{
    public class UserRepository
    {

        string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public bool InsertCustomerDetail(UserEntity user)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "spCustomerDetail_Insert ";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@customerName", user.customerName));
                sqlCommand.Parameters.AddWithValue("@policyNumber", user.policyNumber);
                sqlCommand.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                sqlCommand.Parameters.AddWithValue("@dateOfBirth", user.dateOfBirth);
                sqlCommand.Parameters.AddWithValue("@mailId", user.mailId);
                sqlCommand.Parameters.AddWithValue("@password", user.password);
                sqlCommand.Parameters.AddWithValue("@role", user.role);
                int limit = sqlCommand.ExecuteNonQuery();
                if (limit >= 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
        public bool ValidateSignIn(UserEntity user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "spCustomer_select ";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@mailId", user.mailId);
                sqlCommand.Parameters.AddWithValue("@password", user.password);
                SqlDataReader data = sqlCommand.ExecuteReader();
                if (data.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public DataTable ViewCustomerDetail()
        {
            DataTable table;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "spCustomerDetail_View ";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
        }
        public bool DeleteCustomerDetail(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "spCustomerDetail_Delete";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@customerId", customerId);
                int limit = sqlCommand.ExecuteNonQuery();
                if (limit >= 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
        public bool UpdateCustomerDetail(UserEntity user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "spCustomerDetail_Delete";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@customerName", user.customerName));
                sqlCommand.Parameters.AddWithValue("@policyNumber", user.policyNumber);
                sqlCommand.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                sqlCommand.Parameters.AddWithValue("@dateOfBirth", user.dateOfBirth);
                sqlCommand.Parameters.AddWithValue("@mailId", user.mailId);
                sqlCommand.Parameters.AddWithValue("@password", user.password);
                sqlCommand.Parameters.AddWithValue("@role", user.role);
                int limit = sqlCommand.ExecuteNonQuery();
                if (limit >= 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
      
        }
    }




        
       
        