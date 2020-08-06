# C# projektuppgift

## Bosses Bilverkstad - Bakgrund
Bosses bilverkstad har tidigare arbetat manuellt med administrativa uppgifter. Bosse har nu bestämt att ett system ska köpas in för att hjälpa till att effektivisera verksamheten. Exempel på uppgifter som Bosse vill kunna göra i det nya systemet är att kunna lägga in nya ärenden, se vilka av hans bilmekaniker som är finns tillgängliga för ett jobb och kunna tilldela en bilmekaniker ett jobb baserat på dennes specialkompentenser. Er uppgift är nu att utveckla detta system till Bosse.

## Teknkik som ska användas
Systemet ska utvecklas i C# där WPF ska användas för det grafiska gränssnittet och JSON för att lagra data.

## Kravspecifikation
1. Man ska kunna lägga till, ta bort och ändra bilmekaniker i systemet. 
2. Man ska kunna lägga till och ta bort kompetenser för en bilmekaniker.
3. Man ska kunna lägga till, ta bort och ändra ärenden.
4. Man ska kunna ändra status på ett ärende från pågende till klar.
4. Man ska kunna se vilka bilmekaniker som kan utföra ett ärende baserat på mekanikerns kompetenser samt ärendets egenskaper.
5. Man ska kunna tilldela ett ärende till en lämplig bilmekaniker. Om en bilmekaniker inte finns tillgänglig användaren informeras om det på ett lämpligt sätt.
6. En bilmekaniker får endast ha max 2 pågående ärenden samtidigt. Detta innebär att en bilmekaniker som redan har två pågående ärenden inte ska gå att välja för ett nytt ärende trots att denne uppfyller kompetenskraven. Denna mekaniker blir tillgänglig igen endast när någon av de pågående ärendena ändrar status till klar. 
