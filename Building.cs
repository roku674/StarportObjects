//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Building
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Building()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isBuilt"></param>
        /// <param name="name"></param>
        /// <param name="requiredResources"></param>
        public Building(bool isBuilt, string name, Resources requiredResources)
        {
            this.isBuilt = isBuilt;
            this.name = name;
            this.requiredResources = requiredResources;
        }

        public bool isBuilt { get; set; }
        public string name { get; set; }
        public Resources requiredResources { get; set; }
    }
}