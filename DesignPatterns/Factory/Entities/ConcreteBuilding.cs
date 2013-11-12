using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public class ConcreteBuilding : IBuilding
    {
        public double Price
        {
            get;
            set;
        }

        public void Advertise()
        {
            Console.WriteLine("Concrete buildings don't catch fire!");
        }

        public void SetPrice()
        {
            Price = 200;
        }

        public void Sell()
        {
            ForSale = false;
            Console.WriteLine("Concrete building was sold!");
        }

        public bool ForSale
        {
            get;
            set;
        }
    }
}
