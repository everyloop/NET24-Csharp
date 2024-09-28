# September 25

## Tydlig kod

### Namngivning
Att ge tydliga och beskrivande namn på variabler, metoder, funktioner, klasser etc, är en av de viktigaste sakerna man kan göra för att göra koden mer lättläst.

**Enhetligt**  
Blanda inte svenska/engelska.  
Blanda inte kodkonventioner. T.ex vissa variabler i PascalCase och andra i camelCase.
Använd inte olika begrepp för samma sak. T.ex. studentName/numberOfPupils

**Verb för namn på metoder/funktioner**  
static string GetName();

**Substantiv för namn på variabler/objekt/klass**  
singular för enskilda variabler, plural på collections (ex: array, lista, stack).

string city;  
string[] cities;

**Unvik namn som är förvirrande lika**  
public double[] CalculateAreaForAll(Circle[] circles);  
public double[] CalculatedAreaForAll(Circle[] circles);

**Namn som går att uttala**  
Det är svårt att kommunicera sin kod i samtal om variabler heter t.ex. xdf98d

**Clarity over entertainment value**

Farenheit2Celsius

**Case**
camelCase   I c# på lokala variabler och parameterar (till metoder/funktioner)
PascalCase  I c# på allt annat (t.ex klasser, metoder, properties)
kebab-case  Använd ej i c#
snake_case  Använd ej i c#

**Namngivning av bool**
Variabler av typ bool börjar ofta med is/are/has.

### Magiska nummer

int numberOfDays
int numberOfDaysPerWeek = 7;
int numberOfWeeks = numberOfDays / numberOfDaysPerWeek;
int numberOfVacationWeeks
bool hasVacationWeeksLeft = numberOfWeeks < numberOfVacationWeeks;

if (hasVacationWeeksLeft && ... && ...)
{

}

### Funktioner / Metoder

Namn i verbform, som antyder att något utförs.

Metoder bör vara korta.

Varje metod gör bara en (1) sak, utan bieffekter.

Metoder bör helst ta så få parametrar som möjligt.

**The Stepdown Rule** tells us that we should organize our code so that we can read the code top-to-bottom and each function call descends by one level of abstraction.

[Läs mer här!](https://github.com/Geeksltd/Programming.Tips/blob/master/docs/methods/stepdown-rule.md)