using System;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    public class Triangle : Shape
    {
        // Properties
        double sideA { get; set; }
        double sideB { get; set; }
        double sideC { get; set; }


        public override string name { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.name = "Triangle";
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        public override string GetDescription()
        {
            return $"This is a {name} with sides {sideA}, {sideB}, and {sideC}";
        }
    }
}