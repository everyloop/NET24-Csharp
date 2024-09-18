//using myNamespace.anotherNamespace;
//using myNamespace;
//using System;

// Fungerar inte utan using ovan, eftersom den inte hittar Cat i detta namespace.
Cat.SayHello();

// Detta fungerar dock, eftersom den explicit skriver vilken namespace Dog ligger i.
myNamespace.anotherNamespace.Dog.SayHello();

// Console ligger i System, och fungerar alltså inte utan att ange System.Console.Writeline,
// alternativt använda using System ovan. Dock finns i projektets configfil en setting som heter
// ImplicitUsings som normalt är enabled och automatiskt använder följande namespaces utan att
// man explicit behöver använda using i varje fil:
//System
//System.Collections.Generic
//System.IO
//System.Linq
//System.Net.Http
//System.Threading
//System.Threading.Tasks

Console.WriteLine();

namespace myNamespace
{
    class Cat
    {
        static public void SayHello()
        {
            Console.WriteLine("Hello! I'm a cat");
        }
    }

}

namespace myNamespace.anotherNamespace
{
    class Dog
    {
        static public void SayHello()
        {
            Console.WriteLine("Hello! I'm a dog");
        }
    }
}
