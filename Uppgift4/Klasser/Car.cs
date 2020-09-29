using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Car : Vehicle
    {
        public bool HasTowbar { get; set; }

        //public Car(string modelName, string licensePlate, string registrationDate, bool hasTowbar) : base(modelName, licensePlate, registrationDate)
        //{
        //    HasTowbar = hasTowbar;
        //    _typeOfVehicle = "Bil";
        //}

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
                Console.WriteLine("Dragkrok: JA");
            else
                Console.WriteLine("Dragkrok: NEJ");
        }

    }
}
