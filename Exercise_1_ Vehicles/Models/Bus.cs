using Exercise_1_Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Vehicles.Models
{
    internal class Bus : Vehicle
    {
        private const double BusConsumptionIncrement = 0.14;
        private bool lastTimePassengers;


        public Bus(double fuel, double consumption,int tankCapacity) : base(fuel, consumption, tankCapacity)
        {

        }
        public bool LastTimePassengers { get { return this.lastTimePassengers; } set {
                if (value == true)
                {
                    this.lastTimePassengers = true;
                }
                else 
                {
                    this.lastTimePassengers = false;
                }
            } }

        protected override void IsEmpty(bool empty)
        {
            if (empty == true && LastTimePassengers == false)
            {
                this.FuelConsumption +=  BusConsumptionIncrement;
                LastTimePassengers = true;
            }
            else if (empty == false && LastTimePassengers == true) 
            {
                this.FuelConsumption -= BusConsumptionIncrement;
            }
        }
    }
}
