using Exercise_1_Vehicles.Models;

using System;
using System.Linq;

namespace Exercise_1_Vehicles
{
    internal class StratUp
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), int.Parse(carArgs[3]));
            string[] truckArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), int.Parse(truckArgs[3]));
            string[] busArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), int.Parse(busArgs[3]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = cmdArgs[0];

                if (command == "Drive")
                {
                    if (cmdArgs[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(cmdArgs[2])));
                    }
                    else if (cmdArgs[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(cmdArgs[2])));
                    }
                    else if (cmdArgs[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(double.Parse(cmdArgs[2]),true));
                    }

                }
                else if (command == "DriveEmpty")
                {
                    Console.WriteLine(bus.Drive(double.Parse(cmdArgs[2])));
                }
                else if (command == "Refuel")
                {
                    if (cmdArgs[1] == "Car")
                    {
                        car.Refill(double.Parse(cmdArgs[2]));
                    }
                    else if (cmdArgs[1] == "Truck")
                    {
                        truck.Refill(double.Parse(cmdArgs[2]));
                    }
                    else if (cmdArgs[1] == "Bus")
                    {
                        bus.Refill(double.Parse(cmdArgs[2]));
                    }
                }



            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
        public void Drive(Vehicle vehicle, double distance) 
        {
            vehicle.Drive(distance);
        }
        public void Refuel(Vehicle vehicle, double liters)
        {
            vehicle.Refill(liters);
        }
       
    }
}
