using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class Milk : Product
    {
        public Milk(string name, double price, int quantity) : base(name, price, quantity)
        {
        }

        public override double GetDiscount()
        {
            if(quantity_ >= 5 && quantity_ < 10)
            {
                return 0.05;
            }

            if(quantity_ >= 10 && quantity_ < 25)
            {
                return 0.15;
            }

            if(quantity_ > 25)
            {
                return 0.5;
            }

            return 0.0;
        }

    }
}
