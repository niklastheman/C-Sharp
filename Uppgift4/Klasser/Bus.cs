using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Bus : Vehicle
    {
        public int MaxAmountOfPassengers { get; set; }

        public Bus(string modelName, string licensePlate, string registrationDate, int maxAmountOfPassengers) : base(modelName, licensePlate, registrationDate)
        {
            MaxAmountOfPassengers = maxAmountOfPassengers;
            _typeOfVehicle = "Buss";
        }

        public Bus()
        {
            _typeOfVehicle = "Buss";
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Max antal passangerare: {MaxAmountOfPassengers}");
        }
    }
}
