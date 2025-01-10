using System.Collections.Generic;

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    // To decouple implementation from the consumer (MenuManager) 
    public interface IShapeManager 
    {
        void DisplayShapeDetails(List<Shape> shapes);
    }
}