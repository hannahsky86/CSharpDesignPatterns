namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    public static class ShapeFactory
    {
        // Centralizes the creation of shape objects 
        // Returns IShape objects so you can work with objects generically 
        // Object instantiation hidden in Factory methods
        // Similar to factory where you can just order an object through the method. You don't need to create the object.   
        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        public static IShape CreateRectangle(double length, double width)
        {
            return new Rectangle(length, width);
        }

        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }
    }
}
