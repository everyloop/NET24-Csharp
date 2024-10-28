
using System.Text.Json;
using System.Text.Json.Serialization;

//var data = new[] {
//    new { FirstName = "Kalle", LastName = "Andersson", Length = 182 },
//    new { FirstName = "Emma", LastName = "Andersson", Length = 172 }
//};

var people = new List<Person>()
{
    new Person("Kalle", "Andersson", true, 182, 85),
    new Person("Emma", "Andersson", false, 172, 70),
};

people[0].BestFriend = people[1];
people[1].BestFriend = people[0];

var options = new JsonSerializerOptions() { 
    WriteIndented = true,
    IncludeFields = true,
    IgnoreReadOnlyProperties = false,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    ReferenceHandler = ReferenceHandler.IgnoreCycles
};

string json = JsonSerializer.Serialize(people, options);

Console.WriteLine(json);

//File.WriteAllText("people.json", json);

//string json = File.ReadAllText("people.json");

//Console.WriteLine(json);

//var options = new JsonSerializerOptions() { 
//    UnmappedMemberHandling = System.Text.Json.Serialization.JsonUnmappedMemberHandling.Disallow,     
//};

//var people = JsonSerializer.Deserialize<List<Person>>(json, options);

//Console.WriteLine();

class Person
{
    public double weight;

    public Person(string firstName, string lastName, bool isStudent, double length, double weight)
    {
        FirstName = firstName;
        LastName = lastName;
        IsStudent = isStudent;
        Length = length;
        this.weight = weight;
    }

    public string FirstName { get; set; }
    
    [JsonIgnore]
    public string LastName { get; set; }

    [JsonPropertyOrder(-1)]
    [JsonPropertyName("ThisIsAStudent")]
    public bool IsStudent { get; }
    public double Length { get; set; }

    public Person BestFriend { get; set; }

}