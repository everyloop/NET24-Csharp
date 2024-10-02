
Dog[] dogs =
{
    new Dog() { Name = "Fido", Age = 4 },
    new Dog() { Name = "Karo", Age = 6 },
    new Dog() { Name = "Bob", Age = 9 },
    new Dog() { Name = "Kaj", Age = 3 },
    new Dog() { Name = "Lajka", Age = 1 },
};

int[] ints = { 5, 6, 2, 5, 1, 3, -1 };

Array.Sort(dogs);

using (var dog = new Dog())
{
    Console.WriteLine("Dog!");
}

Console.WriteLine("The end!");

List<IDog> myList = new List<IDog> { new Animal(), new Dog() };

class Animal : IDog
{
    public string Name { get; set; }
    public int Age { get; set; }

}
class Dog : IDisposable, IDog, IComparable<Dog>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Dog? other)
    {
        return this.Age.CompareTo(other.Age);
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }

    public override string ToString()
    {
        return $"Name = {Name}, Age = {Age}";
    }
}

interface IDog
{
    public string Name { get; set; }
    public int Age { get; set; }
}