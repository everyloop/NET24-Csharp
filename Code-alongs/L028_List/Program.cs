
var countries = new List<string>() { "france", "spain", "italy" };

// countries.Clear();

countries.Add("sweden");
countries.Add("norway");

//countries.Remove("italy");
//countries.RemoveAt(0);
//countries.RemoveRange(1, 3);

// Console.WriteLine(countries[10]);

foreach (var country in countries)
{
    Console.WriteLine(country);
}

Console.WriteLine();

var myCountry = "Sweden";
Console.WriteLine($"countries.Contains({myCountry}) => {countries.Contains(myCountry)}");

string[] myCountries = countries.ToArray();

Array.Resize(ref myCountries, 2);

Console.WriteLine();

List<int> numbers = new List<int>(3);

for (int i = 0; i < 40; i++)
{
    numbers.Add(i);
    Console.WriteLine($"numbers.Count = {numbers.Count}, numbers.Capacity = {numbers.Capacity}");
}

