using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseController
{
    public static class ConstantVariables
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Aaron Miguel\Documents\Programming Mindfuckery\C# Bizarre Adventures\OrderingSystem\DatabaseController\Database\ProgramDatabase.mdf';Integrated Security=True");

    }
}
