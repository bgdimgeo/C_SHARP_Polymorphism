using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQty { get;  }

        double FuelConsumption { get;  }
        int TankCapacity { get;  }
        string Drive(double distance,bool empty);
        void Refill(double liters);
    }
}
