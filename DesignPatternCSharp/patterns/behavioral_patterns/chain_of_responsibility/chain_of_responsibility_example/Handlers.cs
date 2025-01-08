namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility
{
    public class AuthHandler : Handler
    {
        public override string Handle(Request request)
        {
            if (!request.Authenticated)
                return "Authentication failed!";
            return NextHandler?.Handle(request) ?? "Authentication passed!";
        }
    }

    public class AdminPermissionHandler : Handler
    {
        public override string Handle(Request request)
        {
            if (request.UserRole != "admin")
                return "Admin permissions required!";
            return NextHandler?.Handle(request) ?? "Admin permissions validated!";
        }
    }

    public class DataValidationHandler : Handler
    {
        public override string Handle(Request request)
        {
            if (request.Data == null)
                return "Invalid data in request!";
            return NextHandler?.Handle(request) ?? "Data validation passed!";
        }
    }

    public class RequestLogger : Handler
    {
        public override string Handle(Request request)
        {
            return $"Request handled successfully: {request.Data}";
        }
    }
}
