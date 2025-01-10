

namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    // Public abstraction 
    // Contract for geometric shapes 
    // Consistent API 
    // Makes Shape classes interchangeable (polymorphism)
    // Implementation details can remain hidden (encapsulation)
    // Shape classes can be marked as internal (encapsulation)
    // Can add new shapes more easily by implementing IShapes interface 
    public interface IShape
    {
        string Name { get; set; }

        double CalculateArea();
        double CalculatePerimeter();
        string GetDescription();
    }
}