using System;
using System.Collections.Generic;
using System.Text;

namespace _5_ImplementFactory.Car
{
    class Bus : ICar
    {
        public void Run()
        {
            Console.WriteLine("Broom");
        }
    }
}
