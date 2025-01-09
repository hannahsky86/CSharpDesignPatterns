using System;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    public class Rectangle : Shape
    {

        // Properties
        double length { get; set; }
        double width { get; set; }

        public override string name { get; set; }

        //Constructor
        public Rectangle(double length, double width)
        {
            this.name = "Rectangle";
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public override string GetDescription()
        {
            return $"This is a {name} with length {length} and width {width}";
        }
    }
}
