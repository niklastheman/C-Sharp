using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;


namespace Villkor_och_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRacing = true;
            List<Runner> listOfRunners = new List<Runner>();

            while (isRacing)
            {
                Console.Clear();
                
                var runner = new Runner();

                runner.StartNumber = runner.SetStartNumber();

                if (runner.StartNumber < 1)
                {
                    isRacing = false;
                    break;
                }

                runner.SetAllTimes();
                listOfRunners.Add(runner);
                listOfRunners.Sort((x, y) => x.TotalTimeInSeconds.CompareTo(y.TotalTimeInSeconds));

                runner.PrintInfo();

                Console.WriteLine("Tryck på en knapp för att fortsätta...");
                Console.ReadKey();
            }

            Console.Clear();

            if (listOfRunners.Count == 0)
            {
                Console.WriteLine("Det fanns inga tävlande i detta lopp.");
            }

            else
            {
                Console.WriteLine($"\n\t----VINNARE----");
                listOfRunners.First().PrintInfo();

                if (listOfRunners.Count > 1)
                {
                    Console.WriteLine("\n\t----ANDRA OCH TREDJE PLATS----");
                    int position = 1;
                    foreach (var contestant in listOfRunners)
                    {
                        if (position != 1 && position <= 3)
                        {
                            contestant.PrintInfo();
                        }
                        position++;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
