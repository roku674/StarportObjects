//Created by Alexander Fields https://github.com/roku674

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace StarportObjects
{
    /// <summary>
    /// Based on Toonces' Holdings CSV
    /// </summary>
    public class Holding
    {     
        /// <summary>
        /// Default constructor
        /// </summary>
        public Holding()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="planetType"></param>
        /// <param name="hopsAway"></param>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="galaxyX"></param>
        /// <param name="galaxyY"></param>
        /// <param name="owner"></param>
        /// <param name="corporation"></param>
        /// <param name="founded"></param>
        /// <param name="population"></param>
        /// <param name="popGrowth"></param>
        /// <param name="morale"></param>
        /// <param name="moraleChange"></param>
        /// <param name="government"></param>
        /// <param name="credits"></param>
        /// <param name="credGrowth"></param>
        /// <param name="pollution"></param>
        /// <param name="pollutionRate"></param>
        /// <param name="disaster"></param>
        /// <param name="unProtect"></param>
        /// <param name="percConstruct"></param>
        /// <param name="percResearch"></param>
        /// <param name="percMilitary"></param>
        /// <param name="percHarvest"></param>
        /// <param name="currentlyBuilding"></param>
        /// <param name="buildMinutes"></param>
        /// <param name="ore"></param>
        /// <param name="ana"></param>
        /// <param name="med"></param>
        /// <param name="org"></param>
        /// <param name="oil"></param>
        /// <param name="ura"></param>
        /// <param name="equ"></param>
        /// <param name="spi"></param>
        /// <param name="nukes"></param>
        /// <param name="negotiators"></param>
        /// <param name="mines"></param>
        /// <param name="compoundMines"></param>
        /// <param name="flakCannons"></param>
        /// <param name="laserCannons"></param>
        /// <param name="shields"></param>
        /// <param name="solarShots"></param>
        /// <param name="solarFreq"></param>
        /// <param name="numDiscoveries"></param>
        /// <param name="discoveries"></param>
        /// <param name="environment"></param>
        public Holding(string planetType, int hopsAway, string name, string location, int galaxyX, int galaxyY, string owner, string corporation, string founded, double population, double popGrowth, double morale, double moraleChange, string government, int credits, double credGrowth, int pollution, double pollutionRate, int disaster, double unProtect, int percConstruct, int percResearch, int percMilitary, int percHarvest, string currentlyBuilding, int buildMinutes, int ore, int ana, int med, int org, int oil, int ura, int equ, int spi, int nukes, int negotiators, int mines, int compoundMines, int flakCannons, int laserCannons, int shields, int solarShots, int solarFreq, int numDiscoveries, string discoveries, bool environment)
        {
            PlanetType = planetType;
            HopsAway = hopsAway;
            Name = name;
            Location = location;
            GalaxyX = galaxyX;
            GalaxyY = galaxyY;
            Owner = owner;
            Corporation = corporation;
            Founded = founded;
            Population = population;
            PopGrowth = popGrowth;
            Morale = morale;
            MoraleChange = moraleChange;
            Government = government;
            Credits = credits;
            CredGrowth = credGrowth;
            Pollution = pollution;
            PollutionRate = pollutionRate;
            Disasters = disaster;
            UNProtect = unProtect;
            PercConstruct = percConstruct;
            PercResearch = percResearch;
            PercMilitary = percMilitary;
            PercHarvest = percHarvest;
            CurrentBuild = currentlyBuilding;
            BuildMinutes = buildMinutes;
            Ore = ore;
            Ana = ana;
            Med = med;
            Org = org;
            Oil = oil;
            Ura = ura;
            Equ = equ;
            Spi = spi;
            Nukes = nukes;
            Negotiators = negotiators;
            Mines = mines;
            CompoundMines = compoundMines;
            FlakCannons = flakCannons;
            LaserCannons = laserCannons;
            Shields = shields;
            Solarshots = solarShots;
            Solarfreq = solarFreq;
            NumDiscovs = numDiscoveries;
            Discoveries = discoveries;
            Environment = environment;
        }


        /// <summary>
        /// Planet type
        /// </summary>
        public string PlanetType {
            get; set;
        }

        /// <summary>
        /// Number of hops away
        /// </summary>
        public int HopsAway {
            get; set;
        }

        /// <summary>
        /// Holding name
        /// </summary>
        public string Name {
            get; set;
        }

        [BsonId]
        /// <summary>
        /// Location of the holding
        /// </summary>
        public string Location {
            get; set;
        }

        /// <summary>
        /// Galaxy X coordinate
        /// </summary>
        public int GalaxyX {
            get; set;
        }

        /// <summary>
        /// Galaxy Y coordinate
        /// </summary>
        public int GalaxyY {
            get; set;
        }

        /// <summary>
        /// Owner of the holding
        /// </summary>
        public string Owner {
            get; set;
        }

        /// <summary>
        /// Corporation of the holding
        /// </summary>
        public string Corporation {
            get; set;
        }

        /// <summary>
        /// Date the holding was founded
        /// </summary>
        public string Founded {
            get; set;
        }

        /// <summary>
        /// Population of the holding
        /// </summary>
        public double Population {
            get; set;
        }

        /// <summary>
        /// Population growth rate
        /// </summary>
        public double PopGrowth {
            get; set;
        }

        /// <summary>
        /// Morale of the holding
        /// </summary>
        public double Morale {
            get; set;
        }

        /// <summary>
        /// Morale change rate
        /// </summary>
        public double MoraleChange {
            get; set;
        }

        /// <summary>
        /// Government of the holding
        /// </summary>
        public string Government {
            get; set;
        }

        /// <summary>
        /// Credits of the holding
        /// </summary>
        public int Credits {
            get; set;
        }

        /// <summary>
        /// Credit growth rate
        /// </summary>
        public double CredGrowth {
            get; set;
        }

        /// <summary>
        /// Pollution level of the holding
        /// </summary>
        public int Pollution {
            get; set;
        }

        /// <summary>
        /// Pollution rate
        /// </summary>
        public double PollutionRate {
            get; set;
        }

        /// <summary>
        /// Disaster level of the holding
        /// </summary>
        public int Disasters {
            get; set;
        }

        /// <summary>
        /// Unprotected level of the holding
        /// </summary>
        public double UNProtect {
            get; set;
        }

        /// <summary>
        /// Percentage of construction at the holding
        /// </summary>
        public int PercConstruct {
            get; set;
        }

        /// <summary>
        /// Percentage of research at the holding
        /// </summary>
        public int PercResearch {
            get; set;
        }

        /// <summary>
        /// Percentage of military at the holding
        /// </summary>
        public int PercMilitary {
            get; set;
        }
        /// <summary>
        /// Percentage of resources harvested
        /// </summary>
        public int PercHarvest {
            get; set;
        }

        /// <summary>
        /// The building currently being constructed
        /// </summary>
        public string CurrentBuild {
            get; set;
        }

        /// <summary>
        /// The remaining minutes to finish building construction
        /// </summary>
        public int BuildMinutes {
            get; set;
        }

        /// <summary>
        /// The amount of ore
        /// </summary>
        public int Ore {
            get; set;
        }

        /// <summary>
        /// The amount of Anaerobes
        /// </summary>
        public int Ana {
            get; set;
        }

        /// <summary>
        /// The amount of Medicine
        /// </summary>
        public int Med {
            get; set;
        }

        /// <summary>
        /// The amount of Organics
        /// </summary>
        public int Org {
            get; set;
        }

        /// <summary>
        /// The amount of Oil
        /// </summary>
        public int Oil {
            get; set;
        }

        /// <summary>
        /// The amount of Uranium
        /// </summary>
        public int Ura {
            get; set;
        }

        /// <summary>
        /// The amount of Equipment
        /// </summary>
        public int Equ {
            get; set;
        }

        /// <summary>
        /// The amount of Spice
        /// </summary>
        public int Spi {
            get; set;
        }

        /// <summary>
        /// The amount of Nukes
        /// </summary>
        public int Nukes {
            get; set;
        }

        /// <summary>
        /// The amount of Negotiators
        /// </summary>
        public int Negotiators {
            get; set;
        }

        /// <summary>
        /// The amount of Mines
        /// </summary>
        public int Mines {
            get; set;
        }

        /// <summary>
        /// The amount of Compound Mines
        /// </summary>
        public int CompoundMines {
            get; set;
        }

        /// <summary>
        /// The amount of Flak Cannons
        /// </summary>
        public int FlakCannons {
            get; set;
        }

        /// <summary>
        /// The amount of Laser Cannons
        /// </summary>
        public int LaserCannons {
            get; set;
        }

        /// <summary>
        /// The amount of Shields
        /// </summary>
        public int Shields {
            get; set;
        }

        /// <summary>
        /// The amount of Solar Shots
        /// </summary>
        public int Solarshots {
            get; set;
        }

        /// <summary>
        /// The frequency of Solar Shots
        /// </summary>
        public int Solarfreq{
            get;set;
        }
        /// <summary>
        /// Amount of discoveries
        /// </summary>
        public int NumDiscovs {
            get; set;
        }
        /// <summary>
        /// Researches
        /// </summary>
        public string Discoveries {
            get; set;
        }
        /// <summary>
        /// is on environment 1 for yes
        /// </summary>
        public bool Environment {
            get; set;
        }
    }
    public class HoldingComparer : IEqualityComparer<Holding>
    {
        public bool Equals(Holding x, Holding y)
        {
            return x.Location == y.Location;
        }

        public int GetHashCode(Holding obj)
        {
            return obj.Location.GetHashCode();
        }
    }
}