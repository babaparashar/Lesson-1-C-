using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public virtual decimal CalculateDiscount()
        {
            return 0;
        }
    }
}
