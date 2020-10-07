using System;

namespace Klasser
{
    public abstract class Vehicle
    {
        protected decimal _odometer;
        
        public string TypeOfVehicle { get; set; }
        public string ModelName { get; set; }
        public string LicensePlate { get; set; }
        public string RegistrationDate { get; set; }

        //public Vehicle(string modelName, string licensePlate, string registrationDate)
        //{
        //    ModelName = modelName;
        //    LicensePlate = licensePlate;
        //    RegistrationDate = registrationDate;
        //}

        //public Vehicle()
        //{
        //}

        #region Metoder

        /// <summary>
        /// Sätter värdet på milmätaren.
        /// </summary>
        /// <param name="lengthDriven">Antal mil i decimaler.</param>
        public void SetOdometer(decimal lengthDriven)
        {
            if (lengthDriven > 0)
            {
                _odometer += lengthDriven;
            }
        }

        /// <summary>
        /// Hämtar milmätare.
        /// </summary>
        /// <returns>Decimal</returns>
        public decimal GetOdometer()
        {
            return _odometer;
        }

        /// <summary>
        /// Skriver ut all information om ett fordon.
        /// </summary>
        //public virtual void PrintInfo()
        //{
        //    Console.WriteLine("\t----------");
        //    Console.WriteLine($"Fordonstyp: {TypeOfVehicle}" +
        //        $"\nNamn: {ModelName}" +
        //        $"\nRegistreringsnummer: {LicensePlate}" +
        //        $"\nRegisterades: {RegistrationDate}" +
        //        $"\nMilmätare: {_odometer} mil");
        //}

        /// <summary>
        /// Hämtar vad för typ fordonet är.
        /// </summary>
        /// <returns>Sträng</returns>
        //public string GetVehicleType()
        //{
        //    return TypeOfVehicle;
        //}

        #endregion
    }
}
