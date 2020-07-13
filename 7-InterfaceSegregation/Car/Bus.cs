using System;
using System.Collections.Generic;
using System.Text;

namespace _7_InterfaceSegregation.Car
{
    class Bus : ICar
    {
        public void Run()
        {
            Console.WriteLine("Broom");
        }

        // Can comment out by Interface Segregation
        ///// <summary>
        ///// Bus has no siren but need to implement, because of interface definition.
        ///// </summary>
        //public void BeatSiren()
        //{
        //    return;
        //}

    }
}
