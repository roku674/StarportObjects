//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public static class Diplomacy
    {
        private static readonly string[] _allies =
        {
            "Allie", "Anxiety.jar","Bitcoin", "Bodhi", "CaptArcher",
            "Depression.Wav", "Devila", "Hokujinn","Jumjumbub1410",
            "Leaderkiller","Probation", "Taterchip","Towlie", "WW3"
        };

        private static readonly string[] _enemies =
                {
            "Altair","Awmalzo","Booga.Booga", "B-radk.","Dad","Darkside", "Demon",
            "Deegs", "Flint","Juneteenth", "Meshuggah","McGee","Pluto","Presto",
            "Revelation","RONXINA","Scar-Face"
        };

        private static readonly string[] _nap = { };

        public static string[] allies => _allies;
        public static string[] enemies => _enemies;
        public static string[] nap => _nap;
    }
}