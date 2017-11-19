using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController
{
    public class HashPassword
    {
        public string HashSHA256(string value)
        {
            var sha256 = System.Security.Cryptography.SHA256.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha256.ComputeHash(inputBytes);
            
            //Creates a string and converts the bytes of the hash variable into hexadecimal and concatenates it into the string
            //More info about line 23 here: https://stackoverflow.com/a/20750093
            
            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
