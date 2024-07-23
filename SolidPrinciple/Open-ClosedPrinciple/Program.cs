using Open_ClosedPrinciple;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>
            {
                new Rectangle { Width = 5, Height = 10 },
                new Circle { Radius = 7 }
            };

        AreaCalculator areaCalculator = new AreaCalculator(shapes);
        areaCalculator.DisplayAreas();
    }
}