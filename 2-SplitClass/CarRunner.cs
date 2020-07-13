using System;
using System.Collections.Generic;
using System.Text;

namespace _2_SplitClass
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
                    Console.WriteLine("Peepo");
                    return true;
                case "Bus":
                    Console.WriteLine("Broom");
                    return true;
                case "PoliceCar":
                    Console.WriteLine("WooWoo");
                    return true;
                default:
                    return false;
            }

        }
    }
}
