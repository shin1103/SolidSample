using _4_ImplementInterface.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4_ImplementInterface
{
    static class CarRunner
    {
        /// <summary>
        /// runnning a car by catType
        /// </summary>
        /// <param name="carType">car</param>
        /// <returns>if catType found return true, else return false.</returns>
        public static bool RunCar(string carType)
        {
            ICar car = null;
            switch (carType)
            {
                case "FireEngine":
                    car = new FireEngine();
                    break;
                case "Bus":
                    car = new Bus();
                    break;
                case "PoliceCar":
                    car = new PoliceCar();
                    return true;
                default:
                    return false;
            }

            car.Run();
            return true;
        }
    }
}
