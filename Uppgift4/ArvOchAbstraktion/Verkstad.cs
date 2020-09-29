using Klasser;
using System;
using System.Collections.Generic;
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
        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
                AddCar(vehicle as Car);

            else if (vehicle is Motorcycle)
                AddMotorcycle(vehicle as Motorcycle);

            else if (vehicle is Truck)
                AddTruck(vehicle as Truck);

            else if (vehicle is Bus)
                AddBus(vehicle as Bus);
        }


        /// <summary>
        /// Skriver ut alla fordon i verkstaden och tar bort ett fordon ur verkstaden med hjälp av registreringsnummer.
        /// </summary>
        public void RemoveVehicle()
        {
            Console.WriteLine("Är du säker på att du vill ta bort ett fordon? j/n: ");
            var answer = Console.ReadLine().ToLower();

            if (answer == "j")
            {
                foreach (var vehicle in ListOfVehicles)
                    vehicle.PrintInfo();

                Console.WriteLine("\nSkriv in registreringsnummer på det fordon du vill ta bort: ");
                string licensePlateToMatch = Console.ReadLine().ToUpper();
                licensePlateToMatch = licensePlateToMatch.Replace(" ", ""); // Tar bort whitespace i inmatningen.

                Vehicle vehicleToRemove = null;

                foreach (var vehicle in ListOfVehicles)
                {
                    if (licensePlateToMatch == vehicle.LicensePlate)
                    {
                        vehicleToRemove = vehicle;
                        break;
                    }
                }

                if (vehicleToRemove != null)
                {
                    ListOfVehicles.Remove(vehicleToRemove);
                    Console.WriteLine($"Fordon: {vehicleToRemove.GetVehicleType()} " +
                        $"med registreringsnummer: {vehicleToRemove.LicensePlate}" +
                        $"\nTogs bort från verkstaden.");
                }

                else
                {
                    Console.WriteLine("Hittade inte ett fordon som matchade registreringsnumret.");
                }
            }
        }

        #region Metoder för att lägga till fordon
        private void AddCar(Car car)
        {
            var isAdding = true;
            while (isAdding)
            {
                Console.Clear();
                Console.WriteLine("----LÄGG TILL BIL----");
                car.ModelName = ReadName("Mata in modellnamn: ");
                car.LicensePlate = ReadLicensePlate("Mata in registreringsnummer: ");
                car.RegistrationDate = DateTime.Now.ToString("yyyy/MM/dd");
                car.HasTowbar = ReadBool("Har bilen en dragkrok? j/n: ");

                var lengthDriven = ReadDecimal("Mata in hur många mil fordonet har gått: ");
                car.SetOdometer(lengthDriven);

                car.PrintInfo();
                var isAnswering = true;
                do
                {
                    Console.Write("\nStämmer dessa uppgifter? j/n: ");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "j")
                    {
                        isAdding = false;
                        isAnswering = false;
                        ListOfVehicles.Add(car);
                        Console.WriteLine("\nBil tillagd!");
                        break;
                    }

                    else if (string.IsNullOrEmpty(answer))
                        Console.WriteLine("Du måste svara.");
                } while (isAnswering);
            }
        }

        private void AddMotorcycle(Motorcycle motorcycle)
        {
            var isAdding = true;
            while (isAdding)
            {
                Console.Clear();
                Console.WriteLine("----LÄGG TILL MOTORCYKEL----");
                motorcycle.ModelName = ReadName("Mata in modellnamn: ");
                motorcycle.LicensePlate = ReadLicensePlate("Mata in registreringsnummer: ");
                motorcycle.RegistrationDate = DateTime.Now.ToString("yyyy/MM/dd");
                motorcycle.MaxSpeed = ReadInteger("Mata in maxhastighet i km/h: ");

                var lengthDriven = ReadDecimal("Mata in hur många mil fordonet har gått: ");
                motorcycle.SetOdometer(lengthDriven);

                motorcycle.PrintInfo();
                var isAnswering = true;
                do
                {
                    Console.Write("\nStämmer dessa uppgifter? j/n: ");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "j")
                    {
                        isAdding = false;
                        isAnswering = false;
                        ListOfVehicles.Add(motorcycle);
                        Console.WriteLine("\nMotorcykel tillagd!");
                        break;
                    }

                    else if (string.IsNullOrEmpty(answer))
                        Console.WriteLine("Du måste svara.");
                } while (isAnswering);
                
            }
        }

        private void AddTruck(Truck truck)
        {
            var isAdding = true;
            while (isAdding)
            {
                Console.Clear();
                Console.WriteLine("----LÄGG TILL LASTBIL----");
                truck.ModelName = ReadName("Mata in modellnamn: ");
                truck.LicensePlate = ReadLicensePlate("Mata in registreringsnummer: ");
                truck.RegistrationDate = DateTime.Now.ToString("yyyy/MM/dd");
                truck.MaxLoadInKG = ReadInteger("Mata in maxlast i kg: ");

                var lengthDriven = ReadDecimal("Mata in hur många mil fordonet har gått: ");
                truck.SetOdometer(lengthDriven);

                truck.PrintInfo();
                var isAnswering = true;
                do
                {
                    Console.Write("\nStämmer dessa uppgifter? j/n: ");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "j")
                    {
                        isAdding = false;
                        isAnswering = false;
                        ListOfVehicles.Add(truck);
                        Console.WriteLine("\nLastbil tillagd!");
                        break;
                    }

                    else if (string.IsNullOrEmpty(answer))
                        Console.WriteLine("Du måste svara.");

                    else
                    {
                        isAnswering = false;
                        break;
                    }
                } while (isAnswering);
            }
        }

        private void AddBus(Bus bus)
        {
            var isAdding = true;
            while (isAdding)
            {
                Console.Clear();
                Console.WriteLine("----LÄGG TILL BUSS----");
                bus.ModelName = ReadName("Mata in modellnamn: ");
                bus.LicensePlate = ReadLicensePlate("Mata in registreringsnummer: ");
                bus.RegistrationDate = DateTime.Now.ToString("yyyy/MM/dd");
                bus.MaxAmountOfPassengers = ReadInteger("Mata in max antal passagerare: ");

                var lengthDriven = ReadDecimal("Mata in hur många mil fordonet har gått: ");
                bus.SetOdometer(lengthDriven);

                bus.PrintInfo();
                var isAnswering = true;
                do
                {
                    Console.Write("\nStämmer dessa uppgifter? j/n: ");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "j")
                    {
                        isAdding = false;
                        isAnswering = false;
                        ListOfVehicles.Add(bus);
                        Console.WriteLine("\nBuss tillagd!");
                        break;
                    }

                    else if (string.IsNullOrEmpty(answer))
                        Console.WriteLine("Du måste svara.");

                    else
                    {
                        isAnswering = false;
                        break;
                    }
                } while (isAnswering);
            }
        }
        #endregion

        #region Metoder för inmatning
        /// <summary>
        /// Skriver ut en fråga i konsolen, användaren matar in svaret som returneras i string.
        /// </summary>
        /// <param name="whatToWrite">Vad konsolen ska skriva ut för fråga</param>
        /// <returns>String</returns>
        private string ReadName(string whatToWrite)
        {
            string name;
            var isSettingName = true;
            do
            {
                Console.Write(whatToWrite);
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    Console.WriteLine("Du måste mata in något.");

                else
                    isSettingName = false;

            } while (isSettingName);

            return name;
        }

        /// <summary>
        /// Skriver ut en fråga i konsolen, användaren matar in svaret som returneras i string i <b>versaler</b>
        /// </summary>
        /// <param name="whatToWrite"></param>
        /// <returns></returns>
        private string ReadLicensePlate(string whatToWrite)
        {
            string licensePlate;
            var isSettingLicensePlate = true;
            do
            {
                Console.Write(whatToWrite);
                licensePlate = Console.ReadLine().ToUpper();
                licensePlate = licensePlate.Replace(" ", "");
                if (string.IsNullOrEmpty(licensePlate))
                    Console.WriteLine("Du måste mata in något.");

                else
                    isSettingLicensePlate = false;

            } while (isSettingLicensePlate);

            return licensePlate;
        }

        /// <summary>
        /// Skriver ut en fråga i konsolen, användaren matar in svaret som returneras i bool.
        /// </summary>
        /// <param name="whatToWrite">Vad konsolen ska skriva ut för fråga</param>
        /// <returns>True/false</returns>
        private bool ReadBool(string whatToWriteWithJorNquestion)
        {

            bool hasSomething = false;
            var isSettingBool = true;
            do
            {
                Console.Write(whatToWriteWithJorNquestion);
                var answer = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(answer))
                    Console.WriteLine("Du måste svara på frågan.");

                else
                {
                    hasSomething = (answer == "j");
                    isSettingBool = false;
                }

            } while (isSettingBool);

            return hasSomething;
        }

        /// <summary>
        /// Skriver ut en fråga i konsolen, användaren matar in svaret som returneras i integer.
        /// </summary>
        /// <param name="whatToWrite">Vad konsolen ska skriva ut för fråga</param>
        /// <returns>Integer</returns>
        private int ReadInteger(string whatToWrite)
        {
            int valueToSet = 0;
            var isSettingInt = true;
            do
            {
                Console.Write(whatToWrite);
                if (!int.TryParse(Console.ReadLine(), out valueToSet))
                    Console.WriteLine("Du måste mata in ett heltal.");

                else if (valueToSet < 0)
                    Console.WriteLine("Värdet kan inte vara minus.");

                else
                    isSettingInt = false;

            } while (isSettingInt);

            return valueToSet;
        }

        /// <summary>
        /// Skriver ut en fråga i konsolen, användaren matar in svaret som returneras i decimal.
        /// </summary>
        /// <param name="whatToWrite">Vad konsolen ska skriva ut för fråga</param>
        /// <returns>Decimaltal</returns>
        private decimal ReadDecimal(string whatToWrite)
        {
            decimal valueToSet = 0;
            var IsSettingDecimal = true;
            do
            {
                Console.Write(whatToWrite);
                if (!Decimal.TryParse(Console.ReadLine(), out valueToSet))
                    Console.WriteLine("Du måste mata in ett tal.");

                else if (valueToSet < 0)
                    Console.WriteLine("Värdet kan inte vara minus.");

                else
                    IsSettingDecimal = false;

            } while (IsSettingDecimal);

            return valueToSet;
        }
        #endregion

    }
}
