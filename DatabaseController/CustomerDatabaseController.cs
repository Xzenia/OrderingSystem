using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DatabaseController
{
    //TODO: Change DataSet to DataTable for simpler code. 
    public class CustomerDatabaseController
    {
        SqlConnection connect = ConstantVariables.connect;

        public DataTable getData(string username)
        {
            string storedProcedure = "SP_GETCUSTOMERDATA";
            using (SqlCommand sql = new SqlCommand(storedProcedure, connect))
            {
                DataTable dt = new DataTable();
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Username", username);
                connect.Open();
                dt.Load(sql.ExecuteReader());
                connect.Close();
                return dt;
            }
        }

        public DataSet viewAllData(string storedProcedure)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            SqlDataAdapter addContent = queryRequest(storedProcedure);
            addContent.Fill(ds, storedProcedure);
            return ds;
        }

        public SqlDataAdapter queryRequest(string sqlStoredProcedure)
        {
            SqlCommand cmd = new SqlCommand(sqlStoredProcedure, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter addsContentToDataSet = new SqlDataAdapter(cmd);
            return addsContentToDataSet;
        }

        public Boolean adminAddUserInfo(int customerId, byte[] customerImage, String customerName, String customerUsername, String customerType)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ADDNEWCUSTOMERDATA", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@CustomerImage", customerImage);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@CustomerUsername", customerUsername);
                cmd.Parameters.AddWithValue("@CustomerType", customerType);
                return executeQuery(cmd);
            }
        }

        public Boolean addUserInfo(int customerId, byte[] customerImage, String customerName, String customerUsername)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ADDNEWCUSTOMERDATA", connect))
            {
                String customerType = "Regular";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@CustomerImage", customerImage);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@CustomerUsername", customerUsername);
                cmd.Parameters.AddWithValue("@CustomerType", customerType);
                return executeQuery(cmd);
            }
        }
        
        public Boolean executeQuery(SqlCommand cmd)
        {
            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();

            if (i != 0)
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
