//Created by Alexander Fields https://github.com/roku674

using System.Collections.Generic;

namespace StarportObjects
{
    public class StarSystem
    {
        public static readonly uint defensesMax = 60;
        public string name;

        public StarSystem()
        { }

        public StarSystem(string name, uint currentDefenses, List<Planet> planets, StarPort port)
        {
            this.name = name;
            this.currentDefenses = currentDefenses;
            this.planets = planets;
            this.port = port;
        }

        public uint currentDefenses { get; set; }
        public List<Planet> planets { get; set; }
        public StarPort port { get; set; }
    }
}