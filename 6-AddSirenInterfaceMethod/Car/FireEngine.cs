using System;
using System.Collections.Generic;
using System.Text;

namespace _6_AddSirenInterfaceMethod.Car
{
    class FireEngine: ICar
    {
        public void Run()
        {
            Console.WriteLine("Peepo");
        }

        public void BeatSiren()
        {
            Console.WriteLine("BeatSiren");
            return;
        }
    }
}
