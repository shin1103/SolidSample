using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text;

namespace _8_LiskovSubstitution.Car
{
    class Bus : CarBase
    {
        public override void Run()
        {
            Console.WriteLine("Broom");
        }

        public override void SetVelocity(int velocity)
        {
            // (precondition) this limitation is stricter than CarBase -> violated Liskov's substitution principle
            Contract.Requires(velocity >= 80);
            base._velocity = velocity;
        }

        public override int GetRemainingGasoline()
        {
            // Calculate RemainingGasoline
            this.CalculateRemainingGasolineForBus();

            // (postcondition) this limitation is stricter than CarBase -> It's OK
            Contract.Ensures(base._gasoline >= 30);
            return base._gasoline;
        }

        private void CalculateRemainingGasolineForBus()
        {
            var rand = new Random();
            base._gasoline =  rand.Next(0, 30);
        }

    }
}
