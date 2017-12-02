using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Data
{
    public class DataCheck
    {
        public Boolean checkInputs(String productPriceField)
        {
            double testValue;
            if (!double.TryParse(productPriceField, out testValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
