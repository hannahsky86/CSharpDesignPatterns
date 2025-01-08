namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibilityPractice 
{

    public class IsFrameChecked: BikeAssemblyHandler {
        //Handle method 
        public override string Handle(Bike bike) {
            if(!bike.IsFrameChecked) {
                return "Frame is not checked.";
            }

            return NextHandler?.Handle(bike) ?? "Frame is checked.";
        }
    }


    public class AreWheelsInstalled: BikeAssemblyHandler {
        //Handle method 
        public override string Handle(Bike bike) {
            if(!bike.AreWheelsInstalled) {
                return "Wheels are not installed.";
            }

            return NextHandler?.Handle(bike) ?? "Wheels are installed.";
        }
    }

    public class AreBreaksInstalled: BikeAssemblyHandler {
        //Handle method
        public override string Handle(Bike bike) {
            if(!bike.AreBreaksInstalled) {
                return "Breaks are not installed.";
            }

            return NextHandler?.Handle(bike) ?? "Breaks are installed.";
        }
    }

    public class IsBikeInspected: BikeAssemblyHandler {
        //Handle method
        public override string Handle(Bike bike)
        {
            if(!bike.IsBikeInspected) {
                return "Bike is not inspected.";
            }

            return NextHandler?.Handle(bike)?? "Bike is finished.";
        }
    }
}