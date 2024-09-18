
Otter myOtter = new();

//myOtter.name = "Kalle";

//myOtter.SetName("Kalle");
//Console.WriteLine(myOtter.GetName());

myOtter.Name = "Pelle";
myOtter.Age = 15;

Console.WriteLine(myOtter.Name);



class Otter
{
    private string _name = "Otto";

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.ToLower() == "kalle")
            {
                throw new ArgumentException($"Invalid otter name '{value}'");
            }

            _name = value;
        }
    }

    public int Age { get; set; }

    //private int _age;
    //public int Age
    //{
    //    get
    //    {
    //        return _age;
    //    }
    //    set
    //    {
    //        _age = value;
    //    }
    //}

    //public void SetName(string name)
    //{
    //    this.name = name;
    //}

    //public string GetName()
    //{
    //    return name;
    //}
}