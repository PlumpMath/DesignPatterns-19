using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public class BrickBuilding : IBuilding
    {
        public bool ForSale
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public void Advertise()
        {
            Console.WriteLine("Brick buildings are very warm!");
        }

        public void SetPrice()
        {
            Price = 150;
        }

        public void Sell()
        {
            ForSale = false;
            Console.WriteLine("Brick house was sold!");
        }
    }
}
