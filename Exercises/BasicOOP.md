# Övningsuppgifter med klasser och objekt

## 1. Skriva ut namn på personer
Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName. Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.

## 2. Lägg till en metod som returnerar hela namnet
Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en sträng med hela namnet.

## 3. Lägg till en metod som returnerar namnet baklänges
Uppdatera klassen med en ny metod: public string GetFullNameReversed() som returnerar en sträng med hela namnet baklänges. Låt denna metoden använda sig av metoden i uppgift 2.

## 4. Overload av GetFullName med titel.
GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2; och en där man kan skicka in en titel, t.ex. "Dr." eller "Mr." som returnerar namnet på personen med titeln framför.

## 5. Lägg till så personer kan ha föräldrar.
Uppdatera person-klassen så att varje person kan ha en mamma och en pappa. Dessa representeras som publika fält(fields) av typen Person (eller vad du kallade klassen i uppgift 1).

## 6. Skapa ett objekt som representerar dig och dina föräldrar
Gör en instans av en person och ge den ditt för- och efternamn. Lägg även in dina föräldrars namn, kopplade till dig. Så t.ex myself.GetFullName() returnerar ditt namn, och myself.mother.GetFullName() returnerar din mammas namn.

## 7. Hämta information om dig och dina föräldrar.
Lägg till en public string GetSelfAndParents() som returnerar en sträng på formatet "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn". Om mammans eller pappans namn saknas (null) markera det med "okänd" i strängen. Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson" 

## 8. Privat fält, med metoder för att sätta och hämta värdet.
Uppdatera klassen med ett fält, *private* double length, som kan lagra längden på personen. Eftersom denna är markerad som private kommer man inte kunna läsa/skriva denna utanför klassen. Lägg därför till en metod void SetLength(double length) som sätter värdet på det privat fältet length, samt en double GetLength() som returnerar värdet på fältet length.

När du är klar ska följande kod ge utskriften 1.82
```cs
Person myPerson = new Person();
myPerson.SetLength(1.82);
Console.Write(myPerson.GetLength());
```
## 9. Vikt och BMI
Gör motsvarande för Vikt, alltså ett privat fält med publika metoder: double GetWeight() och void SetWeight(double weight). Gör sedan även en publik metod double GetBMI() som returnerar personens [BMI](https://sv.wikipedia.org/wiki/BMI_(kroppsmasseindex)). Detta ska dock *inte* finnas representerat som en private field.