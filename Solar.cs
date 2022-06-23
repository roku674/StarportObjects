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
            this.solarRate = solarRate;
            this.solarShots = solarShots;
        }

        public uint solarRate { get; set; }
        public uint solarShots { get; set; }
    }
}