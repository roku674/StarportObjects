//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Colony
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Colony()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="biodome"></param>
        /// <param name="planetName"></param>
        /// <param name="colonyName"></param>
        /// <param name="solar"></param>
        /// <param name="refinery"></param>
        /// <param name="weaponsFactory"></param>
        public Colony(BiodomeInside biodome, string planetName, string colonyName, Solar solar, Refinery refinery, WeaponsFactory weaponsFactory)
        {
            this.biodome = biodome;
            this.planetName = planetName;
            this.colonyName = colonyName;
            this.solar = solar;
            this.refinery = refinery;
            this.weaponsFactory = weaponsFactory;
        }

        public BiodomeInside biodome { get; set; }
        public string planetName { get; set; }
        public string colonyName { get; set; }
        public Solar solar { get; set; }
        public Refinery refinery { get; set; }
        public WeaponsFactory weaponsFactory { get; set; }
    }
}