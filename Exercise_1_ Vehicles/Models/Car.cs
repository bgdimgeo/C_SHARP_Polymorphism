using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double CarFuelConsumptionIncrement = 0.9;
        public Car(double fuelQty, double fouelCons,int tankCapacity) 
            : base(fuelQty, fouelCons, tankCapacity)
        {

        }

        protected override double FuelConsumptionModifier => CarFuelConsumptionIncrement;
    }
}
