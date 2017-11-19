using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Data
{
    public class DataCheck
    {
        public Boolean checkInputs(String productPriceField, String productStockField)
        {
            double testValue;
            int anotherTestValue;
            if (!double.TryParse(productPriceField, out testValue))
            {
                return false;
            }
            else if (!int.TryParse(productStockField, out anotherTestValue))
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
