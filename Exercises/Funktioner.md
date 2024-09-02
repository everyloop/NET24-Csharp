# Övningsuppgifter med funktioner

## 1. Slå ihop för- och efternamn - skriv ut
Skriv en funktion som tar två parametrar: firstName och lastName. Funktionen ska skriva ut hela namnet på skärmen. Testa genom att anropa funktionen med ditt namn.

**Exempel:**
```
PrintName("Fredrik", "Johansson");
```
*Skriver ut:* Fredrik Johansson

## 2. Slå ihop för- och efternamn - returnera
Skriv om funktionen ovan så att den istället för att skriva ut namnet returnerar en string med hela namnet. Anropa funktionen och skriv ut returvärdet.

## 3. Kolla om stängen är längre än ett givet antal tecken.
Skriv en funktion som tar in en sträng och ett heltal. Om längden på strängen är större än heltalet returnera true, annars false.

## 4. Omvandla Celsius till Fahrenheit
Skriv en funktion som översätter ett värde från Celsius till Fahrenheit. Både in-parameter och returvärde ska vara av datatyp double.

## 5. Lägg in bindesträck mellan tecken i en sträng

Skriv en funktion som tar in en sträng och returnerar en sträng med ett bindestreck mellan varje tecken. T.ex om man skickar in “Fredrik” , så returnerar den “F-r-e-d-r-i-k”

## 6. Egen version av String.Join();

Skriv en egen funktion som fungerar på samma sätt som String.Join();

**Exempel:**
```
MyJoin("->", "Sverige", "Norge", "Finland");
```
*Returvärde:* "Sverige->Norge->Finland"

## 7. Beräkna medelvärde av int-array
Skriv en funktion som tar en int[] in, och returnerar medelvärdet som en double.

## 8. Siffror till text
Skriv en funktion som tar ett heltal in, och returnerar en string[] där varje element innehåller ordet för varje siffra i talet.

**Exempel:**
```
NumberToWords(6543);
```
*Returvärde:* {"sex", "fem", "fyra", "tre"}

## 9. Heltal till text
Skriv en funktion som tar en *ushort* som parameter, och returnerar en sträng med numret utskrivet i ord.

**Exempel:**
```
IntegerToText(6543);
```
*Returvärde:* "six thousand five hundred forty three"

## 10. Hitta index för alla förekomster av ett givet tecken.
Skapa funktionen int[] IndexesOf(string text, char c) som söker igenom strängen text och returnerar en int[] med index till alla förekomster av *c* i *text*.

**Exempel:**
```
IndexesOf("Hello World!", 'o');
```
*Returvärde:* {4, 7}

## 11. Kasta tärning
Skriv en funktion ThrowDice() som returnerar ett slumpmässigt heltal 1-6. Skriv en annan funktion ThrowMultipleDice(int n) som returnerar resultatet av att man slagit *n* tärningar.

***Extra utmaning:*** *Lägg till en frivillig(optional) int på båda funktionerna, där man kan ange antal sidor på tärningen (default 6).*

***Tips:*** Kolla exempelkoden för [Random.Next()](https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-8.0) för att få ut slumpmässiga heltal. 

## 12. Rita en box
Skriv en funktion *DrawBox(int width, int height)*.
När man anropar funktionen ska den skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’.

**Exempel:** DrawBox(7, 4);
```
#######
#-----#
#-----#
#######
```

***Extrauppgift:*** *Uppdatera funktionen och lägg till parametrar left och top (för positionen på översta vänstra hörnet av boxen. Skriv en loop som printar ut rektanglar med random storlek och position på skärmen.* 

***Tips:*** *Använd [Console.SetCursorPosition();](https://learn.microsoft.com/en-us/dotnet/api/system.console.setcursorposition?view=net-8.0) för att flytta Cursorn, d.v.s var nästa tecken ska skrivas. Om du vill kan du även dölja cursorn genom att sätta [Console.CursorVisible = false;](https://learn.microsoft.com/en-us/dotnet/api/system.console.cursorvisible?view=net-8.0)*

***Tips:*** *Använd [Thread.Sleep(n);](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-8.0) för att lägga in en fördröjning på n millisekunder innan nästa rektangel ritas ut.*

## 13. Flytta runt ett @ med piltangenterna.
Låt oss skriva början till ett enkelt spel:

Använd DrawBox-funktionen i föregående uppgift för att rita en box på skärmen. Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man kunna flytta runt @. 
När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.

***Tips:*** *För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen. Spara bredd och höjd på boxen så du vet när den ska stanna.*

***Tips:*** *Kolla upp [Console.ReadKey();](https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-8.0) och [Console.KeyAvailable;](https://learn.microsoft.com/en-us/dotnet/api/system.console.keyavailable?view=net-8.0)*

## 14. Masken
Skriv om DrawBox() så den istället returnerar en 2D-array av char med tecknen som den tidigare skrev ut på displayen. Man ska också kunna mata in en tredje parameter för antal slumpade ‘#’. Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen. 

Skriv sedan en annan funktion som tar och ritar ut arrayen på skärmen. Fixa så man kan flytta runt @ med piltangenterna. Jämför positionen mot arrayen och gör så man inte kan gå på någon '#'.

***Extra utmaning:*** *Gör en "orm" av '@'. När man flyttar positionen på @ så följer (t.ex) 5 andra @ efter i samma spår som man förflyttat sig.*

***Extra utmaning 2:*** *I det klassiska spelet "masken" (snake) förflyttar sig en mask i jämna tidsintervall i den riktning spelaren senast angav med piltangenterna. Någonstans på banan finns ett äpple masken ska äta. Det gäller för spelaren att ta sig dit utan att krocka med något hinder, eller sin egen svans. När man tar äpplet blir masken längre och ett nytt äpple dyker upp på slumpvis vald plats på banan.*

*Implementera din egen version av spelet. Försök dela in koden i lämpliga funktioner.*

***Förslag:*** *När du fått en första version av spelet att fungera, lägg till flera banor genom att hårdkoda in olika banlayout i olika 2D-arrayer. När man tagit ett visst antal äpplen på en bana så kommer man vidare till nästa.*
