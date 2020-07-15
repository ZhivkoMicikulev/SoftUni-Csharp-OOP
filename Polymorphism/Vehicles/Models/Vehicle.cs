using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuelable
    {
        public Vehicle(double fuelQuantity,double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
       
        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get;protected set; }
       
        public string Drive(double kilometers)
        {
            var fuelNeeded = kilometers *
                 this.FuelConsumption;
            if (this.FuelQuantity<fuelNeeded)
            {
                throw new InvalidOperationException
                    (string.Format
                    (ExceptionMesseges.NotEnoughFuelMSG,GetType().Name));
            }
            this.FuelQuantity -= fuelNeeded;
            return $"{string.Format(ExceptionMesseges.EnoughFuel, GetType().Name)}";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount>0)
            {
                this.FuelQuantity += fuelAmount;
            }
          
        }
    }
}
