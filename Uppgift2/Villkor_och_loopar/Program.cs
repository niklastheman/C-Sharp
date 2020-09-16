using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace Villkor_och_loopar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Deklaration av variablar. Jag valde att sätta int bredvid för att tydligt se skillnaden på start/finish, leader och secondPlace
            int startNumber = 0, 
                startHours = 0,
                startMin = 0,
                startSec = 0,
                finishHours = 0,
                finishMin = 0,
                finishSec = 0;
            int leaderStartNr = 0,
                leaderHours = 0,
                leaderMin = 0,
                leaderSec = 0,
                leaderSumInSeconds = 0;
            int secondPlaceStartNr = 0,
                secondPlaceHours = 0,
                secondPlaceMin = 0,
                secondPlaceSec = 0,
                secondPlaceSumInSeconds = 0;

            int contestants = 0;

            // bool-värden för att huvudloop ska köras och bool-värde för inmatningsloopar   
            bool isRacing = true, 
                isInputting;


            while (isRacing)
            {   
                Console.WriteLine("\t---------------"); // För att få en renare utskrift
                isInputting = true;
                do
                {
                    Console.Write("Ange startnummer: ");
                    if (!int.TryParse(Console.ReadLine(), out startNumber))
                        Console.WriteLine("Felaktig inmatning!");

                    // Om startnummer är mindre än 1 så stoppas inmatning och går till utskrift
                    else if (startNumber < 1)
                    {
                        isRacing = false;
                        isInputting = false;
                    }
                    // Annars så tas startNumber emot och inmatning avslutas
                    else
                        isInputting = false;
                }
                while (isInputting);
               
                // Kollar om loppet fortfarande körs. Om inte (dvs om startNumber < 1) så bryts loopen
                if (!isRacing)
                    break;

                // Här tar vi emot timme för start
                isInputting = true;
                do
                {
                    Console.Write("Ange timme för start: ");
                    // Fångar upp felinmatning ELLER (startHour < 0) ELLER (startHour > 23). Liknande mönster på alla inmatningar
                    if (!int.TryParse(Console.ReadLine(), out startHours) || (startHours < 0 || startHours > 23))
                        Console.WriteLine("Inkorrekt inmatning. Ange en timme mellan 00-23");

                    else
                        isInputting = false;
                }
                while (isInputting);
                
                // Här tar vi emot minut för start
                isInputting = true;
                do
                {
                    Console.Write("Ange minut för start: ");
                    if (!int.TryParse(Console.ReadLine(), out startMin) || (startMin < 0 || startMin > 59))
                        Console.WriteLine("Inkorrekt inmatning. Ange en minut mellan 0-59");

                    else
                        isInputting = false;
                }
                while (isInputting);

                // Här tar vi emot sekund för start
                isInputting = true;
                do
                {
                    Console.Write("Ange sekund för start: ");
                    if (!int.TryParse(Console.ReadLine(), out startSec) || (startSec < 0 || startSec > 59))
                        Console.WriteLine("Inkorrekt inmatning. Ange en sekund mellan 0-59");

                    else
                        isInputting = false;
                }
                while (isInputting);

                // Här tar vi emot timme för mål
                isInputting = true;
                do
                {
                    Console.Write("Ange timme för mål: ");
                    if (!int.TryParse(Console.ReadLine(), out finishHours) || (finishHours < 0 || finishHours > 23))
                        Console.WriteLine("Inkorrekt inmatning. Ange en timme mellan 00-23");

                    else
                        isInputting = false;
                }
                while (isInputting);
                
                // Här tar vi emot minut för mål
                isInputting = true;
                do
                {
                    Console.Write("Ange minut för mål: ");
                    if (!int.TryParse(Console.ReadLine(), out finishMin) || (finishMin < 0 || finishMin > 59))
                        Console.WriteLine("Inkorrekt inmatning. Ange en minut mellan 0-59");

                    else
                        isInputting = false;
                }
                while (isInputting);

                // Här tar vi emot sekund för mål
                isInputting = true;
                do
                {
                    Console.Write("Ange sekund för mål: ");
                    if (!int.TryParse(Console.ReadLine(), out finishSec) || (finishSec < 0 || finishSec > 59))
                        Console.WriteLine("Inkorrekt inmatning. Ange en sekund mellan 0-59");

                    else
                        isInputting = false;
                }
                while (isInputting);

                // Räknar ut och tilldelar den tävlandes sluttid i timmar, minuter och sekunder
                int contestantHours = finishHours - startHours;
                int contestantMin = finishMin - startMin;
                int contestantSec = finishSec - startSec;
                
                // Uträkningar för att fånga upp lopp som passerar midnatt
                if (contestantSec < 0)
                {
                    contestantSec += 60;
                    contestantMin--;
                }

                if (contestantMin < 0)
                {
                    contestantMin += 60;
                    contestantHours--;
                }

                if (contestantHours < 0)
                {
                    contestantHours += 24;
                }

                // Omvandlar den tävlandes tid till sekunder för jämförelser
                int contestantSumInSeconds = contestantSec + (contestantHours * 3600) + (contestantMin * 60);

                // Jämför nuvarande tävlande mot ledaren i sekunder. 
                // OM nuvarande tävlande har bättre tid än ledaren SÅ ersätts ledaren av nuvarande tävlande
                // Condition 2 för att fånga upp första loop (eftersom att ledareSluttidSekunder är instansierat till 0 utanför detta kodblock.
                if (contestantSumInSeconds < leaderSumInSeconds || leaderSumInSeconds <= 0)
                {
                    
                    // Andraplats tilldelas förra ledaren, men inte under första loppet
                    if (leaderSumInSeconds > 0)
                    {
                        secondPlaceSumInSeconds = leaderSumInSeconds;
                        secondPlaceStartNr = leaderStartNr;
                        secondPlaceHours = leaderHours;
                        secondPlaceMin = leaderMin;
                        secondPlaceSec = leaderSec;
                    }
                    
                    // Ersätter ledaren mot den tävlande
                    leaderSumInSeconds = contestantSumInSeconds;
                    leaderStartNr = startNumber;
                    leaderHours = contestantHours;
                    leaderMin = contestantMin;
                    leaderSec = contestantSec;
                    contestants++; // Plussar antal tävlande
                }

                // OM tävlande har sämre tid än ledaren OCH tävlanden har bättre tid än andra plats, ELLER andra plats inte har tilldelats
                // SÅ ersätts andraplats av nuvarande tävlande
                else if ((contestantSumInSeconds > leaderSumInSeconds &&
                    contestantSumInSeconds < secondPlaceSumInSeconds) ||
                    secondPlaceSumInSeconds <= 0)
                {
                    secondPlaceSumInSeconds = contestantSumInSeconds;
                    secondPlaceStartNr = startNumber;
                    secondPlaceHours = contestantHours;
                    secondPlaceMin = contestantMin;
                    secondPlaceSec = contestantSec;
                    contestants++; // Plussar antal tävlande
                }

                // Om nuvarande tävlande har sämre tid än ledaren så plussar vi antalet tävlande
                else if (contestantSumInSeconds >= leaderSumInSeconds)
                    contestants++;
            }

            // Skriv ut detta resultat OM det är fler än 1 tävlande
            if (contestants > 1)
            {
                // Skriver ut vinnarens startnummer och resultat
                Console.WriteLine($"\t---------------" +
                    $"\nVinnarens startnummer är: {leaderStartNr}" +
                    $"\nSluttid: " +
                $"{leaderHours} timmar " +
                $"{leaderMin} minuter " +
                $"{leaderSec} sekunder ");

                // Skriver ut andraplatsens startnummer, resultat och antal tävlande
                Console.WriteLine($"\t---------------" +
                    $"\nDen näst bästas startnummer är: {secondPlaceStartNr}" +
                    $"\nSluttid: " +
                $"{secondPlaceHours} timmar " +
                $"{secondPlaceMin} minuter " +
                $"{secondPlaceSec} sekunder " +
                $"\nAntal tävlande: {contestants}" +
                $"\nProgrammet avslutas..." +
                $"\n\t---------------");
                Thread.Sleep(1000); // ;)
            }

            else if (contestants < 1)
            {
                Console.WriteLine($"\t---------------" +
                    "\nLoppet hade inga deltagare! " +
                    "\nProgrammet avslutas..." +
                    "\n\t----------------");
                Thread.Sleep(1000);
            }

            // Skrivs ut om det bara är 1 tävlande.
            else
            {
                Console.WriteLine($"\t---------------" +
                    $"\nVinnarens startnummer är: {leaderStartNr}" +
                    $"\nSluttid: " +
                $"{leaderHours} timmar " +
                $"{leaderMin} minuter " +
                $"{leaderSec} sekunder " +
                $"\nAntal tävlande: {contestants}" +
                $"\nProgrammet avslutas..." +
                $"\n\t---------------");
                Thread.Sleep(1000); 
            }
        }
    }
}
