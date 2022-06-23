//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class WeaponsFactory : Building
    {
        public WeaponsFactory()
        { }

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