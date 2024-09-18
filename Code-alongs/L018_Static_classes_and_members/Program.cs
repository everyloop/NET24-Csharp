
Cat myCat = new Cat() { name = "Pelle" };

// Cat.numberOfLives = 7;

myCat.Greet();

Cat.PrintNumberOfLives();

// Om klassen i sig är static kan man inte instantiera objekt alls.
// Ex: static class Cat

class Cat
{
    public string name;
    
    public static int numberOfLives = 9;

    public void Greet()
    {
        Console.WriteLine($"Hi, my name is {name}, and I have {numberOfLives} lives.");
    }

    public static void PrintNumberOfLives()
    {
        Console.WriteLine($"Every cat has {numberOfLives} lives.");
    }

}