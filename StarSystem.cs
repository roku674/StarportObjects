//Created by Alexander Fields https://github.com/roku674

using System.Collections.Generic;

namespace StarportObjects
{
    public class StarSystem
    {
        public static readonly uint defensesMax = 60;

        public string name;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StarSystem()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="currentDefenses"></param>
        /// <param name="planets"></param>
        /// <param name="port"></param>
        public StarSystem(string name, uint currentDefenses, List<Planet> planets, Starport port, List<StarSystem> connectedSystems)
        {
            this.name = name;
            this.currentDefenses = currentDefenses;
            this.planets = planets;
            this.port = port;
            this.connectedSystems = connectedSystems;
        }

        public List<StarSystem> connectedSystems { get; set; }
        public uint currentDefenses { get; set; }
        public List<Planet> planets { get; set; }
        public Starport port { get; set; }
    }
}