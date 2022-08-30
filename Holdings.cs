//Created by Alexander Fields https://github.com/roku674

using System;

namespace StarportObjects
{
    public class Holdings
    {
        private string _planetType;
        private int _hopsAway;
        private string _name;
        private string _location;
        private int _galaxyX;
        private int _galaxyY;
        private string _owner;
        private string _corporation;
        private DateTime _founded;
        private int _population;
        private float _popGrowth;
        private float _morale;
        private float _moraleChange;
        private string _governemnt;
        private int _credits;
        private float _credGrowth;
        private int _pollution;
        private float _pollutionRate;
        private int _disaster;
        private float _unProtect;
        private int _percConstruct;
        private int _percResearch;
        private int _percMilitary;
        private int _percHarvest;
        private string _currentlyBuilding;
        private int _buildMinutes;
        private int _ore;
        private int _ana;
        private int _med;
        private int _org;
        private int _oil;
        private int _ura;
        private int _equ;
        private int _spi;
        private int _nukes;
        private int _negotiators;
        private int _mines;
        private int _compoundMines;
        private int _flakCannons;
        private int _laserCannons;
        private int _shields;
        private int _solarShots;
        private int _solarFreq;
        private int _numDiscoveries;
        private string _discoveries;
        private bool _environment;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Holdings(string v, int v1)
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
        /// <param name="governemnt"></param>
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
        public Holdings(string planetType, int hopsAway, string name, string location, int galaxyX, int galaxyY, string owner,
            string corporation, DateTime founded, int population, float popGrowth, float morale, float moraleChange, string governemnt,
            int credits, float credGrowth, int pollution, float pollutionRate, int disaster, float unProtect, int percConstruct,
            int percResearch, int percMilitary, int percHarvest, string currentlyBuilding, int buildMinutes, int ore, int ana, int med,
            int org, int oil, int ura, int equ, int spi, int nukes, int negotiators, int mines, int compoundMines, int flakCannons,
            int laserCannons, int shields, int solarShots, int solarFreq, int numDiscoveries, string discoveries, bool environment)
        {
            this.planetType = planetType;
            this.hopsAway = hopsAway;
            this.name = name;
            this.location = location;
            this.galaxyX = galaxyX;
            this.galaxyY = galaxyY;
            this.owner = owner;
            this.corporation = corporation;
            this.founded = founded;
            this.population = population;
            this.popGrowth = popGrowth;
            this.morale = morale;
            this.moraleChange = moraleChange;
            this.governemnt = governemnt;
            this.credits = credits;
            this.credGrowth = credGrowth;
            this.pollution = pollution;
            this.pollutionRate = pollutionRate;
            this.disaster = disaster;
            this.unProtect = unProtect;
            this.percConstruct = percConstruct;
            this.percResearch = percResearch;
            this.percMilitary = percMilitary;
            this.percHarvest = percHarvest;
            this.currentlyBuilding = currentlyBuilding;
            this.buildMinutes = buildMinutes;
            this.ore = ore;
            this.ana = ana;
            this.med = med;
            this.org = org;
            this.oil = oil;
            this.ura = ura;
            this.equ = equ;
            this.spi = spi;
            this.nukes = nukes;
            this.negotiators = negotiators;
            this.mines = mines;
            this.compoundMines = compoundMines;
            this.flakCannons = flakCannons;
            this.laserCannons = laserCannons;
            this.shields = shields;
            this.solarShots = solarShots;
            this.solarFreq = solarFreq;
            this.numDiscoveries = numDiscoveries;
            this.discoveries = discoveries;
            this.environment = environment;
        }

        public string planetType { get => _planetType; set => _planetType = value; }
        public int hopsAway { get => _hopsAway; set => _hopsAway = value; }
        public string name { get => _name; set => _name = value; }
        public string location { get => _location; set => _location = value; }
        public int galaxyX { get => _galaxyX; set => _galaxyX = value; }
        public int galaxyY { get => _galaxyY; set => _galaxyY = value; }
        public string owner { get => _owner; set => _owner = value; }
        public string corporation { get => _corporation; set => _corporation = value; }
        public DateTime founded { get => _founded; set => _founded = value; }
        public int population { get => _population; set => _population = value; }
        public float popGrowth { get => _popGrowth; set => _popGrowth = value; }
        public float morale { get => _morale; set => _morale = value; }
        public float moraleChange { get => _moraleChange; set => _moraleChange = value; }
        public string governemnt { get => _governemnt; set => _governemnt = value; }
        public int credits { get => _credits; set => _credits = value; }
        public float credGrowth { get => _credGrowth; set => _credGrowth = value; }
        public int pollution { get => _pollution; set => _pollution = value; }
        public float pollutionRate { get => _pollutionRate; set => _pollutionRate = value; }
        public int disaster { get => _disaster; set => _disaster = value; }
        public float unProtect { get => _unProtect; set => _unProtect = value; }
        public int percConstruct { get => _percConstruct; set => _percConstruct = value; }
        public int percResearch { get => _percResearch; set => _percResearch = value; }
        public int percMilitary { get => _percMilitary; set => _percMilitary = value; }
        public int percHarvest { get => _percHarvest; set => _percHarvest = value; }
        public string currentlyBuilding { get => _currentlyBuilding; set => _currentlyBuilding = value; }
        public int buildMinutes { get => _buildMinutes; set => _buildMinutes = value; }
        public int ore { get => _ore; set => _ore = value; }
        public int ana { get => _ana; set => _ana = value; }
        public int med { get => _med; set => _med = value; }
        public int org { get => _org; set => _org = value; }
        public int oil { get => _oil; set => _oil = value; }
        public int ura { get => _ura; set => _ura = value; }
        public int equ { get => _equ; set => _equ = value; }
        public int spi { get => _spi; set => _spi = value; }
        public int nukes { get => _nukes; set => _nukes = value; }
        public int negotiators { get => _negotiators; set => _negotiators = value; }
        public int mines { get => _mines; set => _mines = value; }
        public int compoundMines { get => _compoundMines; set => _compoundMines = value; }
        public int flakCannons { get => _flakCannons; set => _flakCannons = value; }
        public int laserCannons { get => _laserCannons; set => _laserCannons = value; }
        public int shields { get => _shields; set => _shields = value; }
        public int solarShots { get => _solarShots; set => _solarShots = value; }
        public int solarFreq { get => _solarFreq; set => _solarFreq = value; }
        public int numDiscoveries { get => _numDiscoveries; set => _numDiscoveries = value; }
        public string discoveries { get => _discoveries; set => _discoveries = value; }
        public bool environment { get => _environment; set => _environment = value; }
    }
}