using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;

namespace StarportObjects
{
    public class StarSystem
    {
        public static readonly uint MaxDefenses = 60;

        public string Name {
            get; set;
        }

        public StarSystem()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="currentDefenses"></param>
        /// <param name="planets"></param>
        /// <param name="port"></param>
        /// <param name="connectedSystems"></param>
        /// <param name="starType"></param>
        /// <param name="starColor"></param>
        /// <param name="picture"></param>
        /// <param name="map"></param>
        /// <param name="coordinates"></param>
        public StarSystem(string name, uint currentDefenses, List<Planet> planets, Starport port, List<string> connectedSystems, string starType, string starColor, FileObj picture, FileObj map, Coordinate coordinates)
        {
            Name = name;
            CurrentDefenses = currentDefenses;
            Planets = planets;
            Port = port;
            ConnectedSystems = connectedSystems;
            StarType = starType;
            StarColor = starColor;
            Picture = picture;
            MiniMap = map;
            Coordinates = coordinates;
        }

        [BsonId]
        public ObjectId Id {
            get; set;
        }

        public List<string> ConnectedSystems {
            get; set;
        }
        public uint CurrentDefenses {
            get; set;
        }
        public List<Planet> Planets {
            get; set;
        }
        public Starport Port {
            get; set;
        }
        public string StarType {
            get; set;
        }
        public string StarColor {
            get; set;
        }
        public FileObj Picture {
            get; set;
        }
        public FileObj MiniMap {
            get; set;
        }
        public Coordinate Coordinates {
            get; set;
        }

        public string GetSystemNameFromPlanet(Planet planet)
        {
            string location = planet.Name;
            string[] split = planet.Name.Split(" ");

            location = "";

            for (int i = 0;i < split.Length - 1;i++)
            {
                location += split[i] + " ";
            }
            location = location.Trim();
            return location;
        }
    }
}
