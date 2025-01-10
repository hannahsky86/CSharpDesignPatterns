using System;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    internal class Triangle : Shape
    {
        // Properties
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public override string Name { get; set; }

        // Constructor
        public Triangle(double sideA, double sideB, double sideC)
        {
            Name = "Triangle";
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override string GetDescription()
        {
            return $"This is a {Name} with sides {SideA}, {SideB}, and {SideC}";
        }
    }
}
