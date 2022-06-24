//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Colony
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Colony(BiodomeInside biodome = null, string planetType = null, string planetName = null, string colonyName = null, Solar solar = null, Refinery refinery = null, WeaponsFactory weaponsFactory = null, string coordinates = null, string founded = null, string corporation = null, string owner = null)
        {
            this.biodome = biodome;
            this.planetType = planetType;
            this.planetName = planetName;
            this.colonyName = colonyName;
            this.solar = solar;
            this.refinery = refinery;
            this.weaponsFactory = weaponsFactory;
            this.coordinates = coordinates;
            this.founded = founded;
            this.corporation = corporation;
            this.owner = owner;
        }

        public BiodomeInside biodome { get; set; }
        public string planetType { get; set; }
        public string planetName { get; set; }
        public string colonyName { get; set; }
        public Solar solar { get; set; }
        public Refinery refinery { get; set; }
        public WeaponsFactory weaponsFactory { get; set; }
        public string coordinates { get; internal set; }
        public string founded { get; internal set; }
        public string corporation { get; internal set; }
        public string owner { get; internal set; }
    }
}