using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay.Class
{
    class EMail : iNote
    {
        protected string addres;
        public void PrintConfire()
        {
            Console.Out.WriteLine("Wysłano eMail");
        }
    }
}
