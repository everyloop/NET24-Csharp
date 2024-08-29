Console.WriteLine('A');
Console.WriteLine('B');
Console.WriteLine('C');

int z = Int32.Parse(Console.ReadLine());

int x = 0;
int y = 0;
while (x < 10)
{
    Console.WriteLine($"x = {x}, y = {y}");
    x++;

    if (x % 2 == 0)
    {
        y++;
    }
}

