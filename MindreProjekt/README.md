# Övningsprojekt

Dessa övningsprojekt är tänkta att fungera som inspiration till projekt. Vi har kommit en bit in i kursen och somliga känner möjligen att uppgifter och övningar är lite för små... Om så är fallet kan kanske dessa mindre projekt fungera som inspiration till fortsatt lärande. Om ni inte finner något här passande går det givetvis att skapa vilket projekt ni helst önskar. Det absolut bästa sättet jag vet att lära sig ett programmeringsspråk är om ni har en idé för ett program som ni vill skapa. Då kommer ni finna mer inspiration till att lära er de tekniska aspekterna som programmeringsspråket kräver för att ni ska åstadkomma önskvärt resultat.

En sak som dessa projekt saknar är möjligheten att lagra data (information) efter det att applikationerna avslutas. Eller rättare sagt, det finns inga krav på det då vi hitills inte gått igenom hur ni kan gå tillväga för att göra det. Ni har fria händer att skapa den funktionaliteten såklart, annars räcker det med att ni hanterar data bara över tiden programmet körs.

## Zoo

### Premiss

Ett zoo behöver ett system för att hålla koll på sina djur och sin personal. På zoot finns många djur av många olika arter, sju för att vara exakt. Det finns apor, giraffer, lejon, pingviner, delfiner, björnar och elefanter. Djuren bor i olika inhägnader. Inhägnaderna kan ha lite olika karaktär. De kan ha träd, grottor, vattenkällor och buskage. Delfinerna håller till i en helt egen typ av inhägnad, nämligen en jätte-bassäng. På anläggningen arbetar en grupp djurskötare. För att få jobba som djurskötare krävs vissa kompetenser. Arterna kräver i sin tur minst en kompetens, delfinerna kräver exempelvis att skötaren ska kunna dyka.


### Exempeluppgift

Skriva ett program för att hantera zoot. Programmet kan vara en konsol-applikation som vi tidigare övat på; det är även helt okej att skriva den som en WPF-applikation om man önskar göra det. Man ska kunna lägga till ändra och ta bort djur, inhägnader, djurskötare samt deras kompetenser. Olika djur kräver olika attribut av sina inhägnader samt olika kompetenser hos sina skötare. Applikationen ska kunna lista alla djur och visa status för de samma. Dvs huruvida djuret bor i en tillfredsställande inhägnad samt har skötare med rätt kompetenser.

### (Exempel) Krav på projektet:

Kod: Använda sig av minst en abstrakt klass. Minst en kommentar med summary och parameters. Använda sig av namespace, entiteter i en (typ djur, skötare, inhägnad osv), klasser som tillhandahåller logik för att kontrollera status av zoot och dylikt i ett annat namespace. Använd ett interface någonstans i applikationen (förslagsvis till någon av logik-klasserna).

Funktionalitet: En användare skall kunna lista alla djur och deras status (alltså om de har allt de behöver) i applikationen. En användare skall kunna lägga till och ta bort djur, inhägnader och skötare samt deras kompetenser.

## Skolsystemet

### Premiss

En skola behöver ett nytt system. Skolan behöver hålla kolla på vilka "klasser" (obs inte C#-klasser) som finns på skolan, vilka program de klasserna går, vilka kurser som ingår i vilka program, vilka elever som tillhör vilken klass och säkert mer därtill! Programmet kan vara en konsol-applikation som vi tidigare övat på; det är även helt okej att skriva den som en WPF-applikation om man önskar göra det. Programmet ska kunna lista klasser(obs! inte C# class) och all information om de, dvs vilka elever och lärare samt kurser som hör till en specifik klass (obs! inte C# class).

### (Exempel) Krav på projektet:

Kod: Använda sig av minst en abstrakt klass. Minst en kommentar med summary och parameters. Använda sig av namespace, entiteter i en (typ klass, kurs, elev osv), klasser som tillhandahåller logik för att kontrollera status av systemet och dylikt i ett annat namespace. Använd ett interface någonstans i applikationen (förslagsvis till någon av logik-klasserna).

Funktionalitet: En användare skall kunna lista alla djur och deras status (alltså om de har allt de behöver) i applikationen. En användare skall kunna lägga till och ta bort djur, inhägnader och skötare samt deras kompetenser.
