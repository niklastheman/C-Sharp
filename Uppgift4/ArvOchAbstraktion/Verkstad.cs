using Klasser;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ArvOchAbstraktion
{
    public class Verkstad : IVerkstad
    {
        

        private List<Vehicle> _listOfVehicles;
        public List<Vehicle> ListOfVehicles
        {
            get
            {
                if (_listOfVehicles == null)
                {
                    _listOfVehicles = new List<Vehicle>();
                }
                return _listOfVehicles;
            }

            set
            {
                _listOfVehicles = value;
            }
        }



        /// <summary>
        /// Lägger till ett fordon till verkstaden.
        /// </summary>
        /// <param name="vehicle">Typ av fordon</param>
        public bool AddVehicle(Vehicle vehicle)
        {
            ListOfVehicles.Add(vehicle);

            return true;
        }

        /// <summary>
        /// Skriver ut alla fordon i verkstaden och tar bort ett fordon ur verkstaden med hjälp av registreringsnummer.
        /// </summary>
        public void RemoveVehicle(Vehicle vehicle)
        {
            ListOfVehicles.Remove(vehicle);

            Console.WriteLine($"Fordon: {vehicle.TypeOfVehicle} " +
                $"med registreringsnummer: {vehicle.LicensePlate}" +
                $"\nTogs bort från verkstaden.");
        }



        public List<Vehicle> GetListOfVehicles()
        {
            return ListOfVehicles;
        }



    }
}
