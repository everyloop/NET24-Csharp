# Augusti 26

## Visual studio installer
Visual studio installer används för att installera eller uppdatera befintlig installation med fler komponenter.

I installern kan man välja att istallera enskilda komponenter, men det vanligaste är att man väljer ett paket, så kallat "workload", för den typ av utveckling man ska göra. För denna kursen använder vi workload ".NET Desktop Development"

## Visual studio

### Solution & Projects

En solution i Visual Studio kan innehålla ett eller flera projekt. Konfigurationen för lösningen, bland annat vilka projekt som ingår lagras i en .sln fil.

Varje projekt lagras sedan i en undermapp med samma namn som projektet. I projektmappen ligger en .csproj fil som innehåller konfiguration för projektet (t.ex vilken version av dotnet). I samma mapp ligger även alla .cs filer som hör till projektet.

### Build, Rebuild, Clean

För att bygga ett projekt, högerklicka på projektet i Solution Explorer och välj "Build". Detta kommer kompilera koden och bygga en körbar .exe fil.

Kolla i undermappen bin/Debug/net8.0 för att se de filer som du byggde.

Om du istället högerklickar på din solution i Solution Explorer och väljer "Build Solution" så kommer visual studio bygga samtliga projekt (som uppdaterats sedan senaste bygg) som ingår i din solution.



### Debug / Release build


## Powershell

### Absoluta och relativa sökvägar

- . referens till mappen man står i
- .. är referens till parent folder
- \* wildcard för filterering i filnamn/sökvägar
- \> skriver output till en fil (obs! skiver över)
- \>\> lägger til (append) output till en fil
- | skickar output som input till nästa kommando

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
| start | | start . öppar akutell mapp i file explorer



