# C# projektuppgift

## Bosses Bilverkstad - Bakgrund
Bosses bilverkstad har tidigare arbetat manuellt med administrativa uppgifter. Bosse har nu bestämt att ett system ska köpas in för att hjälpa till att effektivisera verksamheten. Exempel på uppgifter som Bosse vill kunna utföra i det nya systemet är att kunna lägga in nya ärenden, se vilka av hans bilmekaniker som är tillgängliga för ett ärende och kunna tilldela en bilmekaniker ett ärende baserat på dennes specialkompentenser. Er uppgift är nu att utveckla detta system till Bosse.

## Tekniska krav
Systemet ska utvecklas i C# där WPF ska användas för det grafiska gränssnittet och JSON för att lagra data.

1. Datalagring
- Data skall lagras i json filer
- Varje entitet skall lagras i en separat fil
- Om fil saknas skall programmet skapa upp en ny utan att krascha
2. Interface
- Programmet skall använda sig av minst ett interface
- Får inte användas till någon av entiteterna
3. Abstrakt klass
- Programmet skall använda sig av minst en abstrakt klass
4. Arv
- Programmet skall använda sig av arv
5. Linq
- Programmet skall använda sig av linq
6. Lambda
- Programmet skall använda sig av lambda
7. Felhantering
- Programmet skall använda sig av en try-catch
- Programmet skall använda sig av ett egenskapat Exception
8. Projektstruktur
- Lösningen skall innehålla två projekt. Ett för gränssnitt och ett för logik (uppfylls av projekt-template)
- Logik-projektet skall vara väl strukturerat i mappar (uppfylls av projekt-template)
9. Validering
- Programmet skall validera indata i enlighet med avsnittet “Data som lagras”. Det skall inte gå att lägga till objekt som saknar egenskaper som krävs
- Inloggning
    * Validering av e-postadress skall ske med hjälp av Regex
    * För att en inloggning ska ske krävs att en användare med angivet användarnamn och lösenord finns lagrad
    * Vid fel användarnamn och/eller lösenord skall personen som försöker logga in meddelas om detta

### VG

1. Asynkron programmering
- Programmet skall använda sig av async/await på lämpligt vis
2. Generisk programmering
- Programmet skall använda sig av generisk-programmering i datalagret
3. Extension-metoder
- Programmet skall använda sig av en extension-metod på lämpligt vis. Exempelvis genom att bygga en funktion som kan användas på en sträng-variabel


## Funktionella krav
Systemet ska kunna hantera två olika typer av användare. De två typer av användare som ska stödjas är admin och bilmekaniker. Det ska endast finnas en admin-användare. Denna användare finns redan i filen User.json. Beroende på vilken typ av användare man är inloggad som ska man ha tillgång till olika funktionalitet.

Funktioner för Admin:
1. Man ska kunna lägga till, ta bort och ändra bilmekaniker i systemet. 
2. Man ska kunna lägga till och ta bort kompetenser för en bilmekaniker.
3. Man ska kunna lägga till och ta bort nya bilmekaniker-användare. För att skapa en ny bilmekaniker-användare måste denne kunna kopplas till en existerande bilmekaniker i systemet.  
3. Man ska kunna lägga till, ta bort och ändra ärenden.
4. Man ska kunna ändra status på ett ärende från pågende till klar. Detta kan man endast göra om ärendet redan blivit tilldelat en mekaniker.
5. Man ska kunna se vilka bilmekaniker som kan utföra ett ärende baserat på mekanikerns kompetenser samt ärendets egenskaper.
6. Man ska kunna tilldela ett ärende till en lämplig bilmekaniker. Om en bilmekaniker inte finns tillgänglig användaren informeras om det på ett lämpligt sätt.
7. En bilmekaniker får endast ha max 2 pågående ärenden samtidigt. Detta innebär att en bilmekaniker som redan har två pågående ärenden inte ska gå att välja för ett nytt ärende trots att denne uppfyller kompetenskraven. Denna mekaniker blir tillgänglig igen endast när någon av de pågående ärendena ändrar status till klar.
8. Man ska kunna lista alla bilmekaniker i systemet. Om man väljer en bilmekaniker ska man kunna se dess egenskaper och kompetenser. Dessutom ska man kunna se den valda mekanikerns pågående och avslutade ärenden. Förslagsvis är det även härifrån man kan redigera, skapa och ta bort mekaniker.
9. Man ska kunna lista pågående och avslutade ärenden. Väljer man ett ärende ska man få fram all information om det. Om ärendet är tilldelat en bilmekaniker ska det även gå att se vilken denne är. Förslagsvis är det även härifrån man kan redigera, skapa och ta bort ärenden.

