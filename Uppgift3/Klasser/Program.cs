using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Klasser
{
    class Program
    {

        static void Main(string[] args)
        {
            // Skapar fyra objekt av klassen Bil
            Car BMW = new Car("BMW Z3")
            {
                WeightInKG = 1000,
                Registered = DateTime.Now.ToString("yyyy/MM/dd"),
                Electric = false,
                LicensePlate = "ABC123"
            };
            Car Tesla = new Car("Tesla s-series")
            {
                WeightInKG = 920,
                Registered = DateTime.Now.ToString("yyyy/MM/dd"),
                Electric = true,
                LicensePlate = "DEF456"
            };
            Car Volkswagen = new Car("Volskwagen Passat")
            {
                WeightInKG = 1100,
                Registered = DateTime.Now.ToString("yyyy/MM/dd"),
                Electric = false,
                LicensePlate = "GHI789"
            };
            Car Chevrolet = new Car("Chevrolet Volt")
            {
                WeightInKG = 1150,
                Registered = DateTime.Now.ToString("yyyy/MM/dd"),
                Electric = true,
                LicensePlate = "JKL101"
            };

            // Lista för de skapade objekten
            List<Car> listOfCars = new List<Car>();
            // Lägger till de skapade objekten i listan
            listOfCars.Add(BMW);
            listOfCars.Add(Tesla);
            listOfCars.Add(Volkswagen);
            listOfCars.Add(Chevrolet);

            // Skriver ut de skapade objekten
            Console.WriteLine("Skapade objekt innan programmet körs: ");
            PrintCars(listOfCars);

            Console.WriteLine("\n\tTryck på en knapp för att fortsätta...");
            Console.ReadKey();
            Console.Clear();

            // Tar bort alla element i listan
            listOfCars.Clear();

            // Lista som tar emot objekt av klassen Person
            List<Person> listOfUsers = new List<Person>();
            
            // Start av huvudprogram (skapa obegränsat antal personer och tilldela bilar till dem)
            var isAddingPersons = true;
            do
            {
                Console.WriteLine("\n\t----- LÄGG TILL PERSON -----");
                var userName = SetName("Mata in namn: ");
                var userAge = SetAgeOrWeight("Mata in ålder: ");

                // Skapar objekt av klassen Person
                Person user = new Person(userName, userAge);
                // Lägger till user i lista med användare.
                listOfUsers.Add(user);

                var isAddingCars = true;
                do
                {
                    Console.WriteLine($"\n\t----- REGISTRERA BIL TILL ANVÄNDARE \"{user.GetName().ToUpper()}\" -----");
                    var modelName = SetName("Mata in modell: ");
                    var weight = SetAgeOrWeight("Mata in vikt: ");
                    var licensePlate = SetLicensePlate("Mata in registreringsnummer: ");
                    var isElectric = SetBool("Är det en elbil? j/n: ");
                    var registered = DateTime.Now.ToString("yyyy/MM/dd"); // Registrering av fordon sker när applikationen körs

                    // Skapar nytt objekt av klassen car.
                    Car car = new Car(modelName, weight, registered, licensePlate, isElectric);

                    // Lägger in car i användarlistan Cars
                    user.Cars.Add(car);

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

        


        // Metoder
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

    }

    public class Car
    {
        // Fields
        public string _model;
        private decimal _odometer;

        // Properties
        public int WeightInKG { get; set; }
        public string Registered { get; set; }
        public bool Electric { get; set; }
        public string LicensePlate { get; set; }

        /// <summary>
        /// Adderar hur långt ett fordon har kört till milmätaren.
        /// </summary>
        /// <param name="lengthDriven">Hur långt fordonet har kört</param>
        public void SetOdometer(decimal lengthDriven)
        {
            if (lengthDriven > 0)
            {
                _odometer += lengthDriven;
            }
            
        }

        /// <summary>
        /// Hämtar milmätaren och omvandlar till <b>string</b>.
        /// </summary>
        /// <returns>String</returns>
        public string GetOdometer()
        {
            return _odometer.ToString();
        }

        /// <summary>
        /// Skriver ut all information om en bil.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Modell: {_model}");
            Console.WriteLine($"Vikt: {WeightInKG}kg");
            Console.WriteLine($"Registrerades: {Registered}");
            Console.WriteLine($"Registreringsnummer: {LicensePlate}");
            if (Electric)
                Console.WriteLine("\"Detta är en elbil!\"");
        }

        /// <summary>
        /// Sätter modellen på bilen.
        /// </summary>
        /// <param name="modelname">Modellnamn.</param>
        public Car(string modelname)
        {
            _model = modelname;
        }

        /// <summary>
        /// Sätter alla uppgifter om en bil.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="weight"></param>
        /// <param name="registered"></param>
        /// <param name="licenseplate"></param>
        /// <param name="electric"></param>
        public Car(string model, int weight,
            string registered,
            string licenseplate,
            bool electric)
        {
            this._model = model;
            this.WeightInKG = weight;
            this.Registered = registered;
            this.LicensePlate = licenseplate;
            this.Electric = electric;
        }

    }

    public class Person
    {
        private string name;
        private int age;
        public List<Car> Cars { get; set; }

        /// <summary>
        /// Hämtar en persons namn
        /// </summary>
        /// <returns>String</returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Hämtar en persons ålder
        /// </summary>
        /// <returns>Integer</returns>
        public int GetAge()
        {
            return age;
        }

        
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Cars = new List<Car>();
        }

    }

}