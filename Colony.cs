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
            this.Biodome = biodome;
            this.PlanetType = planetType;
            this.PlanetName = planetName;
            this.ColonyName = colonyName;
            this.Solar = solar;
            this.Refinery = refinery;
            this.WeaponsFactory = weaponsFactory;
            this.Coordinates = coordinates;
            this.Founded = founded;
            this.Corporation = corporation;
            this.Owner = owner;
        }

        public BiodomeInside Biodome {
            get; set;
        }
        public string PlanetType {
            get; set;
        }
        public string PlanetName {
            get; set;
        }
        public string ColonyName {
            get; set;
        }
        public Solar Solar {
            get; set;
        }
        public Refinery Refinery {
            get; set;
        }
        public WeaponsFactory WeaponsFactory {
            get; set;
        }
        public string Coordinates {
            get; internal set;
        }
        public string Founded {
            get; internal set;
        }
        public string Corporation {
            get; internal set;
        }
        public string Owner {
            get; internal set;
        }
    }
}
