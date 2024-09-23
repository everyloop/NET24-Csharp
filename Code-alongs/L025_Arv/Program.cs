
//var animal = new Animal() { Name = "Heffaklump" };
//animal.Run();

//Char myChar = 'A';
//Console.WriteLine((int)myChar);

//Cat myCat = new Cat() { Name = "Pelle" };
//Animal myAnimal = myCat;
//myAnimal.Run();

//long x = 5;
//int y = (int)x;



Animal[] animals = new Animal[]
{
    new Dog() { Name = "Fido" },
    new Cat() { Name = "Pelle" },
    new Dog() { Name = "Bosse" },
    new Cat() { Name = "Måns" }
};

foreach (var animal in animals)
{
    animal.Run();
    animal.Walk();

    (animal as Dog)?.Bark();
    (animal as Cat)?.Mew();

    /*
    if (animal is Dog myDog)
    {
        myDog.Bark();
        ((Dog)animal).Bark();
        (animal as Dog).Bark();
    }
    else if (animal is Cat cat)
    {
        cat.Mew();
    }
    */

    Console.WriteLine();
}

//Animal animal = new Cat() { Name = "Pelle" };
//animal.Walk();

//animal1.Run();
////cat.Mew();

//Console.WriteLine();

//Animal animal2 = new Dog() { Name = "Fido" };
//animal2.Run();
////dog.Bark();
//animal2.Walk();

abstract class Animal
{
   required public string Name { get; set; }
   public abstract void Run();

    public virtual void Walk()
    {
        Console.WriteLine($"{Name} is walking!");
    }
}

class Cat : Animal
{
    public void Mew()
    {
        Console.WriteLine($"{Name}: Meow!");
    }

    public override void Run()
    {
        Console.WriteLine($"{Name} is running like a cat!");
    }

    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a cat!");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}: Woof!");
    }

    public override void Run()
    {
        Console.WriteLine($"{Name} is running like a dog!");
    }
}