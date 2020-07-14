using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(velocity >= 80);
            base._velocity = velocity;
        }

        public override int GetRemainingGasoline()
        {
            // Calculate RemainingGasoline
            var remaining = this.CalculateRemainingGasolineForBus();

            // (postcondition) this limitation is stricter than CarBase -> It's OK
            Debug.Assert(remaining >= 30);
            return remaining;
        }

        private int CalculateRemainingGasolineForBus()
        {
            var rand = new Random();
            return rand.Next(0, 30);
        }

    }
}
