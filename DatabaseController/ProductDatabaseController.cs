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
    public class ProductDatabaseController
    {
        SqlConnection connect = ConstantVariables.connect;
        
        public Boolean addProduct(byte[] productImage, string productName, double productPrice, string productCategory)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ADDNEWPRODUCTDATA", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int productId = generateProductId();
                cmd.Parameters.AddWithValue("@ProductImage", productImage);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
                return executeQuery(cmd);
            }
        
        }

        public Boolean deleteProduct(int productId)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETEPRODUCTDATA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductId", productId);
            return executeQuery(cmd);
        }

        //Accomodates all SELECT * FROM stored procedures.
        
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

        public Boolean updateProductData(int productId, byte[] productImage, string productName, double productPrice, string productCategory)
        {
            using (SqlCommand cmd = new SqlCommand("SP_UPDATEPRODUCTDATA", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductImage", productImage);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
                return executeQuery(cmd);
            }
        }

        private int generateProductId()
        {
            Random rnd = new Random();
            return rnd.Next(111111, 999999);
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
