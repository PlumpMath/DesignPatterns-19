using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public interface IBuilding
    {
        Boolean ForSale { get; set; }

        double Price { get; set; }

        void Advertise();

        void SetPrice();

        void Sell();
    }
}
