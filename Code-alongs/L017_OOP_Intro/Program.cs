
Cat myCat = new Cat() { name = "Pelle", age = 3 };
Cat myOtherCat = new Cat() { name = "Måns", age = 5 };
Cat myThirdCat = new Cat() { name = "Sven", age = 12 };

myOtherCat.Greet();
myOtherCat.Greet("Fredrik");
myThirdCat.Greet("Fredrik");
myCat.Greet(myThirdCat);

class Cat
{
    public string name = "default name";

    public int age = 0;

    public void Greet()
    {
        Console.WriteLine($"Hej, jag heter {name}");
    }
    public void Greet(string name)
    {
        Console.WriteLine($"Hej {name}, jag heter {this.name}");
    }

    public void Greet(Cat cat)
    {
        Console.WriteLine($"Hej {cat.name}, jag heter {this.name}");
    }

    private int GetDoubleAge()
    {
        return age * 2;
    }
}



















// Miniuppgift: Utgå från klassen ovan. Skapa sedan en array med hundra katter,
// som heter "Katt1", Katt2" etc... med åldrarna 1, 2, 3 etc.
//Cat[] cats = new Cat[100];
//for (int i = 0; i < cats.Length; i++)
//{
//    cats[i] = new Cat() { age = i + 1, name = $"Katt{i + 1}" };
//}

//Cat[] cats = new Cat[] { myCat, myOtherCat, myThirdCat, new Cat() };

//myCat.name = "Pelle svanslös";
//cats[0].age = 99;

//foreach (var cat in cats)
//{
//    Console.WriteLine($"{cat.name} är {cat.age} år gammal.");
//}


