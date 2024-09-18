using myNamespace.anotherNamespace;
using myNamespace;
using System;

Cat.SayHello();

Dog.SayHello();

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
