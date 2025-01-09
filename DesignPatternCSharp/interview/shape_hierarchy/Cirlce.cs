using System;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    // Derived classes 
    public class Circle : Shape
    {
        double radius { get; set; }
        public override string name { get; set; }

        // Constructor
        public Circle(double radius)
        {
            this.name = "Circle";
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string GetDescription()
        {
            return $"This is a {name} with radius {radius}";
        }
    }
}