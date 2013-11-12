using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class FordFactory : CarFactory
    {
        public IWindshield CreateWindshield()
        {
            return new FordWindshield();
        }

        public IWheel CreateWheel()
        {
            return new FordWheel();
        }

        public IEngine CreateEngine()
        {
            return new FordEngine();
        }
    }
}
