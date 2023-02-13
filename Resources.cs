namespace StarportObjects
{
    public class Resources
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="metal"></param>
        /// <param name="anaerobes"></param>
        /// <param name="medicine"></param>
        /// <param name="organics"></param>
        /// <param name="oil"></param>
        /// <param name="uranium"></param>
        /// <param name="equipment"></param>
        /// <param name="spice"></param>
        public Resources(uint metal, uint anaerobes, uint medicine, uint organics, uint oil, uint uranium, uint equipment, uint spice)
        {
            this.Metal = metal;
            this.Anaerobes = anaerobes;
            this.Medicine = medicine;
            this.Organics = organics;
            this.Oil = oil;
            this.Uranium = uranium;
            this.Equipment = equipment;
            this.Spice = spice;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Resources()
        {
        }

        public uint Anaerobes {
            get; set;
        }
        public uint Equipment {
            get; set;
        }
        public uint Medicine {
            get; set;
        }
        public uint Metal {
            get; set;
        }
        public uint Oil {
            get; set;
        }
        public uint Organics {
            get; set;
        }
        public uint Spice {
            get; set;
        }
        public uint Uranium {
            get; set;
        }
    }

}
