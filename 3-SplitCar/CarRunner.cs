using _3_SPlitCar.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_CarInterface
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
            switch (carType)
            {
                case "FireEngine":
                    FireEngine fire = new FireEngine();
                    fire.RunFireEngine();
                    return true;
                case "Bus":
                    Bus bus = new Bus();
                    bus.RunBus();
                    return true;
                case "PoliceCar":
                    PoliceCar police = new PoliceCar();
                    police.RunPoliceCar();
                    return true;
                default:
                    return false;
            }

        }
    }
}
