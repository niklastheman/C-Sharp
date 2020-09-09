using System;
using System.Collections.Generic;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Bil> Billista = new List<Bil>();

            Bil BMW = new Bil
            {
                Model = "BMW Z3",
                Vikt = 100,
                Registrerades = DateTime.Now,
                Elbil = false,
                Registreringsnummer = "ABC 123"
            };

            Bil Tesla = new Bil
            {
                Model = "Tesla S-Series",
                Vikt = 92,
                Registrerades = DateTime.Now.ToString("2018-11-22"),
                Elbil = true,
                Registreringsnummer = "DEF 456"
            };

            Bil Volkswagen = new Bil
            {
                Model = "Volkswagen Passat",
                Vikt = 110,
                Registrerades = DateTime.Now,
                Elbil = false,
                Registreringsnummer = "GHI 789"
            };

            Billista.Add(BMW);
            Billista.Add(Tesla);
            Billista.Add(Volkswagen);

            foreach (var Bil in Billista)
            {
                Console.WriteLine();
                Console.WriteLine($"Model: {Bil.Model}");
                Console.WriteLine($"Vikt: {Bil.Vikt}");
                Console.WriteLine($"Registrerades: {Bil.Registrerades}");
                Console.WriteLine($"Registreringsnummer: {Bil.Registreringsnummer}");
                if (Bil.Elbil)
                    Console.WriteLine("Den här är miljövänlig!");
                
            }
            Console.ReadKey();
        }
    }

    public class Bil
    {
        public string Model { get; set; }
        public int Vikt { get; set; }
        public string Registrerades { get; set; }  // Ändra eventuellt till string (public string Registrerades { get; set; }
        public bool Elbil { get; set; }
        public string Registreringsnummer { get; set; }
    }
}