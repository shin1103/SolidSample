using System;

namespace _1_SplitMethod
{
    class Program
    {
        /// <summary>
        /// Input catType and run car by catType.
        /// </summary>
        /// <param name="args">catType</param>
        static void Main(string[] args)
        {
            WriteLog("Start Process");

            string carType = args[0];
            if (!RunCar(carType))
            {
                WriteLog("No carType Found");
            }

            WriteLog("End Process");
        }

        /// <summary>
        /// Write Log In Console
        /// </summary>
        /// <param name="message">message to write</param>
        static void WriteLog(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// runnning a car by catType
        /// </summary>
        /// <param name="carType">car</param>
        /// <returns>if catType found return true, else return false.</returns>
        static bool RunCar(string carType)
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
