
Position playerPosition = new Position(0, 0);

Console.WriteLine($"Player is at position ({playerPosition.X}, {playerPosition.Y})");

Color myColor = Color.Green;

Console.WriteLine($"myColor = {myColor} ({(int)myColor})");
Console.WriteLine((Color)3);

// En struct fungerar i princip som en klass men definerar en value type istället för en reference type.
struct Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Enum (enumeration types) är också value types. De används om man vill ha variabler som kan anta
// ett av de värden som man definerat upp i sin enum.
enum Color { Red, Green, Blue, Yellow, Purple };
