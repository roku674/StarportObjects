//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Solar : Building
    {
        public Solar()
        { }

        public Solar(uint solarRate, uint solarShots)
        {
            this.solarRate = solarRate;
            this.solarShots = solarShots;
        }

        public uint solarRate { get; set; }
        public uint solarShots { get; set; }
    }
}