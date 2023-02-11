//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Starbase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Starbase()
        {
        }

        public Starbase(uint colonists, Resources selling, Resources buying, uint shields, uint negotiators)
        {
            this.colonists = colonists;
            this.selling = selling;
            this.buying = buying;
            this.shields = shields;
            this.negotiators = negotiators;
        }

        public uint colonists {
            get; set;
        }
        public Resources selling {
            get; set;
        }
        public Resources buying {
            get; set;
        }
        public uint shields {
            get; set;
        }
        public uint negotiators {
            get; set;
        }
    }
}
