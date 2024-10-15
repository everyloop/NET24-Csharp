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

## 5. Gemensam slider för position

Gör en ny version av programmet i uppgift 4, där det nya programmet bara har en slider för att välja värdet. Både x och y ska sättas till värdet man valt på slidern (0-100).

Det ska också finnas två checkboxar. En "Lock x-value." och en "Lock y-value". Dessa ska kunna låsa x- och y-värden från att uppdateras. D.v.s om man t.ex klickar i "Lock x-value" och sedan ändrar värdet på slidern så ska knappens y-värde fortfarande uppdateras, medan x-värdet uppdateras först när man klickar ur checkboxen igen.

***Förtydligande:*** *Om man klickar i båda checkboxar så ska positionen inte uppdateras alls när man ändrar värdet, förrän man klickar ur checkboxarna: då "hoppar" labeln till sin nya position.*

## 6. Formulär för studenter

Utgå från [XAML-uppgift 8 ("Formulär för studenter")](https://github.com/everyloop/NET24-Csharp/blob/master/Exercises/XAML.md), men ta bort "OK"-knappen.

Lägg till funktionalitet så att när man väljer en student i listan så visas den studentens förnamn, efternamn och email i formuläret till höger i fönstret; och om man uppdaterar något i formuläret så uppdateras den studenten i listan. 

***OBS!*** *Email visas inte i listan, men behöver ändå lagras så det nya värdet finns kvar när man växlar mellan studenterna via listan.*

## 7. Lägg till och ta bort studenter

Uppdatera programmet i uppgift 6 med en knapp för att lägga till, och en knapp för att ta bort studenter.

Om ingen student är vald ("selected") i listan så ska "ta bort"-knappen vara inaktiverad (disabled); annars ska den valda studenten tas bort när man klickar på "ta bort"-knappen.

Om man klickar på "lägg till"-knappen så lägg till en ny student i listan med förnamn "New", och tomma strängar för efternamn och email.

## 8. Lägg till en meny i programmet

Man kan skapa menyer med [\<Menu\> och \<MenuItem\>](https://wpf-tutorial.com/common-interface-controls/menu-control/).

Lägg till en meny i toppen av student appen med "File" och "Edit".

Under "File" ska det finnas ett "Exit" alternativ som avslutar programmet om man klickar på den.

Under "Edit" ska det finnas en "Add Student" och en "Remove Student"; dessa ska fungera likadant som knapparna från förra uppgiften.

***OBS!*** *Knapparna ska fortfarande finnas kvar och fungera som tidigare. Om ingen student är markerad i listan så måste både "Remove"-knappen, och motsvarande meny-alternativ bli "disabled".*

## 9. Lägg till en context menu i programmet

En [\<ContextMenu\>](https://wpf-tutorial.com/common-interface-controls/contextmenu/) är den typ av meny som dyker upp när man högerklickar på något element i programmet.

När man högerklickar i listan (\<ListBox\>) med studenter så ska man få upp en meny med alternativen "Add Student" och "Remove Student".

Det ska alltså finnas ytterligare ett sätt att lägga till och ta bort studenter.

***OBS!*** *Alla tre sätten ska fungera, och alla tre "Remove" måste bli enabled/disabled beroende på om det finns någon studenten som är "selected".*

## 10. Siffror i rutnät
Skapa ett nytt program, som när det startar ser ut ungefär som [XAML-uppgift 6 ("Siffror i rutnät")](https://github.com/everyloop/NET24-Csharp/blob/master/Exercises/XAML.md), med skillnaden att det istället är 10x10 \<Label\>-element med siffrorna 0-99.

## 11. Siffror i rutnät med dynamisk storlek

Lägg till en slider i programmet ovan som man kan sätta till heltal från 1 till 10.

När värdet på slidern är 1 visas en label med värdet 0. 

När värdet på slidern är 2 visas 4 label i ett 2x2 rutnät, med värden 0-3.

När värdet på slidern är 3 visas 9 label i ett 3x3 rutnät, med värden 0-8.

...

När värdet på slidern är 10 visas 100 label i ett 10x10 rutnät, med värden 0-99.

## 12 Knappar i rutnät

Gör om programmet i uppgift 10 så att det använder knappar i stället för label för att visa siffrorna. Initialt ska knapparna visa siffrorna 0-99 på samma sätt som i uppgift 10.

Varje gång man klickar på en knapp så ska siffran räkna ner med 1. När en knapp kommer till 0, och man klickar en gång till så ska knappen börja om från det värde som den hade när programmet startade.

D.v.s. den första knappen visar alltid 0; den andra knappen växlar mellan 1 och 0; den tredje växlar 2, 1, 0, och tillbaka till 2. etc. etc.



