namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility
{
    public class Request
    {
        public bool Authenticated { get; set; }
        public string UserRole { get; set; } = string.Empty;
        public object? Data { get; set; }
    }
}
