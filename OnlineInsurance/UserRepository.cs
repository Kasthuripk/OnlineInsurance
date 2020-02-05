using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineInsurance
{
    public class UserRepository
    {
        SqlConnection connection;
        string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public int AddCustomer(string customerName, int customerId, long policyNumber, long phoneNumber, DateTime dateOfBirth, string mailId, string password)
        {
            string query = "spCustomerDetail_Insert";
            int rows;
            connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@customerName";
                param.Value = customerName;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@customerId";
                param.Value = customerId;
                param.SqlDbType = System.Data.SqlDbType.Int;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@policyNumber";
                param.Value = policyNumber;
                param.SqlDbType = System.Data.SqlDbType.BigInt;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@phoneNumber";
                param.Value = phoneNumber;
                param.SqlDbType = System.Data.SqlDbType.BigInt;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@dateOfBirth";
                param.Value = dateOfBirth;
                param.SqlDbType = System.Data.SqlDbType.Date;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mailId";
                param.Value = mailId;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = password;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            return rows;
        }
    }
}
