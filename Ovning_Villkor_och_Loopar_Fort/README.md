# Villkor och Loopar - Forsättning

Uppgifterna ska genomföras i en konsol-applikation

## Program start

Du ska göra en snabb undersökning genom att skriva ett program. 
Skriv en konsol-applikation som frågar användaren om dennes ålder samt huruvida 
hen tycker om kaffe eller inte.
Användaren svara på en fråga i taget. Användaren skriver "y" för ja och "n" för nej. 

### If, else if, else

1. Om användaren anger ja och är yngre än 20 år skall programmet skriva ut: 
"Det är ovanligt att tycka om kaffe i din ålder!"

2. Om användaren anger ja och är äldre än 20 år skall programmet skriva ut:
"Standard!"

3. Om användare anger nej och är äldre än 20 år skall programmet skriva ut:
"Det är dags att lära sig tycka om kaffe nu!"

## Loopar

1. Skriv ut följande i följande loopar (är helt ok om siffrorna skrivs på ny rad):

### for

		* 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

		* 0, 2, 4, 6, 8, 10, 12, 14, 16, 18

		* 2, 4, 6, 8, 10, 12, 14, 16, 18, 20

		* Fibonaccital upp tom 121393 (https://sv.wikipedia.org/wiki/Fibonaccital)

		* 2, 4, 16, 256, 65536

2. Se om du kan översätta funktionaliteten från en for-loop till en while-loop

3. Lös följande med hjälp av continue (kan använda vilken loop som helst):
		* 1, 2, 3, 4, 6, 7, 9, 10, 11, 12 (5 och 8 saknas)

4. Använd följande kod men få den att sluta när x är hundra eller mer

		int x = 0;

		while(true){

		Console.WriteLine(x.ToString());

		x++;
		}

