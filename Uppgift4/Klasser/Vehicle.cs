using System;

namespace Klasser
{
    public abstract class Vehicle
    {
        protected decimal _odometer;
        
        protected string _typeOfVehicle;
        public string ModelName { get; set; }
        public string LicensePlate { get; set; }
        public string RegistrationDate { get; set; }

        public Vehicle(string modelName, string licensePlate, string registrationDate)
        {
            ModelName = modelName;
            LicensePlate = licensePlate;
            RegistrationDate = registrationDate;
        }

        public Vehicle()
        {

        }
        
        public void SetOdometer(decimal lengthDriven)
        {
            if (lengthDriven > 0)
            {
                _odometer += lengthDriven;
            }
        }

        public decimal GetOdometer()
        {
            return _odometer;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("\t----------");
            Console.WriteLine($"Typ av fordon: {_typeOfVehicle}" +
                $"\nNamn: {ModelName}" +
                $"\nRegistreringsnummer: {LicensePlate}" +
                $"\nRegisterades: {RegistrationDate}" +
                $"\nMilmätare: {_odometer} mil");
        }

        public string GetVehicleType()
        {
            return _typeOfVehicle;
        }

    }
}
