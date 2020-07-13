using System;

namespace _6_AddSirenInterfaceMethod
{
    class Program
    {
        /// <summary>
        /// Input catType and run car by catType.
        /// </summary>
        /// <param name="args">catType</param>
        static void Main(string[] args)
        {
            ConsoleLogger.WriteLog("Start Process");

            string carType = args[0];
            if (!CarRunner.RunCar(carType))
            {
                ConsoleLogger.WriteLog("No carType Found");
            }

            ConsoleLogger.WriteLog("End Process");
        }
    }
}
