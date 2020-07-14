using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _8_LiskovSubstitution.Car
{
    class FireEngine: CarBase
    {
        public override void Run()
        {
            Console.WriteLine("Peepo");
        }

        public override void SetVelocity(int velocity)
        {
            // (precondition) this limitation is looser than CarBase -> It's OK
            Debug.Assert(velocity >= 120);
            base._velocity = velocity;
        }
        public override int GetRemainingGasoline()
        {
            // Calculate RemainingGasoline
            var remaining = this.CalculateRemainingGasolineForFireEngine();

            // (postcondition) this limitation is looser than CarBase -> violated Liskov's substitution principle
            Debug.Assert(remaining >= 100);
            return remaining;
        }

        private int CalculateRemainingGasolineForFireEngine()
        {
            var rand = new Random();
            return rand.Next(0, 100);
        }
    }
}
