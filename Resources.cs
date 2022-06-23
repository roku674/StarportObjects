//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Resources
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="metal"></param>
        /// <param name="anerobes"></param>
        /// <param name="medicine"></param>
        /// <param name="organics"></param>
        /// <param name="oil"></param>
        /// <param name="uranium"></param>
        /// <param name="equipment"></param>
        /// <param name="spice"></param>
        public Resources(uint metal, uint anerobes, uint medicine, uint organics, uint oil, uint uranium, uint equipment, uint spice)
        {
            this.metal = metal;
            this.anaerobes = anerobes;
            this.medicine = medicine;
            this.organics = organics;
            this.oil = oil;
            this.uranium = uranium;
            this.equipment = equipment;
            this.spice = spice;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Resources()
        { }

        public uint anaerobes { get; set; }
        public uint equipment { get; set; }
        public uint medicine { get; set; }
        public uint metal { get; set; }
        public uint oil { get; set; }
        public uint organics { get; set; }
        public uint spice { get; set; }
        public uint uranium { get; set; }
    }
}