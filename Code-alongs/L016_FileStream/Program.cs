

using (FileStream stream = File.OpenRead("L016_FileStream.exe"))
{
    Console.WriteLine(stream.Length);

    byte[] data = new byte[stream.Length];
    stream.Read(data);

    for (int i = 0; i < 100; i++)
    {
        Console.Write($"{data[i].ToString("X2")} ");
    }
}


