
// LIFO = Last In First Out.
Stack<string> countries = new Stack<string>();

countries.Push("sweden");
countries.Push("norway");
countries.Push("denmark");

var topCountry = countries.Pop();

Console.WriteLine(topCountry);




