using System;
using System.Collections.Generic;
using System.Text;

namespace _7_InterfaceSegregation.Car
{
    static class CarFactory
    {
        public static ICar getCar(string carType)
        {
            switch (carType)
            {
                case "FireEngine":
                    return new FireEngine();
                case "Bus":
                    return new Bus();
                case "PoliceCar":
                    return new PoliceCar();
                // If you want to add new catType, only create new ICar class and edit CarFactory. 
                //case "Camper":
                //    return new Camper();
                default:
                    return null;
            }
        }
    }
}
