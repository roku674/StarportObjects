//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class BiodomeColony
    {
        public uint allocationConstruction { get; set; }
        public uint allocationHarvesting { get; set; }
        public uint allocationMilitary { get; set; }
        public uint allocationResearch { get; set; }
        public string currentlyConstructing { get; set; }
        public uint currentPollution { get; internal set; }
        public string dateFounded { get; set; }
        public uint disasters { get; internal set; }
        public string discoveries { get; set; }
        public string government { get; set; }
        public uint hourlyIncome { get; internal set; }
        public int morale { get; set; }
        public string pollutionRate { get; set; }
        public uint population { get; set; }
        public uint treasury { get; set; }
    }
}