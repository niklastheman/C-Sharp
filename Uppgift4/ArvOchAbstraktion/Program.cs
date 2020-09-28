using Klasser;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ArvOchAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            Verkstad verkstad = new Verkstad();

            var isRunning = true;
            while (isRunning)
            {
                PrintMainMenu();
                int.TryParse(Console.ReadLine(), out int menuInput);

                switch (menuInput)
                {

                    case 1:
                        #region Lägg till fordon

                        var isAddingVehicle = true;
                        while (isAddingVehicle)
                        {
                            PrintAddVehicleMenu();
                            int.TryParse(Console.ReadLine(), out menuInput);

                            switch (menuInput)
                            {
                                // Bil
                                case 1:
                                    #region Lägg till bil

                                    var car = new Car();
                                    verkstad.AddVehicle(car);

                                    BackToMenu();
                                    break;
                                #endregion

                                // Motorcykel
                                case 2:
                                    #region Lägg till motorcykel

                                    var motorcycle = new Motorcycle();
                                    verkstad.AddVehicle(motorcycle);

                                    BackToMenu();
                                    break;
                                #endregion

                                //Lastbil
                                case 3:
                                    #region Lägg till lastbil

                                    var truck = new Truck();
                                    verkstad.AddVehicle(truck);

                                    BackToMenu();
                                    break;
                                #endregion

                                //Buss
                                case 4:
                                    #region Lägg till buss

                                    var bus = new Bus();
                                    verkstad.AddVehicle(bus);

                                    BackToMenu();
                                    break;
                                #endregion

                                //Tillbaka till huvudmenyn
                                case 5:
                                    isAddingVehicle = false;
                                    break;

                                default:
                                    Console.WriteLine("Du måste välja ur något av alternativen.");
                                    BackToMenu();
                                    break;

                            }
                        }
                        #endregion
                        break;

                    case 2:
                        #region Ta bort fordon

                        foreach (var vehicle in verkstad.ListOfVehicles)
                        {
                            Console.WriteLine($"\nFordonstyp: {vehicle.GetVehicleType()}" +
                                $"\nModell: {vehicle.ModelName}" +
                                $"\nRegistreringsnummer: {vehicle.LicensePlate}");
                        }

                        Console.WriteLine("\nSkriv in registreringsnummer på det fordon du vill ta bort: ");
                        string licensePlateToMatch = Console.ReadLine().ToUpper();
                        licensePlateToMatch = licensePlateToMatch.Replace(" ", "");

                        Vehicle vehicleToRemove = null;

                        foreach (var vehicle in verkstad.ListOfVehicles)
                        {
                            if (licensePlateToMatch == vehicle.LicensePlate)
                            {
                                vehicleToRemove = vehicle;
                                break;
                            }
                        }

                        if (vehicleToRemove != null)
                        {
                            verkstad.ListOfVehicles.Remove(vehicleToRemove);
                            Console.WriteLine($"Tog bort fordonet av typen {vehicleToRemove.GetVehicleType()} " +
                                $"med registreringsnummer {vehicleToRemove.LicensePlate}");
                        }

                        else
                        {
                            Console.WriteLine("Hittade inte ett fordon som matchade registreringsnumret.");
                        }

                        BackToMenu();
                        #endregion
                        break;

                    case 3:
                        //Skriv ut alla fordon i verkstaden
                        foreach (var vehicle in verkstad.ListOfVehicles)
                        {
                            vehicle.PrintInfo();
                        }


                        BackToMenu();
                        break;

                    case 4:
                        #region Avsluta program
                        Console.WriteLine("Avslutar program...");
                        Thread.Sleep(1000);
                        isRunning = false;
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Du måste välja ur alternativen.");
                        BackToMenu();
                        break;
                }
            }


        }

        #region Metoder för menyer
        /// <summary>
        /// Går tillbaka till menyn
        /// </summary>
        static void BackToMenu()
        {
            Console.WriteLine("\nTryck på enter för att fortsätta...");
            Console.ReadKey();
        }

        /// <summary>
        /// Skriver ut huvudmeny
        /// </summary>
        static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("----VÄLKOMMEN TILL VERKSTADEN----");
            Console.WriteLine("[1] Lägg till fordon" +
                "\n[2] Ta bort fordon" +
                "\n[3] Skriv ut alla fordon i verkstaden" +
                "\n[4] Avsluta program");
        }

        /// <summary>
        /// Skriver ut menyn där användaren lägger till fordon i verkstaden.
        /// </summary>
        static void PrintAddVehicleMenu()
        {
            Console.Clear();
            Console.WriteLine("Vad för typ av fordon vill du lägga till?" +
                            "\n[1] Bil" +
                            "\n[2] Motorcykel" +
                            "\n[3] Lastbil" +
                            "\n[4] Buss" +
                            "\n[5] Tillbaka till huvudmenyn");
        }
        #endregion

    }
}
