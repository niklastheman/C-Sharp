using System;

namespace Klasser
{
    /// <summary>
    /// Programmet börjar med att skapa fyra objekt av typen bil och lägger in de i en lista. Vilka värden objekten får väljer du som programmerare själv.
    /// Sedan itererar (loopar) du igenom listan av bilar och skriver ut informationen om dem. 
    /// Om en bil är miljövänlig (dvs är en elbil) skriver du ut ett extra meddelande på skärmen (i stil med "Detta är en elbil!")
    /// Om klar se extra uppfigter nedan!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// Nedan ser du klassen Bil. Det är en bra start, men den är inte komplett! 
    /// Bilar klassen saknar följande uppgifter:
    /// Properties:
    ///     Vikt i hela kilon
    ///     Datum för när bilen registrerades första gången
    ///     Något som säger huruvida bilen är en elbil eller inte.
    /// 
    /// Fält:
    ///     Modellnamn, ska vara synligt utanför klassen. Ska kunna anges i en konstruktor.
    ///     Milmätare, decimaltal som inte ska inte vara synligt utanför klassen. Ska ENDAST kunna uppdateras genom en metod.
    ///     Om en någonting utanför klassen vill veta värden för milmätaren ska det använda en metod. Den metoden ska returnera värdet som en sträng.
    ///     
    /// </summary>
    public class Bil
    {
        public string Registreringsnummer { get; set; }

    }
}
/*
 
    Extrauppgifter:
    1. Gör så att användaren av applikationen själv skapar upp bilar direkt i konsolapplikationen.
    2. Skapa en Person klass.
        - En person ska ha ett namn, en ålder, och en lista av bilar...
    3. Iterera genom Personer och deras bilar.
    4. Gör så att användare själv skriver inte BÅDE personer och deras bilar direkt i konsolapplikationen.
 */
