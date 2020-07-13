using System;
using System.Collections.Generic;
using System.Text;

namespace _5_ImplementFactory.Car
{
    class FireEngine: ICar
    {
        public void Run()
        {
            Console.WriteLine("Peepo");
        }
    }
}
