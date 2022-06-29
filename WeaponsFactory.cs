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
            this.nukes = nukes;
            this.negotiators = negotiators;
            this.mines = mines;
            this.compoundMines = compoundMines;
            this.flakCannons = flakCannons;
            this.laserCannons = laserCannons;
            this.shields = shields;
        }

        public uint nukes { get; set; }
        public uint negotiators { get; set; }
        public uint mines { get; set; }
        public uint compoundMines { get; set; }
        public uint flakCannons { get; set; }
        public uint laserCannons { get; set; }
        public uint shields { get; set; }
    }
}