using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace Villkor_och_loopar
{

    /// <summary>


    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Lista som tar emot int-array
            List<int[]> contestants = new List<int[]>();
            
            bool isRunning = true;
            int startNr, startTimme, startMinut, startSekund, malTimme, malMinut, malSekund;
            while (isRunning)
            {
                Console.Write("Ange startnummer: ");
                startNr = Convert.ToInt32(Console.ReadLine());
                if (startNr < 1)
                {
                    isRunning = false;
                    break;
                }

                int[] runner = new int[7]; // Om startnummer är större än 0 så skapas en ny löpare
                runner[0] = startNr;

                Console.Write("Ange timme för start: ");
                startTimme = Convert.ToInt32(Console.ReadLine());
                runner[1] = startTimme;
                
                Console.Write("Ange minut för start: ");
                startMinut = Convert.ToInt32(Console.ReadLine());
                runner[2] = startMinut;
                
                Console.Write("Ange sekund för start: ");
                startSekund = Convert.ToInt32(Console.ReadLine());
                runner[3] = startSekund;

                Console.Write("Ange timme för mål: ");
                malTimme = Convert.ToInt32(Console.ReadLine());
                runner[4] = malTimme;

                Console.Write("Ange minut för mål: ");
                malMinut = Convert.ToInt32(Console.ReadLine());
                runner[5] = malMinut;

                Console.Write("Ange sekund för mål: ");
                malSekund = Convert.ToInt32(Console.ReadLine());
                runner[6] = malSekund;

                contestants.Add(runner);

            }
            
            //contestants.Sort();
            //Console.WriteLine($"Startnr {contestants[0][0]} vann");
            Console.WriteLine("Nu är spelet slut");
            Console.ReadKey();
        }

        


        public class Runner
        {
            public int StartNr { get; set; }
            public int StartTimme { get; set; }
            public int StartMinut { get; set; }
            public int StartSekund { get; set; }
            public int MalTimme { get; set; }
            public int MalMinut { get; set; }
            public int MalSekund { get; set; }

        }
    }
}

