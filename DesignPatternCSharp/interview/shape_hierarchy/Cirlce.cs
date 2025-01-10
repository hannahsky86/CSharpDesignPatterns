using System;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    // Derived class
    internal class Circle : Shape
    {
        private double Radius { get; set; }
        public override string Name { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string GetDescription()
        {
            return $"This is a {Name} with radius {Radius}";
        }
    }
}
