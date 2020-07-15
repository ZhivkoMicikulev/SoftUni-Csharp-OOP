﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_CONSUPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override double FuelConsumption 
        {
            get => base.FuelConsumption; 
            protected set => base.FuelConsumption =value + FUEL_CONSUPTION; 
        }
    }
}
