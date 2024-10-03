# Oktober 3

## Language Integrated Queries (LINQ)

LINQ lägger till funktionalitet för databehandling på IEnumerable interfacet med hjälp av extension methods. Det betyder att alla typer som implementerar IEnumberable, så som t.ex arrayer och listor, får ett gäng nya metoder för att enkelt göra operationer på hela datamängden i en collection.

[Querying made easy](https://medium.com/@jepozdemir/exploring-linq-in-c-querying-made-easy-f06a590e5a89)

Några användbara metoder är till exempel:

**ofType** används för att filtrera ut objekt av en given typ.

**any** används för att kolla om *något* av elementen i en collection uppfyller ett givet vilkor; returnerar true/false.

**all** används för att kolla om *alla* elementen i en collection uppfyller ett givet vilkor; returnerar true/false.

**where** används för att filtrerar ut alla element som uppfyller ett givet vilkor; returnerar en IEnumerable som kan användas för deferred execution, eller omvandlas till t.ex en array eller lista.

**select** används för att skapa nya element utifrån ett givet vilkor; returnerar en IEnumerable som kan användas för deferred execution, eller omvandlas till t.ex en array eller lista.

**Code-along:**  
[L039_LINQ](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L039_LINQ/Program.cs)