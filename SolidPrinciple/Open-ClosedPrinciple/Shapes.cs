using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class AreaCalculator
    {
        private readonly List<Shape> _shapes;

        public AreaCalculator(List<Shape> shapes)
        {
            _shapes = shapes;
        }

        public void DisplayAreas()
        {
            foreach (var shape in _shapes)
            {
                Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.CalculateArea()}");
            }
        }
    }

}
