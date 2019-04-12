using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay.Class
{
    abstract class Payment
    {
        public float paymentAmount;
        public void Pay(Order order)
        {
            if (paymentAmount == (float)order.ValueOfOrder())
            {
                if (order.PayOrder(this))
                {
                    Console.Out.WriteLine("Pomyślnie zapłacono");
                }

            }else
            {
                Console.Out.WriteLine("Zła Kwota");
            }
            
        }

        public void PrintConfirm(Order order)
        {
            order.PrintConfire();
        }
    }
}
