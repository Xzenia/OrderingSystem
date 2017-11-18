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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Aaron Miguel\Documents\Programming Mindfuckery\C# Bizarre Adventures\OrderingSystem\OrderingSystem\Database\ProgramDatabase.mdf';Integrated Security=True");
        
        public Boolean addProduct(byte[] image, string productName, double productPrice, int productStock, string productCategory)
        {
            SqlCommand cmd = new SqlCommand("SP_ADDNEWPRODUCTDATA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            int productId = generateProductId();
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
            cmd.Parameters.AddWithValue("@ProductStock", productStock);
            cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
            cmd.Parameters.AddWithValue("@ProductImage", image);
            executeQuery(cmd);
            return true;
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
