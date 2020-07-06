using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
  public abstract  class Vehicle
    {
        private const double DEFAULT_CONSUMPTION = 1.25;
        public Vehicle(int horsePower,double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption => DEFAULT_CONSUMPTION;
    
        public virtual void Drive(double kilometers)
        {
            if (Fuel-kilometers*FuelConsumption>=0)
            {
                Fuel -= kilometers * FuelConsumption;
            }
        }
   
    }


}
