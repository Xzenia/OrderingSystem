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
    public class AccountTableDatabaseController
    {
        Security sec = new Security();
        Guid userGuid = System.Guid.NewGuid();
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Aaron Miguel\Documents\Programming Mindfuckery\C# Bizarre Adventures\OrderingSystem\OrderingSystem\Database\ProgramDatabase.mdf';Integrated Security=True");

        public Boolean addUser(string username, string password)
        {
            String hashedPassword = sec.HashSHA1(password + userGuid.ToString());
            using(SqlCommand cmd = new SqlCommand("SP_ADDNEWUSERACCOUNTAUTHENTICATOR", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@UserGuid", userGuid);
                return executeQuery(cmd);
            }
        }

        public int checkIfUsernameExists(string username)
        {
            
            using (SqlCommand cmd = new SqlCommand("SP_CHECKIFUSERNAMEEXISTS", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                connect.Open();
                int val = (int) cmd.ExecuteScalar();
                connect.Close();
                return val;
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
