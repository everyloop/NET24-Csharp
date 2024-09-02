
static void PrintHello(int n)
{
    Console.WriteLine("Hello");
    if (n > 1)
    {
        PrintHello(n - 1);
    }
}

//static void PrintWorld()
//{
//    Console.WriteLine("World");
//    PrintHello();
//}

 PrintHello(8);