using L037_Library;

List<object> objectList = new List<object>();

objectList.Add("Hello");
objectList.Add("World");
objectList.Add(5);
objectList.Add("Hej på er");
objectList.Add(true);
objectList.Add(3.4);
objectList.Add("Bye!");

//Skapa en ny lista och lägg in strängarna från objectList i stringList. Använder foreach. 
List<string> stringList = new List<string>();

foreach (object item in objectList)
{
    if (item is string s)
    {
        stringList.Add(s);
    }
}

//Skapa en ny lista och lägg in strängarna från objectList i stringList. Använder LINQ. 

var stringList2 = objectList.OfType<string>().ToList();

Console.WriteLine("stringList2 content:");
Console.WriteLine(string.Join('\n', stringList2));

Console.WriteLine();

Console.WriteLine($"{"stringList2.Any(s => s.Length == 5)", -50} {stringList2.Any(s => s.Length == 5)}");
Console.WriteLine($"{"stringList2.All(s => s.Length <= 10)", -50} {stringList2.All(s => s.Length <= 10)}");
Console.WriteLine($"{"stringList2.Any(s => s == \"Hej\")", -50} {stringList2.Any(s => s == "Hej")}");
Console.WriteLine($"{"stringList2.Any(s => s.Contains(\"ye\"))", -50} {stringList2.Any(s => s.Contains("ye"))}");
Console.WriteLine($"{"stringList2.Any(s => s.ToLower() == \"hej\")", -50} {stringList2.Any(s => s.ToLower() == "hej")}");
Console.WriteLine($"{"stringList2.Any(s => s.Split(' ').Length == 3)", -50} {stringList2.Any(s => s.Split(' ').Length == 3)}");
Console.WriteLine($"{"stringList2.All(s => s.StartsWith('B'))", -50} {stringList2.All(s => s.StartsWith('B'))}" );

Console.WriteLine("\n*************\n");
Console.WriteLine("var stringList3 = stringList2.Where(s => s.Length >= 3 && s.Length <= 7).ToList();\n");

var stringList3 = stringList2.Where(s => s.Length >= 3 && s.Length <= 7).ToList();

Console.WriteLine("stringList3 content:");
Console.WriteLine(string.Join('\n', stringList3));

// List<enemy> enemies;
// foreach (var enemy in enemies.Where<enemy>(e => e.HP < 5 && e.Name == 'rat'))
// {
//    Console.WriteLine(enemy.HP);
// }

Console.WriteLine("\n*************\n");

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "", Age = 39 },
      new { LastName = "Palm", FirstName = "Lisa",  Age = 40 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65 },
};

var people2 = people.Select(person => new { Name = $"{person.FirstName} {person.LastName}", Email = $"{person.FirstName.Title()}.{person.LastName.ToLower()}@gmail.com" }).ToList();

Console.WriteLine();
