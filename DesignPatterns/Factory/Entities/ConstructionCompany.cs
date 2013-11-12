using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public abstract class ConstructionCompany
    {
        public void MakeMoneyFromRealEstate()
        {
            IBuilding building = CreateBuilding();
            building.SetPrice();
            building.Advertise();
            building.Sell();
        }

        public abstract IBuilding CreateBuilding();
    }
}
