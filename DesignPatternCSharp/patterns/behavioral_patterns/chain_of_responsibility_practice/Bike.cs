namespace DesignPatternCSharp.Patterns.Behavioral.ChainOfResponsibility 
{
    public class Bike {
        //Frame Checked
        //Wheels Installed
        //Breaks Installed
        //Final Inspection Completed 
        public bool IsFrameChecked {get; set;}
        public bool AreWheelsInstalled {get;set;}
        public bool AreBreaksInstalled {get;set;}
        public bool IsBikeInspected {get;set;}
    }
}