using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class RenaultFactory: CarFactory
    {
        public IWindshield CreateWindshield()
        {
            return new RenaultWindshield();
        }

        public IWheel CreateWheel()
        {
            return new RenaultWheel();
        }

        public IEngine CreateEngine()
        {
            return new RenaultEngine();
        }
    }
}
