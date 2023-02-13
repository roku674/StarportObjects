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
            this.IsBuilt = isBuilt;
            this.Name = name;
            this.RequiredResources = requiredResources;
        }

        public bool IsBuilt { get; set; }
        public string Name { get; set; }
        public Resources RequiredResources { get; set; }
    }
}