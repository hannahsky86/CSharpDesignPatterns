namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility.Handlers
{
    public class RequestLogger : Handler
    {
        public override string Handle(Request request)
        {
            return $"Request handled successfully: {request.Data}";
        }
    }
}
