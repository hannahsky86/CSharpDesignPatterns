using System;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    internal class Rectangle : Shape
    {
        // Properties
        private double Length { get; set; }
        private double Width { get; set; }

        public override string Name { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public override string GetDescription()
        {
            return $"This is a {Name} with length {Length} and width {Width}";
        }
    }
}
