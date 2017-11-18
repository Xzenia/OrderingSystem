﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DatabaseController
{
    public class CustomerDatabaseController
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Aaron Miguel\Documents\Programming Mindfuckery\C# Bizarre Adventures\OrderingSystem\OrderingSystem\Database\ProgramDatabase.mdf';Integrated Security=True");
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

        public Boolean addUserInfo(byte[] customerImage, String customerName, String customerType)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ADDNEWCUSTOMERDATA", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerImage", customerImage);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@customerType", customerType);
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
