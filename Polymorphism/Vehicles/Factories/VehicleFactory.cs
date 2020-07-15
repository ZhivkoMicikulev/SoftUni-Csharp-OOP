using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles.Factories
{
  public  class VehicleFactory
    {
        public Vehicle ProduceVehicle(string type,double
            fuelQty,double fuelConsuption)
        {
            Vehicle vehicle=null;
            if (type=="Car")
            {
                vehicle = new Car(fuelQty, fuelConsuption);
            }
            else if (type=="Truck")
            {
                vehicle = new Truck(fuelQty, fuelConsuption);

            }
            if (vehicle == null)
            {
                throw new ArgumentException(ExceptionMesseges.InvalidTypeMSG);
            }
            return vehicle;
        }
    }
}
