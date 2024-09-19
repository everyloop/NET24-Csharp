
// Value type
int a = 5;
int b = a;
a = 3;

Console.WriteLine($"a = {a}, b = {b}");

// Reference type
Cat catA = new() { name = "Pelle" };
Cat catB = catA;

catA.name = "Måns";

Console.WriteLine($"catA.name = {catA.name}, catB.name = {catB.name}");

Console.WriteLine();



// Exempel på hur value types kan skickas till en metod som pass by value eller pass by reference.

PassValueTypeByValue(a);
Console.WriteLine($"After PassValueTypeByValue(a) => a = {a}");

PassValueTypeByReference(ref a);
Console.WriteLine($"After PassValueTypeByReference(a) => a = {a}");

static void PassValueTypeByValue(int i)
{
    i = 0;
    //Console.WriteLine(i);
}

static void PassValueTypeByReference(ref int i)
{
    i = 0;
    //Console.WriteLine(i);
}

Console.WriteLine();



// Exempel på hur reference types kan skickas till en metod som pass by value eller pass by reference.

PassReferenceTypeByValue(catA);
Console.WriteLine($"After PassReferenceTypeByValue(catA) => catA.name = {catA.name}");

PassReferenceTypeByReference(ref catA);
Console.WriteLine($"After PassReferenceTypeByReference(catA) => catA.name = {catA.name}");

static void PassReferenceTypeByValue(Cat cat)
{
    // Uppdaterar man referensen cat, så påverkar det inte variabeln i anropet (catA).
    cat = new Cat() { name = "Bosse" };

    // Däremot kan fields och properties på objektet uppdateras även i en pass by value.
    //cat.name = "Bosse";

    //Console.WriteLine(cat.name);
}

static void PassReferenceTypeByReference(ref Cat cat)
{
    // Uppdaterar man referensen cat, så uppdateras även referensen i argumentet i anropet (catA).
    cat = new Cat() { name = "Bosse" };

    // Fields och properties på objektet kan alltid uppdateras.
    //cat.name = "Bosse";

    //Console.WriteLine(cat.name);
}



class Cat()
{
    public string name;
}


