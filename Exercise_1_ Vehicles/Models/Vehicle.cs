using Exercise_1_Vehicles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Vehicles

{
    public abstract class Vehicle : IVehicle
    {
        
        private double fuelQty;
        private double fuelConsumption;
        private int tankCapacity;



        public double FuelQty {
            get
            {
                return this.fuelQty;
            } 
            private set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQty = 0;
                }
                else 
                {
                    this.fuelQty = value;
                }
            }
        }

        public int TankCapacity 
        { 
            get 
            { 
                return this.tankCapacity; 
            } 
            private set
            {
                this.tankCapacity = value;
            }
        }
        public  double FuelConsumption { get { return this.fuelConsumption; } protected set { this.fuelConsumption = value + this.FuelConsumptionModifier; } }

        protected Vehicle(double fuelQty, double fouelCons, int tankCapcity)
        {
            this.TankCapacity = tankCapcity;
            this.FuelQty = fuelQty;
            this.FuelConsumption = fouelCons;
            
        }
        protected virtual double FuelConsumptionModifier { get; }

        public  string Drive(double distance,bool empty = false)
        {
            IsEmpty(empty);
            double fuelNeeded = distance * this.FuelConsumption;
            if (fuelNeeded > this.FuelQty)
            {
                //Not enoyugh fuel
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQty -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        protected virtual void IsEmpty(bool empty )
        {

        }

        public virtual void Refill(double liters)
        {
            if (liters > 0)
            {
                if (this.fuelQty + liters > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");

                }
                else 
                { 
                    this.FuelQty += liters;
                    }
                
            }
            else 
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQty:f2}";
        }
    }
}
