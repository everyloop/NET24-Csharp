

using System.Collections.Generic;

Dictionary<string, string> myDictionary = new Dictionary<string, string>();

myDictionary.Add("boy", "pojke");
myDictionary.Add("girl", "flicka");
myDictionary.Add("man", "man");
myDictionary.Add("woman", "kvinna");

Console.WriteLine("Keys:");

foreach (var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine("\nValues:");

foreach (var value in myDictionary.Values)
{
    Console.WriteLine(value);
}

Console.WriteLine("\nKeys with values:");

foreach (KeyValuePair<string, string> keyValuePair in myDictionary)
{
    Console.WriteLine($"The key {keyValuePair.Key} hold the values {keyValuePair.Value}");
}

Console.WriteLine("\nKeys with values:");

foreach (var key in myDictionary.Keys)
{
    Console.WriteLine($"The key {key} hold the values {myDictionary[key]}");
}

//string input;

//do
//{
//    input = Console.ReadLine();

//    if (myDictionary.ContainsKey(input))
//    {
//        Console.WriteLine(myDictionary[input]);
//    }
//    else
//    {
//        Console.WriteLine("Nyckeln saknas!");
//    }
//} while (input != "");

