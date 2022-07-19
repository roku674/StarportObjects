//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public static class Diplomacy
    {
        private static readonly string[] _allies =
        {
        "Allie","Anxiety.jar","BananaDei","Bitcoin","Bodhi","CaptArcher","ComputerSheep",
        "Depression.Wav","Devila","Fayil","Hokujinn","Jumjumbub1410",
        "Leaderkiller","Muzza269u","MRniceguy","Probation","Rancia","Taterchip","Towlie","WW3"
        };

        private static readonly string[] _enemies =
        {
        "Adapt","Altair","Awmalzo","Booga.Booga","B-radk.","Dad","Darkside","Demon","Demon.",
        "Deegs","DrakeoTheRuler","Cockhead","Flint","Juneteenth","Meshuggah","McGee","Pluto","Presto",
        "Revelation"," Ron ","RONXINA","Scar-Face"
        };

        private static readonly string[] _nap = { "Legion", "Pebo", "Ted" };

        public static string[] allies => _allies;
        public static string[] enemies => _enemies;
        public static string[] nap => _nap;
    }
}