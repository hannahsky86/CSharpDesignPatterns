namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility
{

    // Abstract 
    //- Cannot be instantiated 
    //- Inherited by concrete classes that will implement the abstract methods.
    public abstract class Handler
    {

        //protected - NextHandler can only be accessed within this class and subclasses 
        //Hanlder - Another handler in the chain
        //? - nullable 
        //Field of type Handler 
        //Allows each hanlder to forward request to the next handler in the chain 
        protected Handler? NextHandler;

        //Links the current handler to to the next one 
        //Single line method 
        public void SetNext(Handler nextHandler) => NextHandler = nextHandler;


        //Method that must be implemented by all subclasses 
        //Subclasses will define how it processes a Request 
        public abstract string Handle(Request request);
    }
}
