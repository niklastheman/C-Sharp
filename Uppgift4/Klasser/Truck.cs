using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Truck : Vehicle
    {
        public int MaxLoadInKG { get; set; }

        public Truck(string modelName, string licensePlate, string registrationDate, int maxLoadInKG) : base(modelName, licensePlate, registrationDate)
        {
            MaxLoadInKG = maxLoadInKG;
            _typeOfVehicle = "Lastbil";
        }

        public Truck()
        {
            _typeOfVehicle = "Lastbil";
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Maxlast: {MaxLoadInKG}KG");
        }
    }
}
