//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class BiodomeInside
    {
        public BiodomeInside(uint allocationConstruction, uint allocationHarvesting, uint allocationMilitary, uint allocationResearch, string currentlyConstructing, uint currentPollution, string dateFounded, uint disasters, string discoveries, string government, uint hourlyIncome, int morale, string pollutionRate, uint population, uint treasury)
        {
            this.allocationConstruction = allocationConstruction;
            this.allocationHarvesting = allocationHarvesting;
            this.allocationMilitary = allocationMilitary;
            this.allocationResearch = allocationResearch;
            this.currentlyConstructing = currentlyConstructing;
            this.currentPollution = currentPollution;
            this.dateFounded = dateFounded;
            this.disasters = disasters;
            this.discoveries = discoveries;
            this.government = government;
            this.hourlyIncome = hourlyIncome;
            this.morale = morale;
            this.pollutionRate = pollutionRate;
            this.population = population;
            this.treasury = treasury;
        }

        public uint allocationConstruction { get; set; }
        public uint allocationHarvesting { get; set; }
        public uint allocationMilitary { get; set; }
        public uint allocationResearch { get; set; }
        public string currentlyConstructing { get; set; }
        public uint currentPollution { get; set; }
        public string dateFounded { get; set; }
        public uint disasters { get; set; }
        public string discoveries { get; set; }
        public string government { get; set; }
        public uint hourlyIncome { get; set; }
        public int morale { get; set; }
        public string pollutionRate { get; set; }
        public uint population { get; set; }
        public uint treasury { get; set; }
    }
}