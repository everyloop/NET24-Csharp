# Oktober 7

**Lecture slide:**
[Asynchronus.pdf](https://github.com/everyloop/NET24-Csharp/blob/master/Resources/Asynchronus.pdf)

## Multithreading

[A gentle introduction to multithreading](https://www.internalpointers.com/post/gentle-introduction-multithreading)

## Threadpool

[Läs här!](https://en.wikipedia.org/wiki/Thread_pool)

## Task Parallell Library (TPL)

TPL är en samling klasser och API:er i .NET som underlättar asynkron och multitrådad programmering. Det gick att skriva multitrådad kod i C# även före TPL (circa 2012), men det var inte standardiserat och betydligt krångligare.

**Obs!** Man bör undvika att använda klassen Thread (new Thread()) för att manuellt skapa nya trådar i moderna program. Nu använder man istället async/await i kombination med Task och Task<TResult> typerna, vilka jobbar på en högre nivå där det är lättare att unvika många av de vanligaste fallgroparna.

[Mer om TPL här!](https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/task-parallel-library-tpl)

## Parallell LINQ (PLINQ)

Parallell LINQ (PLINQ) är en parallell implementering av LINQ (Language-Integrated Query). PLINQ kombinerar LINQ-syntaxens enkelhet och läsbarhet med kraften i parallell programmering.

[Läs här!](https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/introduction-to-plinq)

**Code-along:**  
[L041_PLINQ](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L041_PLINQ/Program.cs)

## Task och Task<TResult>

En datatyp som representerar en operation som kommer att bli klar någon gång i framtiden (d.v.s senare under programmets körning) kallas allmänt för en "future" eller "promise". De moderna "future"-typerna i .NET är Task och Task<TResult>

**Task** representar en operation som inte returnerar något värde när den är klar.

**Task<TResult>** representer en operation som kommer returnera ett värde av typ TResult.

**Code-along:**  
[L042_Tasks](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L042_Tasks/Program.cs)