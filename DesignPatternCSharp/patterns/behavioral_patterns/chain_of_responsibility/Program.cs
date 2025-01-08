using System;
using DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility;

namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility
{
    public static class Program
    {
        public static void Run()
        {
            // Create a chain of handlers
            var authHandler = new AuthHandler();
            var permissionHandler = new AdminPermissionHandler();
            var validationHandler = new DataValidationHandler();
            var logger = new RequestLogger();

            // Build the chain
            authHandler.SetNext(permissionHandler);
            permissionHandler.SetNext(validationHandler);
            validationHandler.SetNext(logger);

            // Example requests
            var requests = new[]
            {
                new Request { Authenticated = false, UserRole = "admin", Data = new { Order = "item1" } },
                new Request { Authenticated = true, UserRole = "user", Data = new { Order = "item2" } },
                new Request { Authenticated = true, UserRole = "admin", Data = null },
                new Request { Authenticated = true, UserRole = "admin", Data = new { Order = "item3" } }
            };

            // Process requests
            for (int i = 0; i < requests.Length; i++)
            {
                Console.WriteLine($"Request {i + 1}: {authHandler.Handle(requests[i])}\n");
            }
        }
    }
}
