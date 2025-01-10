using System;
using System.Collections.Generic;
using DesignPatternCSharp.Interview.ShapeHierarchy;



namespace DesignPatternCSharp
{
    public class MenuManager
    {
        // Accept dependencies via constructor injection 
        private readonly IShapeManager _shapeManager;

        public MenuManager(IShapeManager shapeManager)
        {
            _shapeManager = shapeManager;
        }


        public void ShowMainMenu()
        {
            Console.WriteLine("Select the type of design pattern:");
            Console.WriteLine("1. Behavioral Patterns");
            Console.WriteLine("2. Creational Patterns");
            Console.WriteLine("3. Structural Patterns");
            Console.WriteLine("4. Interview Questions");

            var typeChoice = Console.ReadLine();
            switch (typeChoice)
            {
                case "1":
                    ShowBehavioralPatterns();
                    break;
                case "2":
                    ShowCreationalPatterns();
                    break;
                case "3":
                    ShowStructuralPatterns();
                    break;
                case "4":
                    ShowInterviewQuestions();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private void ShowBehavioralPatterns()
        {
            Console.WriteLine("\nSelect a Behavioral Pattern:");
            Console.WriteLine("1. Chain of Responsibility");
            Console.WriteLine("2. Chain of Responsibility Bike Example");
            Console.WriteLine("3. Observer");
            Console.WriteLine("4. State");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Patterns.Behavioral.ChainOfResponsibility.Program.Run();
                    break;
                case "2":
                    Patterns.Behavioral.ChainOfResponsibilityPractice.BikeExampleProgram.Run();
                    break;
                case "3":
                case "4":
                    Console.WriteLine("Selected pattern is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private void ShowCreationalPatterns()
        {
            Console.WriteLine("\nSelect a Creational Pattern:");
            Console.WriteLine("1. Builder");
            Console.WriteLine("2. Singleton");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                case "2":
                    Console.WriteLine("Selected pattern is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private void ShowStructuralPatterns()
        {
            Console.WriteLine("\nSelect a Structural Pattern:");
            Console.WriteLine("1. Adapter");
            Console.WriteLine("2. Decorator");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                case "2":
                    Console.WriteLine("Selected pattern is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private void ShowInterviewQuestions()
        {
            Console.WriteLine("\nSelect an interview question:");
            Console.WriteLine("1. Shape Hierarchy");
            Console.WriteLine("2. Question 2");
            Console.WriteLine("3. Question 3");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Create your triangle... \n");
                    Console.WriteLine("Enter side A: \n");
                    var triangleSideA = ParseDoubleInput(Console.ReadLine());
                    Console.WriteLine("Enter side B: \n");
                    var triangleSideB = ParseDoubleInput(Console.ReadLine());
                    Console.WriteLine("Enter side C: \n");
                    var triangleSideC = ParseDoubleInput(Console.ReadLine());

                    Console.WriteLine("Create your rectangle... \n");
                    Console.WriteLine("Enter side A: \n");
                    var rectangleSideA = ParseDoubleInput(Console.ReadLine());
                    Console.WriteLine("Enter side B: \n");
                    var rectangleSideB = ParseDoubleInput(Console.ReadLine());

                    Console.WriteLine("Create your circle... \n");
                    Console.WriteLine("Enter a radius: \n");
                    var radius = ParseDoubleInput(Console.ReadLine());

                    // Reference the static Shape Factory to delegate creation of the shapes 
                    var triangle = ShapeFactory.CreateTriangle(triangleSideA, triangleSideB, triangleSideC);
                    var rectangle = ShapeFactory.CreateRectangle(rectangleSideA, rectangleSideB);
                    var circle = ShapeFactory.CreateCircle(radius);

                    var shapes = new List<IShape> { triangle, rectangle, circle };
                    _shapeManager.DisplayShapeDetails(shapes);

                    break;
                case "2":
                case "3":
                    Console.WriteLine("Question not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }


        private double ParseDoubleInput(string? input)
        {
            if (input != null && double.TryParse(input, out var result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return ParseDoubleInput(Console.ReadLine());
            }
        }
    }
}
