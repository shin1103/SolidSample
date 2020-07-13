using System;
using System.Collections.Generic;
using System.Text;

namespace _4_ImplementInterface.Car
{
    class FireEngine: ICar
    {
        public void Run()
        {
            Console.WriteLine("Peepo");
        }
    }
}
