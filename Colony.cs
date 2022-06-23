//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Colony
    {
        public BiodomeColony biodome { get; set; }
        public string planetName { get; set; }
        public string colonyName { get; set; }
        public Solar solar { get; set; }
        public Refinery refinery { get; set; }
        public WeaponsFactory weaponsFactory { get; set; }
    }
}