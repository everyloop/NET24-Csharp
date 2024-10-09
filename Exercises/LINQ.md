# Övningsuppgifter med LINQ

## 1. Anonyma datatyper
Skapa en array "people" med anonyma datatyper. Varje objekt i arrayen ska ha följande properties: FirstName, LastName, Age, Height, Weight. 

Lägg till minst 8 sådana objekt i arrayen.

Använd dig sedan av LINQ för att lösa följande uppgifter:

## 2. Filtrera på ålder
Filtrera arrayen (uppgift 1) så du får en ny lista med endast de användare som är mellan 20 och 40 år gamla. 

## 3. Är någon längre än 190 cm?
Är någon av personerna mellan 20 och 40 år längre än 190 cm lång?

## 4. Filtrera på namn
 Filtrera arrayen från uppgift 1 så att du får en ny lista med endast de användare vars förnamn är längre än efternamnet (d.v.s större antal bokstäver). I den nya listan vill vi att objekten ska ha endast properties FirstName och LastName.

## 5. Hela namnet tillsammans med BMI
Skapa en ny lista från arrayen (från uppgift 1) som innehåller objekt med properties Name (hela namnet), samt BMI (uträknat från längd och vikt) för alla personer.

## 6. Filtrera listan ovan på BMI
Filtrera listan (från uppgift 5) så att du endast får med personer med BMI under 20 eller BMI över 25.

## 7. Filtrera orginallistan på BMI
Filtrera arrayen (från uppgift 1) så att du endast får med personer med BMI under 20 eller BMI över 25.

## 8. Username tillsammans med Category 
Skapa en ny lista från arrayen (i uppgift 1) som innehåller objekt med properties Username (förnamnet + åldern, ex. “Kalle23”), samt Category (som har värdet “Child” eller “Adult” beroende på om personen är under 18 eller inte).

## 9. Query syntax
Lös alla uppgifter 2 - 8 med query-syntax (om du använt method-syntax, annars tvärtom).

## 10. Sortera efter längd
LINQ använder metoderna .OrderBy() och .OrderByDescending() för att sortera data.

Skriv ut alla personer (från uppgift 1) i längdordning (kortast först).

## 11. Sortera äldst till yngst
Skriv ut alla personer (från uppgift 1) sortera efter ålder; från äldst till yngst.

## 12. Sortering i första och andra hand
Efter .OrderBy eller .OrderByDescending() kan man använda .ThenBy() och .ThenByDescending() för att sortera på något annat i andra hand (om flera objekt har samma värden i första sorteringen).

Skriv ut alla personer (från uppgift 1) sorterade på efternamn i stigande ordning (A -> Z). Om flera personer har samma efternamn, sortera dessa på förnamn i fallande ordning (Z -> A).

## 13. LINQ vs PLINQ
Använd Enumerable.Range() för att skapa en sekvens av tal från 1 upp till 1 miljard. Filtrera sedan sekvensen på så vis att du får endast de tal som är jämnt delbara med 3 eller 5. Beräkna summan av talen.

**OBS!** Använd inte ToList() ovan, då detta till skillnad från Enumerable faktiskt skapar upp alla tal i minnet.

Sätt breakpoints i din kod och använd debuggern för att kolla hur lång tid det tar att exekvera.

Prova sedan att köra samma beräkning som parallell LINQ; jämför tiden det tar att exekvera.