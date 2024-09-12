Console.WriteLine("*** StreamWriter *******************");

Console.WriteLine(Directory.GetCurrentDirectory());

using (StreamWriter writer = new StreamWriter("myfile.txt"))
{
    for (int i = 0; i < 9; i++)
    {
        Console.WriteLine($"Hello {i}!");
        writer.WriteLine($"Hello {i}!");
    }
}

Console.WriteLine();
Console.WriteLine("*** StreamReader *******************");

using (StreamReader reader = new StreamReader("myfile.txt"))
{
    while (!reader.EndOfStream)
    {
        //Thread.Sleep(50);
        //Console.Write((char)reader.Read());

        //Thread.Sleep(200);
        Console.WriteLine(reader.ReadLine());
    }

    //Console.Write(reader.ReadToEnd());
}
