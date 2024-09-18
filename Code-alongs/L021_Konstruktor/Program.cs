

// Keyword new anropar konstruktorn på en klass, som skapar objektet
// och returnerar en referens till det nyskapade objektet.
Cat myCat = new Cat();

// Kort-alternativ till ovanstående:
//var myCat = new Cat();
//Cat myCat = new();

Cat myOtherCat = new Cat("Pelle");
Cat myThirdCat = new Cat("Måns", 7);

Console.WriteLine($"My name is {myCat.name} and I'm {myCat.age} years old");
Console.WriteLine($"My name is {myOtherCat.name} and I'm {myOtherCat.age} years old");
Console.WriteLine($"My name is {myThirdCat.name} and I'm {myThirdCat.age} years old");

class Cat
{
    public string name = "Default name";

    public int age = 0;

    private bool isHungry;

    // Constructor
    public Cat()
    {
        this.name = "-";
        this.age = 1;
    }

    public Cat(string name)
    {
        this.name = name;
        this.isHungry = false;
    }

    public Cat(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}