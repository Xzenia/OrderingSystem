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
        HashPassword sec = new HashPassword();
        Guid userGuid = System.Guid.NewGuid();
        SqlConnection connect = ConstantVariables.connect;
        public string dbUserType = "Regular";
        public int dbUserId = 0;

        public Boolean addUser(int userId, string username, string password)
        {
            //Hash the password with SHA256 
            String hashedPassword = sec.HashSHA256(password + userGuid.ToString());
            using(SqlCommand cmd = new SqlCommand("SP_ADDNEWUSERACCOUNTAUTHENTICATOR", connect))
            {
                String userType = "Regular";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@UserGuid", userGuid);
                cmd.Parameters.AddWithValue("@AccountType", userType);
                return executeQuery(cmd);
            }
        }

        public Boolean adminAddUser(int userId, string username, string password, string userType)
        {
            //Hash the password with SHA256 
            String hashedPassword = sec.HashSHA256(password + userGuid.ToString());
            using (SqlCommand cmd = new SqlCommand("SP_ADDNEWUSERACCOUNTAUTHENTICATOR", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@UserGuid", userGuid);
                cmd.Parameters.AddWithValue("@AccountType", userType);
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

        public Boolean authenticateUser(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SP_AUTHENTICATEUSER", connect))
            {
                string dbUsername = "";
                string dbPassword = "";
                string dbUserguid = "";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                connect.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dbUsername = Convert.ToString(dataReader["UsernameField"]);
                    dbPassword = Convert.ToString(dataReader["PasswordField"]);
                    dbUserguid = Convert.ToString(dataReader["userGuid"]);
                    dbUserType = Convert.ToString(dataReader["AccountType"]);
                }
                connect.Close();
                string hashedPassword = sec.HashSHA256(password + dbUserguid);

                if (hashedPassword == dbPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Boolean confirmIfAdmin(string username)
        {
            using (SqlCommand cmd = new SqlCommand("SP_AUTHENTICATEUSER", connect))
            {
                string dbUserType = "";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                connect.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dbUserType = Convert.ToString(dataReader["AccountType"]);
                }
                connect.Close();
                if (dbUserType.Equals("ADMIN"))
                {
                    return true;
                }
                else
                {
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
