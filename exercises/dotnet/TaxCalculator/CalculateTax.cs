using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class CalculateTax : TaxCalculator
    {
        public override int CalculateVehicleTax(Vehicle vehicle)
        {
        
            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }
            else if(vehicle.Co2Emissions < 51)
            {
                return 10;
            }
            else if (vehicle.Co2Emissions < 76)
            {
                return 25;
            }
            else if (vehicle.Co2Emissions < 91)
            {
                return 105;
            }
            else if (vehicle.Co2Emissions < 101)
            {
                return 125;
            }
            else if (vehicle.Co2Emissions < 111)
            {
                return 145;
            }
            else if (vehicle.Co2Emissions < 131)
            {
                return 165;
            }
            else if (vehicle.Co2Emissions < 151)
            {
                return 205;
            }
            else if (vehicle.Co2Emissions < 171)
            {
                return 515;
            }
            else if (vehicle.Co2Emissions < 191)
            {
                return 830;
            }
            else if (vehicle.Co2Emissions < 226)
            {
                return 1240;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                return 1760;
            }
            else 
                return 2070;
        }
    }
}
