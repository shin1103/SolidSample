using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text;

namespace _8_LiskovSubstitution.Car
{
    class CarBase
    {
        protected int _velocity = 0;
        protected int _gasoline = 0;


        public virtual void Run()
        {
            Console.WriteLine("Boo");
        }

        public virtual void SetVelocity(int velocity)
        {
            // limitation of velocity
            Contract.Requires(velocity >= 100);

            this._velocity = velocity;
        }

        public virtual int GetRemainingGasoline()
        {
            // Calculate RemainingGasoline
            this.CalculateRemainingGasoline();

            Contract.Ensures(this._gasoline >= 50);
            return this._gasoline;
        }

        private void CalculateRemainingGasoline()
        {
            var rand = new Random();
            this._gasoline = rand.Next(0, 50);
        }

        [ContractInvariantMethod]
        protected void ObjectInvariant()
        {
            Contract.Invariant(this._gasoline >= 0);
        }
    }
}
