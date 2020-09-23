using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Klasser
{
    class Program
    {

        static void Main(string[] args)
        {
            // Variabler för användare
            string userName;
            int userAge;

            // Variabler för bil
            string modelName, licensePlate;
            int weight;
            bool electric = false,
                isAddingPersons = true,
                isAddingCars;
            string registered;

            string answer;

            // Skapar fyra objekt av klassen Bil
            Car BMW = new Car("BMW Z3")
            {
                Weight = 100,
                Registered = DateTime.Now.ToString("yyyy/MM/dd"),
                Electric = false,
                LicensePlate = "ABC123"
            };
            Car Tesla = new Car("Tesla s-series")
            {
                Weight = 92,
                Registered = DateTime.Now.ToShortDateString(),
                Electric = true,
                LicensePlate = "DEF456"
            };
            Car Volkswagen = new Car("Volskwagen Passat")
            {
                Weight = 110,
                Registered = DateTime.Now.ToShortDateString(),
                Electric = false,
                LicensePlate = "GHI789"
            };
            Car Chevrolet = new Car("Chevrolet")
            {
                Weight = 115,
                Registered = DateTime.Now.ToShortDateString(),
                Electric = true,
                LicensePlate = "JKL101"
            };

            // Lista för de skapade objekten ovanför
            List<Car> listOfCars = new List<Car>();
            // Lägger till de skapade objekten i listan
            listOfCars.Add(BMW);
            listOfCars.Add(Tesla);
            listOfCars.Add(Volkswagen);
            listOfCars.Add(Chevrolet);

            // Skriver ut de skapade objekten
            Console.WriteLine("Skapade objekt innan programmet körs: ");
            PrintCars(listOfCars);

            // Tar bort alla element i listan
            listOfCars.Clear();

            // Lista som tar emot klassen Person
            List<Person> listOfUsers = new List<Person>();

            do
            {
                Console.WriteLine("\n\t----- LÄGG TILL PERSON -----");

                Console.Write("Mata in användarnamn: ");
                userName = Console.ReadLine();
                Console.Write("Mata in ålder: ");
                int.TryParse(Console.ReadLine(), out userAge);

                // Skapar objekt av person-klassen
                Person user = new Person(userName, userAge);
                // Lägger till user i lista med användare.
                listOfUsers.Add(user);

                isAddingCars = true;
                do
                {
                    Console.WriteLine($"\n\t----- REGISTRERA BIL TILL ANVÄNDARE {user.GetName().ToUpper()} -----");

                    Console.Write("Mata in modell: ");
                    modelName = Console.ReadLine();

                    Console.Write("Mata in vikt: ");
                    weight = int.Parse(Console.ReadLine());

                    // Registrering av fordon sker när applikationen körs
                    registered = DateTime.Now.ToShortDateString();

                    Console.Write("Mata in registreringsnummer: ");
                    licensePlate = Console.ReadLine().ToUpper();

                    Console.Write("Är det en elbil? j/n: ");
                    answer = Console.ReadLine().ToLower();
                    // Om svar är j/J så sätts electric till true.
                    electric = answer == "j";

                    // Skapar nytt objekt av klassen car.
                    Car car = new Car(modelName, weight, registered, licensePlate, electric);


                    // Lägger in car i listan Cars
                    user.Cars.Add(car);

                    Console.Write($"Vill du registrera fler bilar till {user.GetName()}? j/n: ");
                    answer = Console.ReadLine().ToLower();
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
            Console.ReadKey();
        }




        /// <summary>
        /// Skriver ut alla bilar som finns i en lista.
        /// </summary>
        /// <param name="listOfCars">Lista med bilar som ska skrivas ut.</param>
        static void PrintCars(List<Car> listOfCars)
        {
            foreach (var cars in listOfCars)
                cars.GetInfo();
        }

        /// <summary>
        /// Skriver ut alla personer och bilarna de äger.
        /// </summary>
        /// <param name="listOfUsers">Lista med användare</param>
        static void PrintUsersAndCars(List<Person> listOfUsers)
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


    }

    public class Car    
    {
        // Fields
        private string model;
        private double odometer;

        // Properties
        public int Weight { get; set; }
        public string Registered { get; set; }
        public bool Electric { get; set; }
        public string LicensePlate { get; set; }

        /// <summary>
        /// Adderar hur långt ett fordon har kört till milmätaren.
        /// </summary>
        /// <param name="lengthDriven">Hur långt fordonet har kört</param>
        public void SetOdometer(double lengthDriven)
        {
            if (lengthDriven > 0)
            {
                odometer += lengthDriven;
            }
            
        }

        /// <summary>
        /// Hämtar milmätare.
        /// </summary>
        /// <returns></returns>
        public string GetOdometer()
        {
            return odometer.ToString();
        }

        /// <summary>
        /// Skriver ut all information om en bil.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Modell: {model}");
            Console.WriteLine($"Vikt: {Weight}");
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
            this.model = modelname;
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
            this.model = model;
            this.Weight = weight;
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
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Hämtar en persons ålder
        /// </summary>
        /// <returns></returns>
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