using System;
using System.Collections.Generic;
using System.Text;

namespace _6_AddSirenInterfaceMethod.Car
{
    class Bus : ICar
    {
        public void Run()
        {
            Console.WriteLine("Broom");
        }

        /// <summary>
        /// Bus has no siren but need to implement, because of interface definition.
        /// </summary>
        public void BeatSiren()
        {
            return;
        }

    }
}
