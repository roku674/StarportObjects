//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Refinery : Building
    {
        public Refinery()
        { }

        public Refinery(Resources workforceAllocation, Resources resourcesInRefinery)
        {
            this.workforceAllocation = workforceAllocation;
            this.resourcesInRefinery = resourcesInRefinery;
        }

        public Resources workforceAllocation { get; set; }
        public Resources resourcesInRefinery { get; set; }
    }
}