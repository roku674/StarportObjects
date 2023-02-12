//Created by Alexander Fields https://github.com/roku674

using StarportObjects.Structs;
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
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="currentDefenses"></param>
        /// <param name="planets"></param>
        /// <param name="port"></param>
        public StarSystem(string name, uint currentDefenses, List<Planet> planets, Starport port, List<string> connectedSystems,string starType, string starColor, FileObj picture, FileObj map, Coordinate coordinates)
        {
            this.name = name;
            this.currentDefenses = currentDefenses;
            this.planets = planets;
            this.port = port;
            this.connectedSystems = connectedSystems;
            this.starType = starType;
            this.starColor = starColor;
            this.picture = picture;
            this.MiniMap = MiniMap;
            this.coordinates = coordinates;
        }

        public List<string> connectedSystems { get; set; }
        public uint currentDefenses { get; set; }
        public List<Planet> planets { get; set; }
        public Starport port { get; set; }
        public string starType { get; set; }
        public string starColor { get; set; }
        public FileObj picture { get; set; }
        public FileObj MiniMap { get; set; }
        public Coordinate coordinates { get; set; }
    }
}