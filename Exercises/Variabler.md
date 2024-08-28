# Övningsuppgifter med variabler

## 1. Hälsa på användaren

Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.

**Exempel:**
```
Skriv ditt namn: David
Hej David!
```

## 2. Multiplicera två tal
Skriv ett program som ber användaren mata in två heltal. Skriv ut talen multiplicerade med varandra.

**Exempel:**
```
Skriv in första talet: 5
Skriv in andra talet: 12
5 * 12 = 60
```
*Tips: Använd Int32.Parse();*

## 3. Verifiera lösenord
Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det i en variabel. När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

**Exempel:**
```
Lösenord: abc123
Fel lösenord!
```

## 4. Jämför tal
Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är mindre, större eller lika med 100.

**Exempel:**
```
Skriv ett tal: 45
Ditt tal är mindre än 100.
```

## 5. Dubblera och halvera tal
Be användaren mata in ett tal. Skriv ut talet som är dubbelt, respektive hälften.

**Exempel:**
```
Skriv in ett tal: 5
10 är dubbelt så mycket som 5.
2.5 är hälften så mycket som 5.
```

## 6. Miniräknare
Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, * eller /. Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare. Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.


**Exempel:**
```
Första talet: 7
Välj +, -, *, /: +
Andra talet: 2
7 + 2 = 9
```

## 7. Summa och medelvärde
Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.

**Exempel:**
```
Skriv in ett tal: 3
3
Skriv in ett tal: 2
5
Skriv in ett tal: 7
12
Skriv in ett tal:
Medelvärde: 4
```
*Tips: Kolla upp TryParse();*
