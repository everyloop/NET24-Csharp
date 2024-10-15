# Övningsuppgifter med några vanliga UI element i WPF

## 1. Klickräknare

Bygg ett program med en knapp som håller reda på hur många gånger man klickat på den.

Det ska stå "Click: X" på knappen, där X är antalet gånger man klickat på knappen.

## 2. Räkna upp och ner i en label.

Gör ett program med en label som initialt visar värdet 5. Det ska finna en knapp "Increase" och en knapp "Decrease". Genom att klicka på knapparna ska man kunna öka eller minska värdet som visas på label, ett steg i taget. Värdet ska dock aldrig kunna bli lägre än 0, eller högre än 9.

## 3. Lägg till Slider

Uppdatera programmet i uppgift 2 så att det även finns en slider som kan sättas från 0 till 9 (i hela steg, alltså endast heltal). Om man flyttar slidern så kan värdet på labeln ändras. Observera att knapparna fortfarande ska finnas kvar, fungera som förut, och även uppdatera slidern.

## 4. Label med valbar position

Skapa ett nytt program med en label som visar sin egen x- och y-position (T.ex: "x = 43, y= 89")

Skapa en slider för att ställa in x-positionen mellan 0-100, och en slider som gör det samma för y-positionen.

När man drar i sliders så ska labelns position uppdateras. D.v.s både texten som skrivs i labeln så den reflekterar valda värden på x och y; och dessutom labelns faktiska position i fönstret.

***Bonus:*** *Lägg gärna till en label i anslutning till vardera slider så att det tydligt framgår vad varje slider gör. T.ex: "x-position:", respektive "y-position:"*

# 5. Gemensam slider för position

Gör en ny version av programmet i uppgift 4, där det nya programmet bara har en slider för att välja värdet. Både x och y ska sättas till värdet man valt på slidern (0-100).

Det ska också finnas två checkboxar. En "Lock x-value." och en "Lock y-value". Dessa ska kunna låsa x- och y-värden från att uppdateras. D.v.s om man t.ex klickar i "Lock x-value" och sedan ändrar värdet på slidern så ska knappens y-värde fortfarande uppdateras, medan x-värdet uppdateras först när man klickar ur checkboxen igen.

***Förtydligande:*** *Om man klickar i båda checkboxar så ska positionen inte uppdateras alls när man ändrar värdet, förrän man klickar ur checkboxarna: då "hoppar" labeln till sin nya position.*