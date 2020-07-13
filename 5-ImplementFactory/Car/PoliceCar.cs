using System;
using System.Collections.Generic;
using System.Text;

namespace _5_ImplementFactory.Car
{
    class PoliceCar: ICar
    { 
        public void Run()
        {
            Console.WriteLine("WooWoo");
        }
    }
}
