using System;

namespace PersonApplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Börjar med att be användare mata in alla värden vi behöver.
            // Person-klassen har andra värden än bara strängar.
            // Console.ReadLine() är en metod som retunerar strängar.
            // Detta innebär att för vissa värden måste vi konvertera det som användare skrivit in i konsolen
            // dvs en sträng, till någon annan datatyp.
            // Kommentarer om när det sker kan man se nedan

            Console.WriteLine("Hej!");

            Console.Write("Vad heter du i förnamn? : ");
            string firstName = Console.ReadLine();

            Console.Write("Vad heter du i efternamn? : ");

            string surName = Console.ReadLine();

            Console.Write("Är du gift? j/n: ");

            string giftSvar = Console.ReadLine();

            // Här! Ett bra exempel på hur vi måste ta något som användaren svarade (en sträng) och översätta det till 
            // den datatyp vi använder i Person-klassen (bool i det här fallet)
            // eftersom giftSvar == "j" är ett villkor (som går att köra i en if-sats eller while-loop), skvallrar det om att det är 
            // av en boolesk datatyp
            // därmed kan vi översätta giftSvar == "j" direkt till en variable av typen bool
            // en annan lösning hade varit att ha en faktiskt if-sats, typ if(giftSvar == "j")

            bool married = giftSvar == "j";

            Console.Write("Har du ett körkort? j/n: ");

            string körkortSvar = Console.ReadLine();

            bool hasKörkort = körkortSvar == "j";

            DateTime? togKörkort = null;

            if (hasKörkort == true)
            {
                // Här! Ett bra exempel på hur vi måste ta något som användaren svarade (en sträng) och översätta det till 
                // den datatyp vi använder i Person-klassen (DateTIme i det här fallet)
                // vi använder DateTime.Parse(togKörkortSvar) för att göra om det användaren skrev (en sträng)
                // till en DateTime variabel

                Console.Write("När tog du körkort? yyyy-MM-dd: ");

                string togKörkortSvar = Console.ReadLine();

                togKörkort = DateTime.Parse(togKörkortSvar);
            }

            Console.Write("Hur gammal är du? : ");

            string ålderSvar = Console.ReadLine();

            int age = int.Parse(ålderSvar);

            Console.Write("När föddes du? yyyy-MM-dd: ");

            string födelsedatumSvar = Console.ReadLine();

            DateTime dateOfBirth = DateTime.Parse(födelsedatumSvar);

            //Efter det att vi fått alla värden från användaren, gjort om de till de datatyper vi vill använda i Person-klassen
            // så skapar vi upp en objekt (person) av klassen Person genom anropa klassens kontruktor
            // och använda våra variabler om input-parametrar i den kontruktorn :) :) :)
            Person person = new Person(firstName, surName, married, togKörkort, age, dateOfBirth);
        }
    }

    public class Person
    {

        // Properties (egenskaper)
        // Vi kan tänka på de som fält (fields) med metoder (get, set) för att manipulera dem
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool Married { get; set; }
        public DateTime? DateOfKörkort { get; set; }

        // Fields (fält)
        public int age;
        public DateTime dateOfBirth;

        // Konstruktor
        // Metoden som körs varje gång vi skapar upp en instans (objekt) av klassen
        public Person
        (
            string firstName
            , string surname
            , bool married
            , DateTime? dateOfKörkort
            , int age
            , DateTime dateOfBirth
        )
        {
            FirstName = firstName;
            Surname = surname;
            Married = married;
            DateOfKörkort = dateOfKörkort;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
