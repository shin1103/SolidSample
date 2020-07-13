using System;
using System.Collections.Generic;
using System.Text;

namespace _7_InterfaceSegregation.Car
{
    class FireEngine: ICar, IBeatSiren
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
