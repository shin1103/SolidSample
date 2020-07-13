using System;
using System.Collections.Generic;
using System.Text;

namespace _6_AddSirenInterfaceMethod.Car
{
    class PoliceCar: ICar
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
