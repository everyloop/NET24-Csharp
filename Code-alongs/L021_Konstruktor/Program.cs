

// Keyword new anropar konstruktorn på en klass, som skapar objektet
// och returnerar en referens till det nyskapade objektet.

// Kort-alternativ:
//var myCat = new Cat();
//Cat myCat = new();

//Cat myOtherCat = new Cat() { name = "Pelle" };

Cat myCat = Cat.CreateObject("Pelle");
Cat myOtherCat = Cat.CreateObject("Måns");
Cat myThirdCat = new Cat();

Console.WriteLine($"My name is {myCat.name} and I'm {myCat.age} years old");
Console.WriteLine($"My name is {myOtherCat.name} and I'm {myOtherCat.age} years old");
Console.WriteLine(Cat.numberOfCats);

class Cat
{
    public string name = "Default name";

    public int age = 0;

    private bool isHungry;

    public static int numberOfCats = 0;

    public static Cat CreateObject(string name)
    {
        numberOfCats++;
        return new Cat() { name = name };
    }
    // Constructor
    //private Cat()
    //{
    //}

    //public Cat(string name)
    //{
    //    this.name = name;
    //    this.isHungry = false;
    //}

    //public Cat(string name, int age)
    //{
    //    this.name = name;
    //    this.age = age;
    //}
}