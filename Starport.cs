﻿//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Starport
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Starport()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="colonists"></param>
        /// <param name="resources"></param>
        /// <param name="shields"></param>
        /// <param name="negotiators"></param>
        public Starport(uint colonists, Resources resources, uint shields, uint negotiators)
        {
            this.colonists = colonists;
            this.resources = resources;
            this.shields = shields;
            this.negotiators = negotiators;
        }

        public uint colonists { get; set; }
        public Resources resources { get; set; }
        public uint shields { get; set; }
        public uint negotiators { get; set; }
    }
}