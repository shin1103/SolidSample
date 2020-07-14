using System;
using System.Collections.Generic;
using System.Text;

namespace _8_LiskovSubstitution.Car
{
    class PoliceCar: CarBase
    { 
        public override void Run()
        {
            Console.WriteLine("WooWoo");
        }

    }
}
