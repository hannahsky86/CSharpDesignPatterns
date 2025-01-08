namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibilityPractice
{
    public static class BikeExampleProgram
    {
        public static void Run()
        {
            // Instantiate the new handlers
            var isFrameChecked = new IsFrameChecked();
            var areWheelsInstalled = new AreWheelsInstalled();
            var areBreaksInstalled = new AreBreaksInstalled();
            var isBikeInspected = new IsBikeInspected();


            // Create the Chain
            isFrameChecked.SetNext(areWheelsInstalled);
            areWheelsInstalled.SetNext(areBreaksInstalled);
            areBreaksInstalled.SetNext(isBikeInspected);

            
            // Create a bike object
            Bike bike = new Bike {
                IsFrameChecked = true,
                AreWheelsInstalled = true,
                AreBreaksInstalled = true,
            };

            
            // Process the bike status
            string result = isFrameChecked.Handle(bike);
            System.Console.WriteLine(result);
        }
    }
}