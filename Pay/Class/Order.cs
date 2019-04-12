using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay.Class
{
    class Order
    {
        private DateTime dateOfRealize;
        private bool orderStatut;
        private string orderID;
        private List<PositionOfOrder> listOfOrders;
        private bool eConfire;
        public Order()
        {
            orderStatut = false;
            listOfOrders = new List<PositionOfOrder>();
        }
        public double ValueOfOrder()
        {
            double sum=0;
            foreach(var order in listOfOrders)
            {
                sum += order.CalculateBrutto();
            }
            return sum;
        }
        public double ValueOfTAX()
        {
            double sum = 0;
            foreach (var order in listOfOrders)
            {
                sum += order.CalculateTAX();
            }
            return sum;

        }
        public bool PayOrder(Payment payment)
        {
            if (!orderStatut)
            {
                orderStatut = !orderStatut;
            }
            else
            {
                Console.Out.WriteLine("Już było płacone!!");
            }
            return orderStatut;
        }
        public void PrintConfire()
        {
            if (orderStatut)
            {
                if (eConfire)
                {
                    EMail email = new EMail();
                    email.PrintConfire();
                }
                else
                {
                    Printer printer = new Printer();
                    printer.PrintConfire();
                }
            }else
            {
                Console.Out.WriteLine("Nie zapłacono");
            }
        }
        public bool AddOrder(PositionOfOrder POO)
        {
            if(!orderStatut)
            {
                listOfOrders.Add(POO);
                return true;

            }
            else
            {
                return false;
            }

                
        }

    }
}
