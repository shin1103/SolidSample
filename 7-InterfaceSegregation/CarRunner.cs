using _7_InterfaceSegregation.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7_InterfaceSegregation
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
            ICar car = CarFactory.getCar(carType);
            if (car is null) { return false; }

            car.Run();
            return true;
        }
    }
}
