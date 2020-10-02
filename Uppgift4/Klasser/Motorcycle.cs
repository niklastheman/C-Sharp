using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Motorcycle : Vehicle
    {
        public int MaxSpeed { get; set; }

        public Motorcycle()
        {
            _typeOfVehicle = "Motorcykel";
        }

        /// <summary>
        /// Skriver ut all information om en <b>motorcykel.</b> 
        /// <b>Skriver ut motorcykelns maxhastighet</b>
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Maxhastighet: {MaxSpeed}km/h");
        }

    }
}
