namespace StarportObjects
{
    public class BiodomeInside
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BiodomeInside()
        {
        }

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
            AllocationConstruction = allocationConstruction;
            AllocationHarvesting = allocationHarvesting;
            AllocationMilitary = allocationMilitary;
            AllocationResearch = allocationResearch;
            CurrentlyConstructing = currentlyConstructing;
            CurrentPollution = currentPollution;
            DateFounded = dateFounded;
            Disasters = disasters;
            Discoveries = discoveries;
            Government = government;
            HourlyIncome = hourlyIncome;
            Morale = morale;
            Owner = owner;
            PollutionRate = pollutionRate;
            Population = population;
            Treasury = treasury;
            MoraleWord = moraleWord;
        }

        public uint AllocationConstruction {
            get; set;
        }
        public uint AllocationHarvesting {
            get; set;
        }
        public uint AllocationMilitary {
            get; set;
        }
        public uint AllocationResearch {
            get; set;
        }
        public string CurrentlyConstructing {
            get; set;
        }
        public uint CurrentPollution {
            get; set;
        }
        public string DateFounded {
            get; set;
        }
        public uint Disasters {
            get; set;
        }
        public string Discoveries {
            get; set;
        }
        public string Government {
            get; set;
        }
        public uint HourlyIncome {
            get; set;
        }
        public int Morale {
            get; set;
        }
        public string Owner {
            get; set;
        }
        public string PollutionRate {
            get; set;
        }
        public uint Population {
            get; set;
        }
        public uint Treasury {
            get; set;
        }
        public string MoraleWord {
            get; internal set;
        }
    }
}
