using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pay.Class;
namespace Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "Jaką operację chcesz wykonać? \n 0 - zakończ \n 1 - dodaj pozycję do zamówienia \n 2 - zapłać \n 3 - wartość brutto \n 4 - wartość podatku \n 5 - drukuj potwierdzenie \n";
            int choose = 0;
            Order order = new Order();
            do
            {
                Console.WriteLine(menu);
                choose = Convert.ToInt32(Console.In.ReadLine());
                switch(choose)
                {
                    case 1:
                        Console.WriteLine("Podaj Nazwę, cenę, podatek, ilość");
                        string name = Console.In.ReadLine();
                        float price = Convert.ToSingle(Console.In.ReadLine());
                        int tax = Convert.ToInt32(Console.In.ReadLine());
                        float ammount = Convert.ToSingle(Console.In.ReadLine());
                        order.AddOrder(new PositionOfOrder(name,price,tax,ammount));
                        break;
                    case 2:
                        Cash cash = new Cash();
                        Console.Out.WriteLine("Wpisz kwotę płatności");
                        cash.paymentAmount = Convert.ToSingle(Console.In.ReadLine());
                        order.PayOrder(cash);
                        break;
                    case 3:
                        Console.WriteLine(order.ValueOfOrder());
                        break;
                    case 4:
                        Console.WriteLine(order.ValueOfTAX());
                        break;
                    case 5:
                        order.PrintConfire();
                        break;
                }
            } while (choose != 0);
        }
    }
}
