using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Truck : Vehicle
    {
        public int MaxLoadInKG { get; set; }

        //public Truck()
        //{
        //    if (MaxLoadInKG <= 2000)
        //        TypeOfVehicle = "Lätt lastbil";

        //    else
        //        TypeOfVehicle = "Lastbil";

        //}

        /// <summary>
        /// Skriver ut all information om en <b>lastbil</b>. 
        /// <b>Lägger till maxvikt i KG.</b>
        /// </summary>
        //public override void PrintInfo()
        //{
        //    base.PrintInfo();
        //    Console.WriteLine($"Maxlast: {MaxLoadInKG}KG");
        //}
    }
}
