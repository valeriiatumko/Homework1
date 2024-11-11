internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input side1");
        string side1Str = Console.ReadLine();
        double side1 = double.Parse(side1Str);

        Console.WriteLine("input side2");
        string side2Str = Console.ReadLine();
        double side2 = double.Parse(side2Str);

        Rectangle rect = new Rectangle( side1, side2);

        Console.WriteLine("Area:" + rect.Area);
        Console.WriteLine("Perimeter:" + rect.Perimeter);
    }
}

class Rectangle 
{
    double side1;
    double side2;
    public double Area { get; }
    public double Perimeter { get; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        Area = AreaCalculator();
        Perimeter = PerimeterCalculator();
    }

    double AreaCalculator()
    {
       return side1 * side2;
    }

    double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }
}


