using System;
using System.Collections.Generic;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    public class ShapeManager
    {

        // public List<Shape> shapes { get; set; }

        public ShapeManager()
        {
            // this.shapes = shapes;
        }

        public void DisplayShapeDetails(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape description: {shape.GetDescription()}");
                Console.WriteLine($"Shape area: {shape.CalculateArea()}");
                Console.WriteLine($"Shape perimeter: {shape.CalculatePerimeter()}");
                Console.WriteLine($"Shape name: {shape.name}");
            }
        }
    }
}