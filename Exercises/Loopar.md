# Övningsuppgifter med loopar

## 1. Skriv talen 20 till 30

Skriv en loop som skriver ut alla tal från 20 till  30.

**Exempel:**
```
20
21
...
29
30
```

## 2. Jämna tal

Skriv en loop som skriver ut alla jämna tal från 0 till 30.

**Exempel:**
```
0
2
...
28
30
```

## 3. Var tredje "Hej"

Skriv en loop som skriver ut tal från 0 till 30, men om talet är jämnt delbart med 3 skriv istället “Hej”

**Exempel:**
```
"Hej"
1
2
"Hej"
4
...
29
"Hej"
```

## 4. Gångertabell

Gör ett program som ber användaren mata in ett tal, skriv ut det talets “gångertabell” dvs, multiplikationer av talet med alla tal från 1 t.o.m. 10.

**Exempel:**
```
Skriv in ett tal: 4
1 * 4 = 4
2 * 4 = 8
...
10 * 4 = 40
```

## 5. Summa

Summan av alla tal 1 till 4, är 10 (1+2+3+4). Gör ett program som räknar ut summan av alla tal 1 till 1000.

## 6. Riskorn på shackbräde

Enligt legenden så fick den man som hade konstruerat det formidabla spelet
schack önska sig något värdefullt av den
överförtjuste kungen. Monarken blev förvånad över uppfinnarens anspråkslöshet när gåvan skulle bestå av riskorn.

Antalet riskorn bestämdes enligt följande regel:
ett korn skulle lämnas för första rutan på ett
schackbräde, två korn för andra rutan, fyra
för tredje, åtta för fjärde och så ändå till den
sista rutan. 

Skriv ett program som hjälper kungen att beräkna antalet riskorn på vardera ruta.

**Exempel:**
```
Ruta 1: 1
Ruta 2: 2
Ruta 3: 4
Ruta 4: 8
Ruta 5: 16
...
Ruta 64: ???
```

## 7. Fylld box

Gör ett program som ber användaren mata in höjd och bredd. Printa ut en “box” med bokstaven X på skärmen med den höjd och bredd som matats in.

**Exempel:**
```
Mata in höjd: 3
Mata in bredd: 5
XXXXX
XXXXX
XXXXX
```

## 8. Randig box

Samma som uppgift 7, men för varannan kolumn skrivs bokstaven O istället för X.

**Exempel:**
```
Mata in höjd: 3
Mata in bredd: 5
XOXOX
XOXOX
XOXOX
```

## 9. Rutig box

Samma som uppgift 8, men med ett schackrutemönster.

**Exempel:**
```
Mata in höjd: 3
Mata in bredd: 5
XOXOX
OXOXO
XOXOX
```

## 10. Ihålig box

 Fråga efter bredd och höjd och skriv ut en “box” som inte är fylld.

**Exempel:**
```
Mata in höjd: 4
Mata in bredd: 5
XXXXX
X   X
X   X
XXXXX
```

## 11. Sifferpyramid

Gör ett program som skriver “1” på första raden, “12” på nästa, sen “123” osv upp till rad 9 där det står “123456789”

**Exempel:**
```
1
12
123
...
123456789
```

## 12. Nio sifferpyramider

Gör ett program som skriver ut “pyramider” som i uppgiften ovan, den första ska vara med en rad, följt av en pyramid med 2 rader, sen 3 rader etc. ända upp till 9 rader i den sista pyramiden.

**Exempel:**
```
1

1
12

1
12
123

...
12345678
123456789
```

## 13. Primtal

Primtal är heltal större än 1 som inte går att jämnt dela med något annat heltal (förutom 1 eller talet själv, eftersom alla tal är delbara med sig själva och 1).
De 5 första primtalen är 2, 3, 5, 7, 11.
Skriv ett program som listar de första 20 primtalen.

## 14. Spel - Gissa tal
Gör ett gissa-spel som har ett hemligt nummer (lagrat i en variabel i koden) mellan 1 och 100. När spelet startar ombeds spelaren att gissa ett tal mellan 1-100. Gissar man för lågt skriver programmet ut att man gissat för lågt, och man får gissa igen. Gissar man för högt skriver programmet att man gissat för högt och man får gissa igen. Gissar man rätt så skriver programmet att man gissat rätt, samt antal gissningar som krävdes för att gissa rätt.

***Extrauppgift:*** *Klassen “Random” i .NET kan användas för att sätta den hemliga variabeln till ett slumpmässigt tal 1-100. Googla “C# Random” och se om du får det att fungera så det blir olika tal varje gång man kör programmet.*

***Extrauppgift 2:*** *Gör så att datorn själv (automatiskt) spelar spelet, och gissar tal. Skriv ut output precis som innan så man kan följa hur den spelat. Försök få den att lösa det så effektivt (så få drag) som möjligt.*

## 15. Sten, sax, påse
Skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”. Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången. Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). Skriv även ut poäng.
