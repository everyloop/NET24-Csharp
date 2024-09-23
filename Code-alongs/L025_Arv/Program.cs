
//var animal = new Animal() { Name = "Heffaklump" };
//animal.Run();

Console.WriteLine();

var cat = new Cat() { Name = "Pelle" };
cat.Run();
cat.Mew();
cat.Walk();

Console.WriteLine();

var dog = new Dog() { Name = "Fido" };
dog.Run();
dog.Bark();
dog.Walk();

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