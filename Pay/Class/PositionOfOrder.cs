using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay.Class
{
    class PositionOfOrder
    {
        public PositionOfOrder(string nameOfThing, float detailPrice, int VATRate, float amount)
        {
            this.nameOfThing = nameOfThing;
            this.detailPrice = detailPrice;
            this.VATRate = VATRate;
            this.amount = amount;
        }
        private string nameOfThing;
        private float detailPrice;
        private int VATRate;
        private float amount;
        public double CalculateBrutto()
        {
            return (detailPrice + (detailPrice * VATRate /100)) * amount;
        }
        public double CalculateTAX()
        {
            return (detailPrice * VATRate / 100) * amount;
        }
    }
}