Funktioner för bilmekaniker-användare:
1. Man ska kunna lägga till och ta bort kompetenser för sig själv.
2. Man ska kunna ändra status på ett ärende som är tilldelat den inloggade mekanikern från pågende till klar.
3. Man ska kunna lista pågående och avslutade ärenden för den inloggade användaren. Väljer man ett ärende ska man få fram all information om det.

### Funktionella krav för VG

1. Man ska kunna hålla koll på ett lager bestående av olika typer av komponenter d.v.s. samma som de kompetenser finns. Varje komponent är kopplad till en typ av fordon. För varje komponent kopplat till en typ av fordon finns även ett antal som representerar hur många av en specifik typ komponent för en specifik typ av fordon det finns på lager.
Exempelvis kan det finnas en komponent av typen "Däck" som är kopplade till fordonstypen "Bil" och som det finns 6 stycken av på lagret.

2. För varje typ av ärende går det åt ett visst antal av en specifik komponent. För att det ska gå att lägga till ett nytt ärende måste det därför förutom att finnas en tillgänglig mekaniker (enligt de funktionella kraven ovan) även på lagret finnas minst det antal av den komponent som ärendet kräver. Om det krävda antalet komponenter finns på lager så måste antalet uppdateras efter det att ärendets skapats. Exempelvis om det finns 6 stycken bildäck på lager så ska det efter att ett ärende med problemet bildäck endast finnas två bildäck kvar på lager. Se nedan för hur mycket av en specifik komponent som går åt för en typ av fordon med ett visst problem.

3. Om det inte finns tillräckligt av en komponent på lagret så måste man kunna köpa in mer av komponenten. När man köper in en komponent ska antalet av denna komponent adderas med det antal som man köpt in. När man köper in en komponent ska man välja typ av komponent (ex. "Däck"), typ av fordon som komponenten hör till (ex. "Bil") och antalet av komponenten man vill köpa in.


#### Åtgång av material baserat på ärendets problem och fordonstyp

## Data som ska lagras

Sakerna (läs entiteterna) som Bosse vill ha information om och deras egenskaper listas nedan. De egenskaper som följs av en asterix (*) är obligatoriska, dvs de måste fyllas i när ett objekt av typen skapas. Vissa entiteter kan komma att behöva id:n. Det har medvetet utelämnats från listan nedan och är upp till er hur ni vill lösa. Samtliga entiteter skall (se tekniska krav) lagras i egna filer.

### Användare:

Det finns två typer av användare. Bosse och alla andra. Bosse kan lägga till och ta bort användare. Det kan ingen annan. Skillnaden mellan Bosse och övriga användare kan lösas med arv men måste inte göra det.

En användare består av ett användarnamn *, lösenord *,  någonting som identifierar vilken mekaniker som användare tillhör (gäller inte Bosse).

### Fordon:

Fordon har ett modellnamn *, ett registreringsnummer *, mätare * (hur långt bilen gått), registreringsdatum *, drivmedel *(se typer)

Bilar
Typ av bil (se typer) *
Huruvida bilen har dragkrok eller inte *
Motorcyklar
Lastbilar
Maxvikt last *
Bussar
Max antal passagerare *

### Mekaniker

Namn på den anställde *, födelsedatum *(för att inte missa att fira födelsedagar), anställningsdatum *, slutdatum samt en uppsättning kompetenser (läs komponent se typer).

### Ärenden:

Ett ärende består av en beskrivning, ett fordon, ett problem (läs komponent se typer), en mekaniker och en status som säger huruvida ärendet är avklarat eller inte.

## Typer

Typer behöver inte nödvändigtvis lagras. Men system måste kunna behandla dem. Det är frivilligt vilken datatyp ni väljer använda och olika typer kan ha olika datatyper.

1. Drivmedel
    * El
    * Bensin
    * Diesel
    * Etanol
2. Komponent
    * Bromsar
    * Motor
    * Kaross
    * Vindrutor
    * Däck
3. Typ av bil
    * Sedan
    * Herrgårdsvagn
    * Cabriolet
    * Halvkombi


