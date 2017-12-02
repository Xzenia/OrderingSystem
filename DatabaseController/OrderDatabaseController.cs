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
    public class OrderDatabaseController
    {
        SqlConnection connect = ConstantVariables.connect;
        public Boolean addOrderInfo(DataTable data)
        {
            using (SqlBulkCopy bc = new SqlBulkCopy(connect))
            {
                connect.Open();
                bc.DestinationTableName = "OrderTable";
                try
                {
                    bc.WriteToServer(data);
                    connect.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    connect.Close();
                    return false;
                }
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
