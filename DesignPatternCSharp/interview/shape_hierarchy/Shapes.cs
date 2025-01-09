namespace DesignPatternCSharp.Interview.ShapeHierarchy
{

    // Abstract class Shape representing a basic geometric shape
    public abstract class Shape
    {
        //Methods 
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public abstract string GetDescription();


        //Properties

        public abstract string name { get; set; }
    }
}