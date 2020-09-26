using Ovning_6.Entities;
using System;
using System.Collections.Generic;

namespace Ovning_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till husdjurs applikationen!");
            Console.WriteLine("Vänligen ange era djur:");

            List<Animal> animals = new List<Animal>();

            bool userHasEnteredAllAnimals = false;

            while (userHasEnteredAllAnimals == false)
            {

                Console.Write("Önskas skriva in ett djur? (j/n): ");

                string response = Console.ReadLine();

                if (string.IsNullOrEmpty(response) == false)
                {

                    response = response.ToLower();
                }
                else
                {
                    response = string.Empty;
                }

                if (response != "n")
                {
                    Animal animal = GetInformationOfAnimal();

                    if (animal == null)
                    {

                        Console.Write("Du angav något lite knasigt, försök igen!");
                        continue;
                    }
                    animals.Add(animal);
                }
                else
                {
                    userHasEnteredAllAnimals = true;
                }
            }

            bool userIsCommunicatingWithAnimals = true;

            while (userIsCommunicatingWithAnimals == true)
            {

                Console.Write("(Alla djuren i kör) Vad ska vi göra nu?!?! namn/ålder/äta/springa: ");

                string response = Console.ReadLine();

                //response = response?.ToLower() ?? string.Empty; //går även att skriva så här för er som tycker det är coolt...

                if (string.IsNullOrEmpty(response) == false)
                {
                    response = response.ToLower();
                }
                else
                {
                    response = string.Empty;
                }

                switch (response)
                {
                    case "namn":
                        WriteAllNames(animals);
                        break;
                    case "ålder":
                        WriteAllAges(animals);
                        break;
                    case "äta":
                        WriteAllEat(animals);
                        break;
                    case "springa":
                        WriteAllRun(animals);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void WriteAllRun(List<Animal> animals)
        {
            int animalNr = 1;

            foreach (var animal in animals)
            {
                Console.WriteLine($"Djur nr {animalNr} springer: ");
                animal.Run();
                animalNr++;
            }
        }

        private static void WriteAllEat(List<Animal> animals)
        {
            int animalNr = 1;

            foreach (var animal in animals)
            {
                Console.WriteLine($"Djur nr {animalNr} 'äter: ");
                animal.Eat();
                animalNr++;
            }
        }

        private static void WriteAllAges(List<Animal> animals)
        {
            int animalNr = 1;

            foreach (var animal in animals)
            {
                int ageOfAnimal = animal.GetAge();
                Console.WriteLine($"Djur nr {animalNr} omräknade ålder är: {ageOfAnimal}");
                animalNr++;
            }
        }

        private static void WriteAllNames(List<Animal> animals)
        {
            int animalNr = 1;

            foreach (var animal in animals)
            {
                Console.WriteLine($"Djur nr {animalNr} heter: {animal.Name}");
                animalNr++;
            }
        }

        private static Animal GetInformationOfAnimal()
        {

            Console.Write("Vilken art? hund/katt/kanin: ");
            string responseSpecies = Console.ReadLine();
            responseSpecies = responseSpecies.ToLower();

            Animal animal;

            switch (responseSpecies)
            {
                case "hund":
                    animal = new Dog();
                    break;
                case "katt":
                    animal = new Cat();
                    break;
                case "kanin":
                    animal = new Rabbit();
                    break;
                default:
                    return null;
            }

            Console.Write("Vad heter djuret?: ");
            string responseName = Console.ReadLine();

            animal.Name = responseName;

            Console.Write("Hur gammal är djuret: ");
            string responseAge = Console.ReadLine();

            bool parsedSuccefully = int.TryParse(responseAge, out int age);

            if (parsedSuccefully == true)
            {

                animal.Age = age;
            }
            else
            {

                return null;
            }

            return animal;
        }
    }
}
