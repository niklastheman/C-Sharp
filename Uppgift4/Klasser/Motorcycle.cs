using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Motorcycle : Vehicle
    {
        public int MaxSpeed { get; set; }


        public Motorcycle(string modelName, string licensePlate, string registrationDate, int maxSpeed) : base(modelName, licensePlate, registrationDate)
        {
            MaxSpeed = maxSpeed;
            _typeOfVehicle = "Motorcykel";
        }

        public Motorcycle()
        {
            _typeOfVehicle = "Motorcykel";
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Maxhastighet: {MaxSpeed}km/h");
        }

    }
}
