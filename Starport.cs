//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Starport
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Starport()
        {
        }

        public Starport(uint colonists, Resources selling, Resources buying, uint shields, uint negotiators)
        {
            this.Colonists = colonists;
            this.Selling = selling;
            this.Buying = buying;
            this.Shields = shields;
            this.Negotiators = negotiators;
        }

        public uint Colonists {
            get; set;
        }
        public Resources Selling {
            get; set;
        }
        public Resources Buying {
            get; set;
        }
        public uint Shields {
            get; set;
        }
        public uint Negotiators {
            get; set;
        }
    }
}
