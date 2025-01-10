namespace DesignPatternCSharp.Interview.ShapeHierarchy
{
    // Abstract class Shape representing a basic geometric shape
    // Change class to "internal" to prevent outside access to the Shape classes 
    // Only derived classes within the same assembly can inherit and implement the abstract members
    internal abstract class Shape : IShape
    {
        //Methods 
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public abstract string GetDescription();

        //Properties
        public abstract string Name { get; set; }
    }
}
