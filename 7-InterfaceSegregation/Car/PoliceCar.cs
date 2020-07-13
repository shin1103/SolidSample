using System;
using System.Collections.Generic;
using System.Text;

namespace _7_InterfaceSegregation.Car
{
    class PoliceCar: ICar, IBeatSiren
    { 
        public void Run()
        {
            Console.WriteLine("WooWoo");
        }

        public void BeatSiren()
        {
            Console.WriteLine("BeatSiren");
            return;
        }
    }
}
