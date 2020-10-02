using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Bus : Vehicle
    {
        public int MaxAmountOfPassengers { get; set; }

        public Bus()
        {
            _typeOfVehicle = "Buss";
        }

        /// <summary>
        /// Skriver ut all information om en <b>buss.</b>
        /// <b>Skriver ut max antal passagerare.</b>
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Max antal passangerare: {MaxAmountOfPassengers}");
        }
    }
}
