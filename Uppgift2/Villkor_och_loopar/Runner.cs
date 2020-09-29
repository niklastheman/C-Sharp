using System;
using System.Collections.Generic;
using System.Text;

namespace Villkor_och_loopar
{
    public class Runner
    {
        
        private int _goalHour;
        private int _goalMinute;
        private int _goalSecond;

        public int TotalTimeInSeconds { get; set; }
        public int StartNumber { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int StartSecond { get; set; }
        public int FinishHour { get; set; }
        public int FinishMinute { get; set; }
        public int FinishSecond { get; set; }




        public void SetAllTimes()
        {
            
            StartHour = SetRunnerTime("startHour");
            StartMinute = SetRunnerTime("startMinute");
            StartSecond = SetRunnerTime("startSecond");

            FinishHour = SetRunnerTime("finishHour");
            FinishMinute = SetRunnerTime("finishMinute");
            FinishSecond = SetRunnerTime("finishSecond");

            SetTotalTimeInSeconds();
        }
        public void SetTotalTimeInSeconds()
        {
            _goalHour = FinishHour - StartHour;
            _goalMinute = FinishMinute - StartMinute;
            _goalSecond = FinishSecond - StartSecond;

            // Uträkningar för att fånga upp lopp som passerar midnatt
            if (_goalSecond < 0)
            {
                _goalSecond += 60;
                _goalMinute--;
            }

            if (_goalMinute < 0)
            {
                _goalMinute += 60;
                _goalHour--;
            }

            if (_goalHour < 0)
            {
                _goalHour += 24;
            }

            TotalTimeInSeconds = _goalSecond + (_goalHour * 3600) + (_goalMinute * 60);
        }

        public int SetRunnerTime(string whatToSet)
        {
            int timeToSet = 0;

            if (whatToSet == "startHour")
            {
                timeToSet =  SetStartOrFinishHour("start"); 
            }

            else if (whatToSet == "finishHour")
            {
                timeToSet = SetStartOrFinishHour("mål");
               
            }

            else if (whatToSet == "startMinute")
            {
                timeToSet = SetStartOrFinishMinute("start"); 
            }

            else if (whatToSet == "finishMinute")
            {
                timeToSet = SetStartOrFinishMinute("mål");
            }

            else if (whatToSet == "startSecond")
            {
                timeToSet = SetStartOrFinishSecond("start");
            }

            else if (whatToSet == "finishSecond")
            {
                timeToSet = SetStartOrFinishSecond("mål");
            }

            return timeToSet;
        }

        public int SetStartOrFinishHour(string startOrFinish)
        {
            int startOrFinishHour = 0;
            var isInputting = true;
            do
            {   
                Console.Write($"Ange timme för {startOrFinish}: ");
                if (!int.TryParse(Console.ReadLine(), out startOrFinishHour) || (startOrFinishHour < 0 || startOrFinishHour > 23))
                    Console.WriteLine("Inkorrekt inmatning. Ange en timme mellan 00-23");

                else
                {
                    isInputting = false;
                }
            }
            while (isInputting);

            return startOrFinishHour;
        }

        public int SetStartOrFinishMinute(string startOrFinish)
        {
            var startOrFinishMinute = 0;
            var isInputting = true;
            do
            {
                Console.Write($"Ange minut för {startOrFinish}: ");
                if (!int.TryParse(Console.ReadLine(), out startOrFinishMinute) || (startOrFinishMinute < 0 || startOrFinishMinute > 59))
                    Console.WriteLine("Inkorrekt inmatning. Ange en minut mellan 0-59");

                else
                    isInputting = false;
            }
            while (isInputting);

            return startOrFinishMinute;
        }

        public int SetStartOrFinishSecond(string startOrFinish)
        {
            var startOrFinishSecond = 0;
            var isInputting = true;
            do
            {
                Console.Write($"Ange sekund för {startOrFinish}: ");
                if (!int.TryParse(Console.ReadLine(), out startOrFinishSecond) || (startOrFinishSecond < 0 || startOrFinishSecond > 59))
                    Console.WriteLine("Inkorrekt inmatning. Ange en sekund mellan 0-59");

                else
                    isInputting = false;
            }
            while (isInputting);

            return startOrFinishSecond;
        }

        public int SetStartNumber()
        {
            var startNumber = 0;
            var isInputting = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\t---------------");
                Console.Write("Ange startnummer: ");
                if (!int.TryParse(Console.ReadLine(), out startNumber))
                    Console.WriteLine("Felaktig inmatning!");

                else
                {
                    isInputting = false;
                }
            } while (isInputting);

            return startNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nStartnummer: {StartNumber}" +
                $"\nSluttid: {_goalHour} timmar {_goalMinute} minuter och {_goalSecond} sekunder");
        }

    }
}
