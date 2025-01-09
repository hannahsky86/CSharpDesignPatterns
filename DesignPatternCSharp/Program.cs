﻿using System;

namespace DesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
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

        static void ShowBehavioralPatterns()
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
                    Console.WriteLine("State pattern is not implemented yet.");
                    break;
                case "4":
                    Console.WriteLine("State pattern is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static void ShowCreationalPatterns()
        {
            Console.WriteLine("\nSelect a Creational Pattern:");
            Console.WriteLine("1. Builder");
            Console.WriteLine("2. Singleton");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Builder pattern is not implemented yet.");
                    break;
                case "2":
                    Console.WriteLine("Singleton pattern is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static void ShowStructuralPatterns()
        {
            Console.WriteLine("\nSelect a Structural Pattern:");
            Console.WriteLine("1. Adapter");
            Console.WriteLine("2. Decorator");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Adapter pattern is not implemented yet.");
                    break;
                case "2":
                    Console.WriteLine("Decorator pattern is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static void ShowInterviewQuestions()
        {
            Console.WriteLine("\nSelect an interview question:");
            Console.WriteLine("\n1. Shape Hierarchy ");
            Console.WriteLine("\n2. Question 2:");
            Console.WriteLine("\n3. Question 3:");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                   Interview.ShapeHierarchy.Program.Run();
                    break;
                case "2":
                    // Console.WriteLine("Question 2: What is the difference between a decorator and a proxy pattern?");
                    break;
                case "3":
                    // Console.WriteLine("Question 3: What is the difference between a strategy and a observer pattern?");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
