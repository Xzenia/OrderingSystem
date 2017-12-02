using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatabaseController
{
    public class LoginCookie
    {
        private String customerType = "Regular";
        private int userId = 0;
        private String customerName = "lel";

        public String CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public String CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public void writeToFile()
        {
            TextWriter tw = new StreamWriter("userData");
            tw.WriteLine(userId);
            tw.WriteLine(customerName);
            tw.WriteLine(customerType);
            tw.Close();
        }

        public void readFile()
        {
            String fileName = "userData";
            TextReader tr = new StreamReader(fileName);
            userId = Convert.ToInt32(File.ReadLines(fileName).Take(1).First());
            customerName = File.ReadLines(fileName).Skip(1).Take(1).First();
            customerType = File.ReadLines(fileName).Skip(2).Take(1).First();
            tr.Close();
        }
    }
}
