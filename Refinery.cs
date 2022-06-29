//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Refinery : Building
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Refinery()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="workforceAllocation"></param>
        /// <param name="resourcesInRefinery"></param>
        public Refinery(Resources workforceAllocation, Resources resourcesInRefinery)
        {
            this.workforceAllocation = workforceAllocation;
            this.resourcesInRefinery = resourcesInRefinery;
        }

        public Resources workforceAllocation { get; set; }
        public Resources resourcesInRefinery { get; set; }
    }
}