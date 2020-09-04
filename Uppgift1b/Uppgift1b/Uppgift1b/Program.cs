using System;

namespace Uppgift1b
{
    class Program
    {

        //Lös uppgifterna som står i kommentarerna.
        //All kod ska ligga inne i Main-funktionen nedan.
        //Tips: Lägg en Console.Readline längst ner i Main-funktionen så att inte konsolen 
        //stängs direkt.
        static void Main(string[] args)
        {
            //Variabel deklarationer.
            //Inga variabler förutom dessa ska användas.
            //Man får inte ändra på typerna av dessa variabler.
            int i, tal1, tal2;
            long l;
            decimal d;
            float f;
            bool b;
            string sant, input1, input2;


            //1. tilldela variabel i värdet 10
            i = 10;

            //2. Använd implicit konvertering för att tilldela variabel "l" värdet av "i"
            l = i;

            //3. Addera 1 till variabeln "l" mha inkrement operatorn.
            l++;

            //4. Använd compound assignment för att multiplicera värdet av variabel "l" med 2
            l *= 2;

            //5. Avänd explicit konvertering för att tilldela variabel "i" värdet av "l"
            i = (int)l;

            //6. Skriv ut värdet av variabeln i konsolen. Talet 22 bör skrivas ut
            Console.WriteLine(i);

            //7. Tilldela variabeln "f" värdet 3.14
            f = 3.14f;

            //8. Använd explicit konvertering för att tilldela variabeln "d" värdet av variabeln "f"
            d = (decimal)f;

            //9. Använd dekrement operatorn för att subtrahera värdet av "d" med 1
            d--;

            //10. Använd compound assignment för att multiplicera värdet av variabel "d" med 3
            d *= 3;

            //11. Använd explicit konvertering för att tilldela "i" värdet av "d" modulo 5 (restvärdet)
            i = (int)d % 5;

            //12. Skriv ut värdet av "i" i konsolen. Bör vara 1.
            Console.WriteLine(i);

            //13. Tilldela variabeln "sant" värdet true som en sträng
            sant = "true";

            //14. Använd en hjälp klass för att konvertera 
            //och tilldela variabeln "b" värdet av variabeln "sant"
            //Kod här
            b = Convert.ToBoolean(sant);

            //15. Sätt variabel "b":s värde till falskt
            b = false;

            //16. Använd en hjälp klass för att konvertera 
            //och tilldela variabeln "sant" värdet av variabeln "b"
            sant = Convert.ToString(b);

            //17. Skriv ut värdet av variabeln "sant" i konsolen. Bör vara False.
            Console.WriteLine(sant);

            //18. Skriv ut till konsolen texten: Ange ett heltal:
            Console.WriteLine("Ange ett heltal:");

            //19. Läs in ett heltal från konsolen tilldela värdet till variabel "input1"
            input1 = Console.ReadLine();

            //20. Skriv ut till konsolen texten: Ange ett annat heltal:
            Console.WriteLine("Ange ett annat heltal:");

            //21. Läs in ett annat heltal från konsolen tilldela värdet till variabel "input2"
            input2 = Console.ReadLine();

            //22. Använd datatypen ints Parse funktion för att konvertera och tilldela
            //värdet av "input1" till variabeln "tal1"
            tal1 = int.Parse(input1);

            //23. Använd datatypen ints Parse funktion för att konvertera och tilldela 
            //värdet av "input2" till variabeln "tal2"
            tal2 = int.Parse(input2);

            //24. På en kod-rad skriv ut i konsolen mha string interpolation resultatet man 
            //får av att multiplicera "tal1" och "tal2" med varandra.
            //Exempel: Givet att "tal1" = 2 och "tal2" = 10 ska det skrivas ut i konsolen:
            //Produkten av talen 2 och 10 är: 20

            Console.WriteLine($"Produkten av talen {tal1} och {tal2} är: {tal1 * tal2}");
            Console.ReadLine();
            
        }
    }
}
