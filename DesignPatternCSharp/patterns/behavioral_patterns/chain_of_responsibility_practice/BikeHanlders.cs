namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility 
{

    public class FrameInspectedHandler: BikeAssemblyHandler {
        //Handle method 
    }


    public class WheelsInstalledHandler: BikeAssemblyHandler {
        //Handle method 
    }

    public class BreaksInstalledHandler: BikeAssemblyHandler {
        //Handle method
    }

    public class FinalInspectionCompletedHandler: BikeAssemblyHandler {
        //Handle method
    }
}