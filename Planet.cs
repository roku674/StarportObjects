//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public class Planet
    {
        public static readonly uint defensesMax = 125;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Planet()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="population"></param>
        /// <param name="morale"></param>
        /// <param name="currentDefenses"></param>
        /// <param name="holding"></param>
        /// <param name="isColonized"></param>
        /// <param name="isDoubleDome"></param>
        public Planet(string name, string owner, string population, string morale, uint currentDefenses, Holding holding, bool isColonized, bool isDoubleDome,FileObj picture, FileObj map)
        {
            this.Name = name;
            this.Owner = owner;
            this.Population = population;
            this.Morale = morale;
            this.CurrentDefenses = currentDefenses;
            this.Holding = holding;
            this.IsColonized = isColonized;
            this.IsDoubleDome = isDoubleDome;
            this.Picture = picture;
            this.Map = map;
        }

        public Holding Holding { get; set; }
        public uint CurrentDefenses { get; set; }
        public bool IsColonized { get; set; }
        public bool IsDoubleDome { get; set; }
        public string Morale { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Population { get; set; }
        public FileObj Picture { get; set; }
        public FileObj Map { get; set; }
    }
}