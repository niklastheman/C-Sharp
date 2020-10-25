using Klasser;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ArvOchAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            IVerkstad verkstad = new Verkstad();


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

                                    Console.WriteLine("----LÄGG TILL BIL");
                                    Car car = new Car();
                                    InputHelper.CreateVehicle(car);
                                    verkstad.AddVehicle(car);

                                    Console.WriteLine("\nBil tillagd i verkstaden!");

                                    BackToMenu();
                                    break;
                                #endregion

                                case 2:
                                    #region Lägg till motorcykel

                                    Console.WriteLine("----LÄGG TILL MOTORCYKEL----");

                                    var motorcycle = InputHelper.CreateMotorcycle();
                                    var tryToAddVehicle = verkstad.AddVehicle(motorcycle);
                                    if (tryToAddVehicle)
                                        Console.WriteLine("\nMotorcykel tillagd i verkstaden!");

                                    // Den här koden körs endast i VerkstadV2 klassen
                                    else
                                        Console.WriteLine("\nDen här verkstaden kan bara ta emot mopeder. De får ha en maxhastighet på 50km/h.");

                                    BackToMenu();
                                    break;
                                #endregion

                                case 3:
                                    #region Lägg till lastbil

                                    Console.WriteLine("----LÄGG TILL LASTBIL----");

                                    var truck = InputHelper.CreateTruck();
                                    tryToAddVehicle = verkstad.AddVehicle(truck);

                                    if (tryToAddVehicle)
                                        Console.WriteLine("\nLastbil tillagd i verkstaden!");

                                    // Den här koden körs endast i VerkstadV2 klassen
                                    else
                                        Console.WriteLine("\nDen här verkstaden tar bara emot lätta lastbilar vars maxlast är 2 ton.");

                                    BackToMenu();
                                    break;
                                #endregion

                                case 4:
                                    #region Lägg till buss

                                    Console.WriteLine("----LÄGG TILL BUSS----");

                                    var bus = InputHelper.CreateBus();
                                    tryToAddVehicle = verkstad.AddVehicle(bus);

                                    if (tryToAddVehicle)
                                        Console.WriteLine("\nBuss tillagd i verkstaden!");

                                    // Den här koden körs endast i VerkstadV2 klassen
                                    else
                                        Console.WriteLine("\nDen här verkstaden tar bara emot minibussar. Max antal passagerare får vara 8 st.");

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

                        if (verkstad.GetListOfVehicles().Count == 0)
                            Console.WriteLine("Det finns inga fordon i verkstaden.");

                        else
                        {
                            var vehicleToRemove = InputHelper.FindVehicleToRemove(verkstad);

                            if (vehicleToRemove != null)
                                verkstad.RemoveVehicle(vehicleToRemove);

                        }

                        BackToMenu();
                        #endregion
                        break;

                    case 3:
                        //Skriv ut alla fordon i verkstaden
                        Console.Clear();

                        if (verkstad.GetListOfVehicles().Count == 0)
                            Console.WriteLine("Det finns inga fordon i verkstaden.");

                        else
                            foreach (var vehicle in verkstad.GetListOfVehicles())
                                InputHelper.PrintInfo(vehicle);

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




        #region Metoder för utskrift
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

        //public static string PropertyList(this object obj)
        //{
        //    var properties = obj.GetType().GetProperties();

        //    var stringBuilder = new StringBuilder();
        //    foreach (var prop in properties)
        //    {
        //        stringBuilder.AppendLine($"{prop.Name}: {prop.GetValue(obj, null)}");
        //    }

        //    return stringBuilder.ToString();
        //}

        #endregion
    }
}
