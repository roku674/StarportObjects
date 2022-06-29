//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Planet
    {
        public static readonly uint defensesMax = 150;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Planet()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="population"></param>
        /// <param name="morale"></param>
        /// <param name="currentDefenses"></param>
        /// <param name="colony"></param>
        /// <param name="isColonized"></param>
        /// <param name="isDoubleDome"></param>
        public Planet(string name, string owner, string population, string morale, uint currentDefenses, Colony colony, bool isColonized, bool isDoubleDome)
        {
            this.name = name;
            this.owner = owner;
            this.population = population;
            this.morale = morale;
            this.currentDefenses = currentDefenses;
            this.colony = colony;
            this.isColonized = isColonized;
            this.isDoubleDome = isDoubleDome;
        }

        public Colony colony { get; set; }
        public uint currentDefenses { get; set; }
        public bool isColonized { get; set; }
        public bool isDoubleDome { get; set; }
        public string morale { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public string population { get; set; }
    }
}