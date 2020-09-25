using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Klasser
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Skapar fyra objekt av klassen Bil
            Car BMW = new Car("BMW Z3",
                1000,
                DateTime.Now.ToString("yyyy/MM/dd"),
                "ABC123",
                false);
            Car Tesla = new Car("Tesla s-series",
                920,
                DateTime.Now.ToString("yyyy/MM/dd"),
                "DEF456",
                true);
            Car Volkswagen = new Car("Volskwagen Passat",
                1100,
                DateTime.Now.ToString("yyyy/MM/dd"),
                "GHI789",
                false);
            Car Chevrolet = new Car("Chevrolet Volt",
                1150,
                DateTime.Now.ToString("yyyy/MM/dd"),
                "JKL101",
                true);
            #endregion

            // Skapar lista för de skapade bil-objekten
            List<Car> listOfCars = new List<Car>();
            #region Lägger till de skapade objekten i listan
            listOfCars.Add(BMW);
            listOfCars.Add(Tesla);
            listOfCars.Add(Volkswagen);
            listOfCars.Add(Chevrolet);
            #endregion


            #region Skriver ut de skapade objekten
            Console.WriteLine("Skapade objekt innan programmet körs: ");
            PrintCars(listOfCars);

            Console.WriteLine("\n\tTryck på en knapp för att fortsätta...");
            Console.ReadKey();
            Console.Clear();

            // Tar bort alla element i listan
            listOfCars.Clear();
            #endregion

            // Lista som tar emot objekt av klassen Person
            List<Person> listOfUsers = new List<Person>();

            // Start av huvudprogram (skapa obegränsat antal personer och tilldela bilar till dem)
            var isAddingPersons = true;
            do
            {
                #region Samlar in data om användaren
                Console.WriteLine("\n\t----- LÄGG TILL PERSON -----");
                var userName = SetName("Mata in namn: ");
                var userAge = SetAgeOrWeight("Mata in ålder: ");

                Person user = new Person(userName, userAge); // Skapar objekt av klassen Person
                listOfUsers.Add(user); // Lägger till user i lista med användare.
                #endregion

                var isAddingCars = true;
                do
                {
                    #region Samlar in data om bilen
                    Console.WriteLine($"\n\t----- REGISTRERA BIL TILL ANVÄNDARE \"{user.GetName().ToUpper()}\" -----");
                    var modelName = SetName("Mata in modell: ");
                    var weight = SetAgeOrWeight("Mata in vikt: ");
                    var licensePlate = SetLicensePlate("Mata in registreringsnummer: ");
                    var isElectric = SetBool("Är det en elbil? j/n: ");
                    var registered = DateTime.Now.ToString("yyyy/MM/dd"); // Registrering av fordon sker när applikationen körs
                    #endregion

                    // Skapar nytt objekt av klassen car.
                    Car car = new Car(modelName, weight, registered, licensePlate, isElectric);
                    user.Cars.Add(car); // Lägger in car i användarlistan Cars

                    // Om användaren inte vill registrera fler bilar så frågar vi om den vill lägga till fler personer
                    // Om inte, skriv ut all data vi har och avsluta.
                    Console.Write($"Vill du registrera fler bilar till {user.GetName()}? j/n: ");
                    var answer = Console.ReadLine().ToLower();
                    if (answer != "j")
                    {
                        isAddingCars = false;

                        Console.Write("Vill du lägga till fler personer? j/n: ");
                        answer = Console.ReadLine().ToLower();
                        if (answer != "j")
                            isAddingPersons = false;

                        else
                            break;
                    }

                } while (isAddingCars);

            } while (isAddingPersons);

            PrintUsersAndCars(listOfUsers);
            Console.ReadKey(); // Avslutar program
        }

        #region Metoder

        /// <summary>
        /// Skriver ut alla bilar som finns i en lista.
        /// </summary>
        /// <param name="listOfCars">Lista med bilar som ska skrivas ut.</param>
        public static void PrintCars(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)
                car.GetInfo();
        }

        /// <summary>
        /// Skriver ut alla personer och bilarna de äger.
        /// </summary>
        /// <param name="listOfUsers">Lista med användare.</param>
        public static void PrintUsersAndCars(List<Person> listOfUsers)
        {
            foreach (var user in listOfUsers)
            {
                Console.WriteLine($"\n\t{user.GetName()} är {user.GetAge()} år gammal och äger dessa bilar:");

                foreach (var car in user.Cars)
                {
                    car.GetInfo();
                }
            }
        }
        /// <summary>
        /// Frågar användaren om vad som ska matas in och sätter ett <b>strängvärde</b>, och tvingar bokstäverna till <b>upper-case</b>.
        /// </summary>
        /// <param name="question">Frågan som ska ställas till användaren.</param>
        /// <returns>String</returns>
        public static string SetLicensePlate(string question)
        {
            var isInputting = true;
            string licensePlate;
            do
            {
                Console.Write(question);
                licensePlate = Console.ReadLine().ToUpper();
                if (String.IsNullOrEmpty(licensePlate))
                    Console.WriteLine("Du måste mata in något!");

                else
                    isInputting = false;

            } while (isInputting);

            return licensePlate;
        }

        /// <summary>
        /// Frågar användaren om vad som ska matas in och sätter ett <b>heltal</b>.
        /// </summary>
        /// <param name="question">Frågan som ska ställas till användaren</param>
        /// <returns>Integer</returns>
        public static int SetAgeOrWeight(string question)
        {
            var isInputting = true;
            int ageOrWeight;
            do
            {
                Console.Write(question);
                if (!int.TryParse(Console.ReadLine(), out ageOrWeight))
                    Console.WriteLine("Du måste mata in ett heltal!");

                else
                    isInputting = false;


            } while (isInputting);

            return ageOrWeight;
        }

        /// <summary>
        /// Frågar användaren om vad som ska matas in och sätter ett <b>strängvärde</b>
        /// </summary>
        /// <param name="question">Frågan som ska ställas till användaren</param>
        /// <returns>String</returns>
        public static string SetName(string question)
        {
            var isInputting = true;
            string name;
            do
            {
                Console.Write(question);
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                    Console.WriteLine("Du matade inte in något!");

                else
                    isInputting = false;

            } while (isInputting);

            return name;
        }
        /// <summary>
        /// Frågar användaren och returnerar ett <b>bool-värde</b>.
        /// </summary>
        /// <param name="questionJorN">Frågan som ska ställas. <b>Frågan måste innehålla j/n</b> </param>
        /// <returns>Boolean</returns>
        public static bool SetBool(string questionJorN)
        {

            Console.Write(questionJorN);
            var answer = Console.ReadLine().ToLower();

            // Om svar är j/J så sätts electric till true.
            var electric = (answer == "j");
            return electric;
        }
        #endregion
    }

}