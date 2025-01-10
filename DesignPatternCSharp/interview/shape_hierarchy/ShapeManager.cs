using System;
using System.Collections.Generic;


namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    public class ShapeManager : IShapeManager
    {

        public void DisplayShapeDetails(IEnumerable<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape description: {shape.GetDescription()}");
                Console.WriteLine($"Shape area: {shape.CalculateArea()}");
                Console.WriteLine($"Shape perimeter: {shape.CalculatePerimeter()}");
                Console.WriteLine($"Shape name: {shape.Name}");
            }
        }
    }
}