using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Car : Vehicle
    {
        public bool HasTowbar { get; set; }

        public Car()
        {
            _typeOfVehicle = "Bil";
        }

        /// <summary>
        /// Skriver ut all information om <b>bilen.</b> 
        /// <b>Skriver ut om bilen har dragkrok</b>
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            if (HasTowbar)
                Console.WriteLine("Dragkrok: Ja");
            else
                Console.WriteLine("Dragkrok: Nej");
        }

    }
}
