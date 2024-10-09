# Övningsuppgifter med delegat och lambda

## 1. Deklarera en egen delegat-typ

Skriv en metod som tar två strängar: firstName och lastName. Metoden ska returnera en ny sträng som är hela namnet. Deklarera en delegat-typ, och gör en variabel som är en referens till metoden. Anropa metoden via delegatet.

## 2. Använd generiskt delegat
Ändra koden i uppgiften ovan så att den använder ett generiskt delegat istället för den du själv deklarerade.

## 3. Metod som tar delegat som inparameter
Skriv en ny metod som också tar firstName och lastName. Denna metoden ska returnera en sträng som innehåller variabelnamnen och dess värden på två rader.

Exempel:
```
firstName: Fredrik
lastName: Johansson
```

Skriv sedan en metod som tar ett generiskt delegat (som matchar metoden ovan) som inparameter. Metoden ska, i tur och ordning, anropa delegatet med 3 olika för- och efternamn och skriva ut resultatet. Testa att anropa denna metod först med en referens till metoden i uppgift 1 och sedan med metoden ovan (uppgift 3).

## 4. Skriv ut summan av två värden
Skapa ett generiskt delegat med ett lambda uttryck som tar två tal och skriver ut summan av dessa på konsolen. Testa genom att anropa med två värden.

## 5. Returnera summan av två värden
Skapa ett generiskt delegat med ett lambda uttryck som tar två tal och returnerar summan av dessa. Testa genom att anropa med två värden, och skriva ut resultatet.

## 6. Lambda som argument
Anropa metoden (den som tar ett generiskt delegat) i uppgift 3. Som argument skriver du ett lambdauttryck som returnerar en string med antal tecken i namnen:
Ex. "firstName has 7 letters, lastName has 9 letters."

## 7. Modifiera utskrift med lambdauttryck 
Skriv en metod som tar en string[] som inparameter och skriver ut alla strängar i arrayen på varsin rad. Uppdatera sedan metoden så att den tar en andra parameter: Func<string, string> modifier, och anropa modifier() på varje string i arrayen innan du skriver ut den.

Skapa en en string[] med namnen på fem städer som du kan skicka in i metoden.

Gör 3 anrop till metoden (med olika lambda-uttryck):
- Ett som skriver ut alla städer i UPPERCASE
- Ett som skriver ut de 3 första tecknen i varje stad
- Ett som skriver ut längden på varje stads namn.

## 8. Filtrera array (utskrift)
Skapa en metod som tar en array med heltal, samt ett delegat som tar en int som inparameter och returnerar en bool. Metoden ska sedan anropa delegatet för varje tal i arrayen och endast skriva ut de tal som returnerar true.

Skapa en int[] med 10 tal som du kan skicka in i metoden:

Gör 3 anrop till metoden:
- Ett som listar alla negativa tal
- Ett som listar alla tal mellan 10 och 20
- Ett som listar alla jämna tal

## 9. Filtrera array (till ny array)
Gör om metoden i uppgift 8 så att den istället för att skriva ut talen returnerar en ny array med de tal som matchar villkoren i lambdautrycket man skickar in.

