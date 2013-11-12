﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public class ConcreteWorkingCompany : ConstructionCompany
    {
        public override IBuilding CreateBuilding()
        {
            return new ConcreteBuilding();
        }
    }
}
