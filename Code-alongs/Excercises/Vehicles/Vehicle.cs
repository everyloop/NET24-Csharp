enum Brand { Toyota, Volvo, Porsche, Lada, Saab  }
enum Color { Black, White, Red, Blue, Yellow } 

class Vehicle
{
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public VehicleSize Size { get; set; } // = new VehicleSize(0, 0, 0);

    //public VehicleSize Size = new VehicleSize(0, 0, 0);

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;

        var rand = new Random();

        VehicleSize size = new VehicleSize();
        size.Length = rand.NextDouble() * 2.0 + 3.5;
        size.Width = rand.NextDouble() * 0.7 + 1.5;
        size.Height = rand.NextDouble() * 2.0 + 1;
        Size = size;
    }

    public Vehicle(Brand brand) : this(brand, Color.White)
    {
    }

    public Vehicle() : this(Brand.Toyota, Color.White) {}

    public override string ToString()
    {
        return $"A {Color.ToString().ToLower()} {Brand}";
    }
}
