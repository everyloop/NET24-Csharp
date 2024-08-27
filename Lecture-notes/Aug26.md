# Augusti 26

## Markdown

Läs [här](https://www.markdownguide.org/getting-started/) om markdown, och kolla in deras [cheat sheet.](https://www.markdownguide.org/cheat-sheet/)

## Visual studio installer
Visual studio installer används för att installera eller uppdatera befintlig installation med fler komponenter.

I installern kan man välja att istallera enskilda komponenter, men det vanligaste är att man väljer ett paket, så kallat "workload", för den typ av utveckling man ska göra. För denna kursen använder vi workload ".NET Desktop Development"

I denna kurs använder vi [Visual Studio 2022 Community](https://visualstudio.microsoft.com/downloads/)

## Visual studio

### Solution & Projects

En solution i Visual Studio kan innehålla ett eller flera projekt. Konfigurationen för lösningen, bland annat vilka projekt som ingår lagras i en .sln fil.

Varje projekt lagras sedan i en undermapp med samma namn som projektet. I projektmappen ligger en .csproj fil som innehåller konfiguration för projektet (t.ex vilken version av dotnet). I samma mapp ligger även alla .cs filer som hör till projektet.

### Build, Rebuild, Clean

För att bygga ett projekt, högerklicka på projektet i Solution Explorer och välj "Build". Detta kommer kompilera koden och bygga en körbar .exe fil.

Kolla i undermappen bin/Debug/net8.0 för att se de filer som du byggde.

Om du istället högerklickar på din solution i Solution Explorer och väljer "Build Solution" så kommer visual studio bygga samtliga projekt (som uppdaterats sedan senaste bygg) som ingår i din solution.

### Debug / Release build

Brevid den gröna "run"-knappen i Visual Studio finns en drop-down där man kan välja mellan Debug och Release. Detta är olika konfigurationer för hur projektet ska byggas, och output för dessa hamnar i två separata mappar under ditt projekts "bin"-mapp.

När du bygger för "Debug" optimeras inte din kod lika väl, samt den tar med meta-data som används för att kunna debugga/felsöka koden.

När du bygger för "Release" så kommer inte den meta-datan med, plus att den optimeras mer.

Använd "debug" under utveckling, och "release" när du vill släppa en färdig version som ska delas med användare.

## Powershell

PowerShell är ett terminalprogram från Microsoft som används för uppgiftsautomatisering och konfigurationshantering. Det bygger på .NET och exponerar även alla bibliotek och klasser från .NET så att dessa kan användas direkt i powershell.

Liknande terminal/konsoll/shell finns även för andra plattformar som t.ex Linux och Apple. Även om dessa inte bygger på .NET, så är många av de vanligaste kommandona samma.

### Vanliga kommandon i Powershell

| Kommando | Betydelse |Förklaring  | 
|--------------|------|-------------|
| ls | list | lista filer i aktuell mapp  |
| cd | change directory | byta mapp
| pwd | print working directory | Visar absolut sökväg för mappen man är i|
| cat | concatenate | printar innehållet i fil
| mkdir | make directory | skapa en ny mapp
| cp | copy | koperia &lt;source&gt; &lt;destination&gt;
| mv | move | flytta eller byta namn på fil
| rm | remove | ta bort filer och mappar
| ni | new item | skapa en ny tom fil
| code | vs code | öppnar visual studio code
| start | | "start ." öppar aktuell mapp i file explorer
| exit | | stänger ner powershell fönstret

### Absoluta och relativa sökvägar

Platsen där en fil lagras anges ofta genom att man beskriver vilka mappar och undermappar som leder till filen. Detta kallas en sökväg. Du kan ange sökvägen på två olika sätt: som en absolut eller relativ sökväg.

**En absolut sökväg** är en komplett sökväg till en fil eller katalog från rotkatalogen. I Windows anges diskenheter som en bokstav följt av ett kolon (t.ex C: som är den primära lagringsenheten i din dator). Rotkatalogen skrivs då som enheten följt av ett backslash, t.ex C:\

Exempel, absolut sökväg: "C:\Users\Fredrik\Desktop"

**En relativ sökväg** anger platsen för en fil eller katalog i förhållande till den aktuella katalogen. Relativa sökvägar börjar inte med rotkatalogen och är vanligtvis kortare än absoluta sökvägar.

Exempel, relativ sökväg: ".\Fredrik\Desktop"

### Specialtecken

Det finns även ett antal specialtecken med specifik betydelse som används för speciella ändamål i PowerShell (och andra terminalprogram):

|Namn|Tecken|Beskrivning|
|------|----|-----------|
|punkt|.|referens till mappen man står i|
|punktpunkt|..|referens till överordnad mapp (parent folder)|
|stjärna|\*|wildcard för filterering i filnamn/sökvägar|
|redirection|\>|skriver output från kommando till en fil (obs! skiver över)|
|append|\>\>|skriver output till en fil (lägger till i slutet av filen)|
|pipe|\||skickar output som input till nästa kommando|

## Git och Github

[Git](https://git-scm.com/) är ett lokalt versionskontrollsystem som låter dig hålla koll på din historik inom dina projekt, samt sparar dessa olika versioner individuellt. [GitHub](https://github.com/) är en molntjänst där du kan spara Git-projekt på nätet och dela med dig av dem till andra människor.

### Open source
Klicka [här](https://choosealicense.com/licenses/) för att läsa mer om olika open-source-licenser.


