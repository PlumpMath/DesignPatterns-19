using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public class WoodBuilding : IBuilding
    {
        public void Advertise()
        {
            Console.WriteLine("Wood houses are the best!");
        }

        public void SetPrice()
        {
            Price = 100;
        }

        public void Sell()
        {
            ForSale = false;
            Console.WriteLine("Wood house was sold!");
        }

        public double Price
        {
            get;
            set;
        }

        public bool ForSale
        {
            get;
            set;
        }
    }
}
