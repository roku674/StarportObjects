//Created by Alexander Fields https://github.com/roku674

using MongoDB.Bson.Serialization.Attributes;

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
        /// <param name="holding"></param>
        /// <param name="planetWeight"></param>
        /// <param name="currentDefenses"></param>
        /// <param name="isColonized"></param>
        /// <param name="isDoubleDome"></param>
        /// <param name="morale"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="population"></param>
        /// <param name="picture"></param>
        /// <param name="map"></param>
        public Planet(Holding holding, uint planetWeight, uint currentDefenses, bool isColonized, bool isDoubleDome, string morale, string name, string owner,string planetType, string population, FileObj picture, FileObj map)
        {
            Holding = holding;
            PlanetWeight = planetWeight;
            if (currentDefenses > defensesMax)
            {
                CurrentDefenses = 125;
            }
            else
            {
                CurrentDefenses = currentDefenses;
            }
            IsColonized = isColonized;
            IsDoubleDome = isDoubleDome;
            Morale = morale;
            Name = name;
            Owner = owner;
            PlanetType = planetType;
            Population = population;
            Picture = picture;
            Map = map;
        }

        public Holding Holding { get; set; }
        public uint PlanetWeight { get; set; }
        public uint CurrentDefenses { get; set; }
        public bool IsColonized { get; set; }
        public bool IsDoubleDome { get; set; }
        public bool AlertOnLand{ get; set;}
        public string Morale { get; set; }
        [BsonId]
        public string Name { get; set; }
        public string Owner { get; set; }
        public string PlanetType { get;set;}
        public string Population { get; set; }
        public FileObj Picture { get; set; }
        public FileObj Map { get; set; }
    }
}