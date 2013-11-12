using DesignPatterns.AbstractFactory;
using DesignPatterns.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Car fordCar = new Car();
            fordCar.CreateCar(new FordFactory());
            Console.WriteLine(fordCar.Engine.GetType().Name);

            ConstructionCompany company = new WoodWorkingCompany();
            company.MakeMoneyFromRealEstate();

            Console.ReadKey();
        }
    }
}
