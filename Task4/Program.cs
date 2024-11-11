using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Point point1 = new Point(1, 2, "point 1");
        Point point2 = new Point(2, 3, "point 2");
        Point point3 = new Point(3, 4, "point 3");
        Point point4 = new Point(4, 5, "point 4");
        Point point5 = new Point(5, 6, "point 5");
        Figure triangle = new Figure(point1, point2, point3);
        triangle.PerimeterCalculator();
        Figure rectangle = new Figure(point1, point2, point3, point4);
        rectangle.PerimeterCalculator();
        Figure pentagon = new Figure(point1, point2, point3, point4, point5);   
        pentagon.PerimeterCalculator();
    }
}
class Point
{
    int x;
    int y;
    string name;

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public int X { get { return x; } }
    public int Y { get { return y; } }
    public string Name { get { return name; } }

}
class Figure
{
    List<Point> points = new List<Point>();
    public Figure(Point p1, Point p2, Point p3)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points.Add(p1);
        points.Add(p2); 
        points.Add(p3);
        points.Add(p4);
        points.Add(p5);
    }
    public double LengthSide(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
    public void PerimeterCalculator()
    {
        if (points.Count == 3)
        {
            double perimeter = LengthSide(points[0], points[1]) + LengthSide(points[1], points[2]) + LengthSide(points[2], points[0]);
            Console.WriteLine(perimeter);
        }
        else if (points.Count == 4)
        {
            double perimeter = LengthSide(points[0], points[1]) + LengthSide(points[1], points[2]) + LengthSide(points[2], points[3]) + LengthSide(points[3], points[0]);
            Console.WriteLine(perimeter);
        }
        else
        {
            double perimeter = LengthSide(points[0], points[1]) + LengthSide(points[1], points[2]) + LengthSide(points[2], points[3]) + LengthSide(points[3], points[4]) + LengthSide(points[4], points[0]);
            Console.WriteLine(perimeter);
        }
    }
}