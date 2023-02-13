//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Solar : Building
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Solar()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="solarRate"></param>
        /// <param name="solarShots"></param>
        public Solar(uint solarRate, uint solarShots)
        {
            this.SolarRate = solarRate;
            this.SolarShots = solarShots;
        }

        public uint SolarRate { get; set; }
        public uint SolarShots { get; set; }
    }
}