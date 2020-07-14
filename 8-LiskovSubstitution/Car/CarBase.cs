using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _8_LiskovSubstitution.Car
{
    class CarBase
    {
        protected int _velocity = 0;


        public virtual void Run()
        {
            Console.WriteLine("Boo");
        }

        public virtual void SetVelocity(int velocity)
        {
            // limitation of velocity
            Debug.Assert(velocity >= 100);

            this._velocity = velocity;
        }

        public virtual int GetRemainingGasoline()
        {
            // Calculate RemainingGasoline
            var remaining = this.CalculateRemainingGasoline();

            Debug.Assert(remaining >= 50);
            return remaining;
        }

        private int CalculateRemainingGasoline()
        {
            var rand = new Random();
            return rand.Next(0, 50);
        }

    }
}
