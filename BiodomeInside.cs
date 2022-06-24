//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class BiodomeInside
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BiodomeInside()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="allocationConstruction"></param>
        /// <param name="allocationHarvesting"></param>
        /// <param name="allocationMilitary"></param>
        /// <param name="allocationResearch"></param>
        /// <param name="currentlyConstructing"></param>
        /// <param name="currentPollution"></param>
        /// <param name="dateFounded"></param>
        /// <param name="disasters"></param>
        /// <param name="discoveries"></param>
        /// <param name="government"></param>
        /// <param name="hourlyIncome"></param>
        /// <param name="morale"></param>
        /// <param name="owner"></param>
        /// <param name="pollutionRate"></param>
        /// <param name="population"></param>
        /// <param name="treasury"></param>
        /// <param name="moraleWord"></param>
        public BiodomeInside(uint allocationConstruction, uint allocationHarvesting, uint allocationMilitary, uint allocationResearch, string currentlyConstructing, uint currentPollution, string dateFounded, uint disasters, string discoveries, string government, uint hourlyIncome, int morale, string owner, string pollutionRate, uint population, uint treasury, string moraleWord)
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
            this.owner = owner;
            this.pollutionRate = pollutionRate;
            this.population = population;
            this.treasury = treasury;
            this.moraleWord = moraleWord;
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
        public string owner { get; set; }
        public string pollutionRate { get; set; }
        public uint population { get; set; }
        public uint treasury { get; set; }
        public string moraleWord { get; internal set; }
    }
}