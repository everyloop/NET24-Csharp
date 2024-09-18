# Övningsuppgifter med properties

## 1. Person med property FirstName
Skapa en klass "Person" som har en private field _firstName, och en public property FirstName. När man sätter värdet på FirstName ska detta sparas i _firstName, och när man läser värdet på FirstName ska den returnera det som finns lagrat i _firstName.

## 2. Autoproperty LastName
Lägg till en publik auto-property LastName som går att både läsa och skriva.

## 3. Read-only property FullName
Lägg sedan till en publik property FullName som är read only (bara get;) När man läser av propertyn så ska den returnera hela namnet. Testa koden genom att skapa ett objekt, tilldela värden på både FirstName och LastName, och sedan skriva ut FullName.

## 4. Stegräknare
Skapa en klass som kan användas som stegräknare. Den ska ha en property "Steps" som bara går att läsa; en metod Step() som räknar upp Steps med 1 varje gång man anropar den; och en metod Reset() som nollställer räknaren.

Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.

## 5. Bil
Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg. Skapa publika properties för att hämta eller ändra värdet på varje field.

Skriv en konstruktor till bilklassen som inte tar några parametrar. Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa. Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på bilen sänkas till hälften.

## 6. Vattenglas
Skriv en klass som representerar ett vattenglas. Den ska ha en metod för att fylla glaset, och en metod för att tömma glaset. Dessutom ska den ha en private field som håller reda på om glaset är tomt eller fullt. Beroende på tillståndet (tomt/fullt) så ska metoden som fyller glaset skriva ut antingen “Fyller glaset” eller “Glaset är redan fullt”. Den andra metoden ska skriva ut “Tömmer glaset” eller “Glaset är redan tomt”.

**Extra övning:** Lägg till ytterligare en metod för att slå sönder glaset. Varje glas (instans) ska hålla reda på sitt tillstånd, och skriva ut vad som händer när man kör de olika metoderna. (t.ex “Glaset går sönder, och vattnet rinner ut på golvet”, eller “Glaset kan inte fyllas, eftersom det är trasigt” osv.)

## 7. Blå & Röd 
Skapa en en klass som har en property “Red” och en property “Blue”. Båda ska vara en double och kunna ha ett värde mellan 0.0 och 100.0  men de ska vara “sammankopplade” på så vis att värdena tillsammans alltid är 100.0 d.v.s om man t.ex. sätter “Blue” till 8.5 och sedan läser av “Red” så ska den returnera 91.5

