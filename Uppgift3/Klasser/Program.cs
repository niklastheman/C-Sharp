using System;
using System.Collections.Generic;
using System.Xml.Schema;

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

            // Skapar fyra objekt av klassen Bil
            Bil BMW = new Bil
            {
                Modell = "BMW Z3",
                Vikt = 100,
                Registrerades = DateTime.Now.ToString("2020-03-31"),
                Elbil = false,
                Registreringsnummer = "ABC 123"
            };

            Bil Tesla = new Bil
            {
                Modell = "Tesla S-Series",
                Vikt = 92,
                Registrerades = DateTime.Now.ToString("2018-11-22"),
                Elbil = true,
                Registreringsnummer = "DEF 456"
            };

            Bil Volkswagen = new Bil
            {
                Modell = "Volkswagen Passat",
                Vikt = 110,
                Registrerades = DateTime.Now.ToString("2010-05-04"),
                Elbil = false,
                Registreringsnummer = "GHI789"
            };

            Bil Chevrolet = new Bil
            {
                Modell = "Chevrolet Volt",
                Vikt = 115,
                Registrerades = "2020-04-05",
                Elbil = true,
                Registreringsnummer = "JKL101"
            };
            Billista.Add(BMW);
            Billista.Add(Tesla);
            Billista.Add(Volkswagen);
            Billista.Add(Chevrolet);

            foreach (var Bil in Billista)
            {
                Console.WriteLine();
                Console.WriteLine($"Model: {Bil.Modell}");
                Console.WriteLine($"Vikt: {Bil.Vikt}");
                Console.WriteLine($"Registrerades: {Bil.Registrerades}");
                Console.WriteLine($"Registreringsnummer: {Bil.Registreringsnummer}");
                if (Bil.Elbil)
                    Console.WriteLine("Den här är miljövänlig!");
                
            }
            Console.ReadKey();
        }
    }

    public class Modell()
    public class Bil
    {
        public string Modell { get; set; }
        public int Vikt { get; set; }
        public string Registrerades { get; set; }  
        public bool Elbil { get; set; }
        public string Registreringsnummer { get; set; }
    }
}