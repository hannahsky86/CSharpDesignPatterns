using System;
using DesignPatternCSharp.Interview.ShapeHierarchy;

namespace DesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeManager = new ShapeManager(); 
            var menuManager = new MenuManager(shapeManager);

            menuManager.ShowMainMenu();
        }
    }
}
