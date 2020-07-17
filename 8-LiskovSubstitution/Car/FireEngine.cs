using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Contract.Requires(velocity >= 120);
            base._velocity = velocity;
        }
        public override int GetRemainingGasoline()
        {
            // Calculate RemainingGasoline
            this.CalculateRemainingGasolineForFireEngine();

            // (postcondition) this limitation is looser than CarBase -> violated Liskov's substitution principle
            Contract.Ensures(this._gasoline >= 100);
            return this._gasoline;
        }

        private void CalculateRemainingGasolineForFireEngine()
        {
            var rand = new Random();
            base._gasoline = rand.Next(0, 100);
        }
    }
}
