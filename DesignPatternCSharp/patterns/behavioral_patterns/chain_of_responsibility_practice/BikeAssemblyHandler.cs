namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibilityPractice 
{
    public abstract class BikeAssemblyHandler {
        //protected abstract hanlder field 
        protected BikeAssemblyHandler? NextHandler;

        //Method to link the current handler to the next on
        public void SetNext(BikeAssemblyHandler nextHandler) => NextHandler = nextHandler;

        //public abstract string Handle
        public abstract string Handle(Bike bike); 
    }
}