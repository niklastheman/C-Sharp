using ArvOchAbstraktion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    /// <summary>
    /// Den här verkstade kan:
    /// <br>-Ta emot lättare lastbilar (maxlast < 2000)</br>
    /// <br>-Ta emot mopeder (motorcykelns maxhastighet är max 50km/h)</br>
    /// <br>-Ta emot minibussar (maxantal passagerare < 8)</br>
    /// </summary>
    class VerkstadV2 : IVerkstad
    {
        private bool _isOkayToAdd;

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
            var tryToAddVehicle = false;

            _isOkayToAdd = IsOkayToAdd(vehicle);
            if (_isOkayToAdd)
            {
                ListOfVehicles.Add(vehicle);
                tryToAddVehicle = true;
            }

            return tryToAddVehicle;

        }

        /// <summary>
        /// Tar bort ett fordon från verkstaden och skriver ut vad för fordons-typ det var, och vad reg-numret var.
        /// </summary>
        public void RemoveVehicle(Vehicle vehicle)
        {
            ListOfVehicles.Remove(vehicle);

            Console.WriteLine($"Fordon: {vehicle.GetVehicleType()} " +
                $"med registreringsnummer: {vehicle.LicensePlate}" +
                $"\nTogs bort från verkstaden.");
        }

        public List<Vehicle> GetListOfVehicles()
        {
            return ListOfVehicles;
        }

        private bool IsOkayToAdd(Vehicle vehicle)
        {
            if (vehicle is Truck)
            {
                var truck = vehicle as Truck;

                if (truck.MaxLoadInKG <= 2000)
                _isOkayToAdd = true;

                else
                    _isOkayToAdd = false;
            }

            if (vehicle is Motorcycle)
            {
                var motorcycle = vehicle as Motorcycle;

                if (motorcycle.MaxSpeed <= 50)
                    _isOkayToAdd = true;

                else
                    _isOkayToAdd = false;
            }

            if (vehicle is Bus)
            {
                var bus = vehicle as Bus;

                if (bus.MaxAmountOfPassengers <= 8)
                _isOkayToAdd = true;
                else
                    _isOkayToAdd = false;
            }

            return _isOkayToAdd;
        }
    }
}
