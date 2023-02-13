//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class WeaponsFactory : Building
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public WeaponsFactory()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nukes"></param>
        /// <param name="negotiators"></param>
        /// <param name="mines"></param>
        /// <param name="compoundMines"></param>
        /// <param name="flakCannons"></param>
        /// <param name="laserCannons"></param>
        /// <param name="shields"></param>
        public WeaponsFactory(uint nukes, uint negotiators, uint mines, uint compoundMines, uint flakCannons, uint laserCannons, uint shields)
        {
            this.Nukes = nukes;
            this.Negotiators = negotiators;
            this.Mines = mines;
            this.CompoundMines = compoundMines;
            this.FlakCannons = flakCannons;
            this.LaserCannons = laserCannons;
            this.Shields = shields;
        }

        public uint Nukes { get; set; }
        public uint Negotiators { get; set; }
        public uint Mines { get; set; }
        public uint CompoundMines { get; set; }
        public uint FlakCannons { get; set; }
        public uint LaserCannons { get; set; }
        public uint Shields { get; set; }
    }
}