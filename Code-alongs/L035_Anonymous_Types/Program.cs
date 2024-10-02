

var data = new { Integer = 1, Float = 2.0f, Double = 3.0, Decimal = 4.0M, Long = 5L, Bool = true  };

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39 },
      new { LastName = "Palm", FirstName = "Lisa",  Age = 40 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65 },
};

foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} is {p.Age} years old.");
}

var person = new
{
      name = "Anders Eriksson",
      age = 45,
      contactInfo = new { eMail = "anders@gmail.com", phone = "07023485734" }
};

Console.WriteLine();