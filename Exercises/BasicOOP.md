# Övningsuppgifter med klasser och objekt

## 1. Skriva ut namn på personer
Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName. Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.

## 2. Lägg till en metod som returnerar hela namnet
Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en sträng med hela namnet.


## 3. Lägg till en metod som returnerar namnet baklänges
Uppdatera klassen med en ny metod: public string GetFullNameReversed() som returnerar en sträng med hela namnet baklänges. Låt denna metoden använda sig av metoden i uppgift 2.

## 4. Overload av GetFullName med titel.
GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2; och en där man kan skicka in en titel, t.ex. "Dr." eller "Mr." som returnerar namnet på personen med titeln framför.

