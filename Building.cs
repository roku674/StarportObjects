//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Building
    {
        public Building()
        { }

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