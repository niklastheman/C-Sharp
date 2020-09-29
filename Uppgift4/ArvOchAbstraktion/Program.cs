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
                                case 1:
                                    #region Lägg till bil

                                    var car = new Car();
                                    verkstad.AddVehicle(car);

                                    BackToMenu();
                                    break;
                                #endregion

                                case 2:
                                    #region Lägg till motorcykel

                                    var motorcycle = new Motorcycle();
                                    verkstad.AddVehicle(motorcycle);

                                    BackToMenu();
                                    break;
                                #endregion

                                case 3:
                                    #region Lägg till lastbil

                                    var truck = new Truck();
                                    verkstad.AddVehicle(truck);

                                    BackToMenu();
                                    break;
                                #endregion

                                case 4:
                                    #region Lägg till buss

                                    var bus = new Bus();
                                    verkstad.AddVehicle(bus);

                                    BackToMenu();
                                    break;
                                #endregion

                                case 5:
                                    // Tillbaka till huvudmenyn
                                    isAddingVehicle = false;
                                    break;

                                default:
                                    Console.WriteLine("Du måste välja ur något av alternativen.");
                                    BackToMenu();
                                    break;

                            }
                        }
                        break;
                        #endregion

                    case 2:
                        #region Ta bort fordon

                        Console.Clear();
                        Console.WriteLine("---- TA BORT FORDON ----");
                        if (verkstad.ListOfVehicles.Count == 0)
                            Console.WriteLine("Det finns inga fordon inne i verkstaden. ");

                        else
                            verkstad.RemoveVehicle();

                        BackToMenu();
                        #endregion
                        break;

                    case 3:
                        //Skriv ut alla fordon i verkstaden
                        Console.Clear();
                        foreach (var vehicle in verkstad.ListOfVehicles)
                            vehicle.PrintInfo();

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
        /// Skriver ut text och tar emot en inmatning för att "pausa" programmet.
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
