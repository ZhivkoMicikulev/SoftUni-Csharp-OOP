using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles.Core.Contracts;
using Vehicles.Factories;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine

    {
        private VehicleFactory vehicleFactory;
     

        public Engine()
        {
            this.vehicleFactory = new VehicleFactory();

        }

        public void Run()
        {
            //ProduceCar();

            ProduceVehicle();
            ProduceVehicle();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                try
                {
                    ProcessCommand(cmdArgs);
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
               
            }

        }

        private void ProcessCommand(string[] cmdArgs)
        {
            var type = cmdArgs[0];
            var vehicleType = cmdArgs[1];
            var arg = double.Parse(cmdArgs[2]);

            if (type == "Drive")
            {
                if (vehicleType == "Car")
                {
                    car.Drive(arg);
                }
                else if (vehicleType == "Truck")
                {
                    truck.Drive(arg);
                }

            }
            else if (type == "Refuel")
            {
                if (vehicleType == "Car")
                {
                    car.Refuel(arg);
                }
                else if (vehicleType == "Truck")
                {
                    truck.Refuel(arg);
                }

            }
        }

        private void ProduceVehicle()
        {
            var truckArgs = Console.ReadLine()
                            .Split()
                            .ToArray();
            var type = truckArgs[0];
            var fuelQty = double.Parse(truckArgs[1]);
            var fuelConsuption = double.Parse(truckArgs[2]);
            Vehicle truck = this.vehicleFactory.ProduceVehicle(type, fuelQty, fuelConsuption);
        }

        private static void ProduceCar()
        {
            var carArg = Console.ReadLine()
                  .Split()
                  .ToArray();

            var fuelQty = double.Parse(carArg[1]);
            var fuelConsumption = double.Parse(carArg[2]);
            Vehicle car = new Car(fuelQty, fuelConsumption);
        }
    }
}

