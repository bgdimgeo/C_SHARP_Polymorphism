using Exercise_1_Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Vehicles.Models
{
    internal class Truck : Vehicle
    {
        private const double TruckConsuptionIncrement = 1.6;
        private const double RefuelCoefficient = 0.95; 
        public Truck(double fuelQty, double fouelCons,int tankCapacity)
            : base(fuelQty, fouelCons,tankCapacity)
        {
        }

        protected override double FuelConsumptionModifier => TruckConsuptionIncrement;

        public override void Refill(double liters)
        {
            base.Refill(liters*RefuelCoefficient);
        }
    }
}
