class Tire
{
    private double width;
    private double radius;
    private double aspectRatio;

    public Tire(double w, double r, double a)
    {
        width = w;
        radius = r;
        aspectRatio = a;
    }

    public void Display()
    {
        Console.WriteLine($"Tire Information: Width: {width}, Radius: {radius}, Aspect Ratio: {aspectRatio}.");
    }
}