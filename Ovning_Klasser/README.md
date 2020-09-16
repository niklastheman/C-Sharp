# Övningar C# - klasser

Nedan följer lite övningar med syfte att lära ut klasser samt metoder i C#.
Övningarna är tänkta att genomföras i en konsol-applikation

## Övning 1

DEL 1

1. Skapa en klass som heter Person med följande egenskaper och fält

		Egenskaper: Förnamn, efternamn, beskrivning (kort biografi), gift (ja/nej), datum personen tog körkort (kan vara null)
		Fält: Ålder (i siffror), födelsedatum
		

2. Skapa en konstruktor som tar in tillräckligt med input-parametrar för att ange samtliga egenskaper och fält.	
3. Fråga användaren av konsol-applikationen efter var och en av egenskaperna och fälten som person-klassen innehåller.
4. Från de värden användaren matat in. Skapa ett objekt av klassen (med hjälp av konstruktorn)
5. Skriv ut alla fakta som du hittills samlat om personen.

DEL 2

1. Gör samtliga fält i Person-klassen private. (Kommentera ut om du störs av editorn)
2. Lägg till en metod i Person-klassen som heter GetInfo(). Metoden ska behöver inte retunera någonting men den ska skriva ut all fakta du hittills samlat om personen. 
3. Lägg till en metod i Person-klassen som heter som heter GetAge(). Metoden ska returnera en värdet på en persons ålder (inte skriva ut direkt i konsol-applikationen).
4. Lägg till en fråga i programmet som lyder "Vill du veta personens ålder?", om användaren skriver j, använd GetAge() metoden och skriv ut värdet i konsolen.
5. Om du inte redan gjort det. Ändra den sista delen av konsol-applikation till att använda GetInfo().

DEL 3

1. Lägg till en egenskap: IsShyAboutAge ja/nej.
2. Modifiera konstruktorn så att man måste ange den nya egenskapen.
3. Modifiera konsol-applikationen så att använderen måste ange huruvida personen "IsShyAboutAge".
4. Om IsShyAboutAge så ska svaret från GetAge() metoden vara -1. Annars oförändrat.

## Övning 2

DEL 1

1. Skapa en klass som heter Hund med följande egenskaper, fält och metoder

	Egenskaper: Namn, Ålder (i siffror), Namn på ägare
	Fält (samtliga fält ska vara private): Vikt (kan vara decimal-tal), huruvida hunden gillar att skälla ja/nej, huruvida hunden gillar prommenader ja/nej
	Metoder:
		- GoForAWalk() - Gå på promenad. Om hunden gillar att gå på promenad ska den gå ner i vikt med hela 1 kg. Annar endast ett halvt kg.
		- Bark() - Hunden skäller, skriv ut "woff" i konsolen om hunden gillar att skälla, annars skriv inte ut någonting.
		- Eat(antal ben) - hunden äter. Metoden skall ta emot en input parameter som anger hur många ben hunden äter. Hunden genomgår en viktöking enligt alogoritmen
			(antal ben) * 0.7 kg.
		- GetMyStatus() - Skriv ut hur mycket hunden för närvarande väger. 
		
2. Skapa en konstruktor som tar emot tillräckligt med parametrar för att kunna ange samtliga fält i Hund-klassen.
3. Overloada (method overloading) konstruktorn så att man även kan ange samliga egenskaper.
4. Fråga användaren av konsol-applikationen efter var och en av egenskaperna och fälten som Hund-klassen innehåller.
5. Använd den första konstruktorn för att skapa upp en objekt av typen Hund. Använd egenskaperna för att ange de andra värdena till objektet.
6. Hunden (skriv i konsol-applikationen) ska sedan fråga: "Vad vill du jag ska göra nu?", lista alla metoder (fast med roligare namn, dvs hitta på något som bekriver
	vardera metod) och ett kommando (typ s för skälla). Med kommandot kan användaren alltså välja vad hunden ska göra (vilken metod som ska köras). Lägg
	även till möjligheten att avsluta programmet.
7. Efter en metod har körts frågar hunden åter "Vad vill du jag ska göra nu?" och proceduren upprepas. 


DEL 2

1. Lägg till ett private fält som håller koll på antalet gånger hunden gått på en prommenad. Fältet ska vara private och det ska inte ange i en konstruktor.
2. Modifiera GetMyStatus() metoden så att den skriver ut mycket mer information om hunden. Dels vad hunden heter och hur gammal den är men även hur många gånger den
	gått på prommenad.
3. Se till så att antalet prommenader verkligen räknas!

## Övning 3
	
1. Skapa en klass Lejon med följande egenskaper:
	Namn, Land (som djuret bor i, en sträng) och ålder (heltal)	
2. Skapa en struct Tiger med samma egenskaper som Lejon:
	Namn, Land (som djuret bor i, en sträng) och ålder (heltal)
3. Be mata en egenskaperna för de bägge djuren.
4. Av vardera djur, skapa upp en tvilling (en kopia) genom att deklarera en ny variabel och tilldela den värdet av det ursprungliga djuret. Dvs lejon2 = lejon1, och
	likdant för tigern.
5. Be användaren ange ett namn för vardera tvilling.
6. Skriv ut information om alla objekten i ditt program, dvs båda tigrarna och båda lejonen.
7. Debugga och undersök vad som händer. Skiljer sig slutresultaten åt mellan de olika djurarterna?

## Övning 4

Återvänd till Övning 1 och 2.

1. Utöka Person-klassen till att ha en egenskap av typen Hund.
2. Utöka Person-klassen med en metod: ByeBye(). Metoden ska skriva ut "Hej då hälsar /Namn på person/".
3. Ta vid där programmet för Övning 1 slutade. Fråga användaren huruvida personen har en hund eller inte. Om j Fråga användaren av konsol-applikationen 
	efter var och en av egenskaperna och fälten som Hund-klassen innehåller.
4. Om personen har en hund skall programmet skriva ut: "/Namn på personen/ har en hund som heter /Namn på hund/! Hunden vill prata med dig!" 
5. Sedan går programmet in i samma läget som Övning 2, punkt 6.
6. När programmet avslutas skall hunden skälla samt personen använda sin hejdåfras (ByeBye()). 

## Övning 5

1. Lös Uppgift 2 (i detta repo) igen fast istället för att bara använda dig av variabler, skapa nu en klass med lämpligt namn och håll dina värden i den klassen.
2. Förbättra Uppgift 2 ytterliggare. Se till att du lagrar alla deltagare. När programmet avslutas skall du skriva ut samtliga deltagares resultat.
3. Ordna listan efter bäst resultat först. 



