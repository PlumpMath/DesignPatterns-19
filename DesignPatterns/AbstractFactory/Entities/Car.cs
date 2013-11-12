using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Car
    {
        #region Public Properties

        public List<IWheel> Wheels { get; set; }
        public IWindshield Windshield { get; set; }
        public IEngine Engine { get; set; }

        #endregion

        #region Public Methods

        public void CreateCar(CarFactory carFactory)
        {
            Wheels = new List<IWheel>();
            for (int i = 1; i <= 4; i++)
            {
                Wheels.Add(carFactory.CreateWheel());
            }

            Windshield = carFactory.CreateWindshield();
            Engine = carFactory.CreateEngine();
        }

        #endregion

    }
}
