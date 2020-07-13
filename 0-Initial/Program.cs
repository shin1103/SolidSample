using System;

namespace _0_Initial
{
    class Program
    {
        /// <summary>
        /// Input catType and run car by catType.
        /// </summary>
        /// <param name="args">catType</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Start Process");

            string carType = args[0];

            switch (carType)
            {
                case "FireEngine":
                    Console.WriteLine("Peepo");
                    break;
                case "Bus":
                    Console.WriteLine("Broom");
                    break;
                case "PoliceCar":
                    Console.WriteLine("WooWoo");
                    break;
                default:
                    Console.WriteLine("No carType Found");
                    break;
            }
            Console.WriteLine("End Process");
        }
    }
}
