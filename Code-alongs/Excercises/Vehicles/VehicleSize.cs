
struct VehicleSize
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public VehicleSize(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
}
