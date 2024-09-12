

//Console.WriteLine(Directory.GetCurrentDirectory());

//using (StreamWriter writer = new StreamWriter("myfile.txt"))
//{
//    for (int i = 0; i < 9; i++)
//    {
//        //Console.WriteLine($"Hello {i}!");
//        writer.WriteLine($"Hello {i}!");
//    }
//}

using (StreamReader reader = new StreamReader("myfile.txt"))
{
    //while (!reader.EndOfStream)
    //{
    //    //Console.Write((char)reader.Read());

    //    Thread.Sleep(200);
    //    Console.WriteLine(reader.ReadLine());
    //}

    Console.Write(reader.ReadToEnd());
}
