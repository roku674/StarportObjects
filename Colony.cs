//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Colony
    {
        public Colony()
        { }

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