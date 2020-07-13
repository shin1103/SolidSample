using System;
using System.Collections.Generic;
using System.Text;

namespace _4_ImplementInterface.Car
{
    class PoliceCar: ICar
    { 
        public void Run()
        {
            Console.WriteLine("WooWoo");
        }
    }
}
