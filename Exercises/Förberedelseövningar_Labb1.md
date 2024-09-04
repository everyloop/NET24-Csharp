# Förberedelseövningar - Labb 1

Här har ni fler övningsuppgifter med loopar och indexering av strängar. Dessa kan vara bra att lösa innan man ger sig på labb 1, då ni kommer lära er en del saker som kan hjälpa er på labben.

## 1. Bokstav för bokstav - fram till space
Utgå från strängen (skapa en variabel med) "Hello World!", skriv ut hela strängen bokstav för bokstav, men avsluta när det kommer ett space. (Den ska alltså bara skriva “Hello”).

## 2. Bokstav för bokstav - radbyte på space
Utgå från strängen "This is just some other text". Skriv ut strängen bokstav för bokstav, men när det kommer ett space, gör radbyte istället. (Du ska få ett ord på varje rad).

## 3. Bokstav för bokstav - varannan stjärna
Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för bokstav. Men om index är en jämn siffra, skriv istället ut *

## 4. Bokstav för bokstav - gröna o, röda l
Utgå från strängen "Hello world!". Skriv ut bokstav för bokstav. Alla 'o' ska vara grön färg, alla 'l' ska vara röd färg. Övriga bokstäver är vita/grå.

## 5. Bokstav för bokstav - dubbla med grön färg
Utgå från strängen "Hello world". Skriv ut bokstav för bokstav. Om två tecken på rad är samma så ska dessa vara grön färg. Övriga bokstäver är vita/grå.

## 6. Bokstav för bokstav - grön substring
Utgå från strängen "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", samt den mindre strängen "oo". Skriv ut den långa strängen bokstav för bokstav. Varje gång den mindre strängen förekommer (två 'o' på raken) så ska dessa vara med grön färg. Övriga bokstäver är vita/grå.

## 7. Bokstav för bokstav - grön substring 2
Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo". D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.

## 8. Bokstav för bokstav - grön substring 3
Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen, alltså valfri text som ska sökas (färgas grön) i den längre texten.

## 9. Bokstavspyramid
Utgå från strängen "Hello world!". Gör ett program som skriver ut första bokstaven en gång på första raden. Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. Alltså:
```
H
ee
lll
... etc
```

## 10. Ordpyramid
Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”. Gör ett program som skriver ut första ordet en gång på första raden; andra ordet två gånger på nästa rad. Tredje ordet tre gånger på nästa. etc. alltså:
```
How
much much
wood wood wood
... etc
```

## 11. Ordpyramid 2
Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”. Gör ett program som på första raden skriver ut första ordet. På nästa rad skriver ut de två första orden, sedan de tre första orden på nästa rad o.s.v till man kommit till raden som skriver ut hela meningen. Alltså:
```
How
How much
How much wood
... etc
```

## 12. Rödmarkerade ord
Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad. På första raden ska första ordet vara rött (övriga vita), på andra raden ska andra ordet vara rött. På tredje raden ska tredje vara rött osv. Alltså:

<span style="color:red; font-weight:bold">How</span> much wood would a woodchuck chuck if a woodchuck could chuck wood?  
How <span style="color:red; font-weight:bold">much</span> wood would a woodchuck chuck if a woodchuck could chuck wood?  
How much <span style="color:red; font-weight:bold">wood</span> would a woodchuck chuck if a woodchuck could chuck wood?  
... etc

## 13. Rödmarkerade bokstäver
Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad. På första raden är de 5 första tecknen röda. På nästa rad är “bcdef” röda, sedan “cedfg” osv.. alltså alltid 5 tecken, men de flyttas ett steg åt höger för varje rad, tills sista raden har “vwxyz” rödfärgad. Alltså:

<span style="color:red; font-weight:bold">abcde</span>fghijklmnopqrstuvwxyz  
a<span style="color:red; font-weight:bold">bcdef</span>ghijklmnopqrstuvwxyz  
ab<span style="color:red; font-weight:bold">cdefg</span>hijklmnopqrstuvwxyz  
... etc

## 14. Rödmarkerade bokstäver 2
Användaren matar in valfri sträng. Programmet skriver ut hela strängen bokstav för bokstav. Alla bokstäverna är röda fram tills du stöter på ett tecken som är samma som första tecknet i strängen. Därefter skriver den ut resten av bokstäverna med vit/grå färg. Några exempel vid olika inmatningar/körningar:

<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
<span style="color:red; font-weight:bold">hh</span>fgijff  
<span style="color:red; font-weight:bold">fjpdpog</span>  


## 15. Rödmarkerade bokstäver 3
Användaren matar in valfri sträng. Programmet skriver sedan ut en hela strängen flera gånger. På första raden börjar den skriva med röd färg på första bokstaven och fram tills den hittar samma bokstav igen. På andra raden börjar den skriva med röd färg på andra bokstaven och fram tills den hittar samma bokstav igen. På tredje raden börjar den skriva med röd text på tredje bokstaven och fram tills den hittar samma igen... etc. Om man t.ex matar in “ajdfhvajhdfd” blir det då:

<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
a<span style="color:red; font-weight:bold">jdfhvaj</span>hdfd  
aj<span style="color:red; font-weight:bold">dfhvajhd</span>fd  
ajd<span style="color:red; font-weight:bold">fhvajhdf</span>d  
... etc
