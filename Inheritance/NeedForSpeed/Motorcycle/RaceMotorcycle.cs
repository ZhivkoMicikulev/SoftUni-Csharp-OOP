using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Motorcycle
{
    
    public class RaceMotorcycle : Motorcycle
    {
        private const double CONSUPTION = 8;
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
        public override double FuelConsumption => CONSUPTION;
    }
}
