//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public static class Diplomacy
    {
        private static readonly string[] _allies =
        {
            "Allie","Anxiety.jar","BananaDei.exe","Bitcoin","Bodhi","CaptArcher","ComputerSheep",
            "Depression.Wav","Devila","Fayil","Hokujinn","Jumjumbub1410",
            "Leaderkiller","Muzza269u","MRniceguy","Probation","Rancia","Shmandoor","Taterchip","Towlie","WW3"
        };

        private static readonly string[] _enemies = {
            "Adapt","Altair","Ammimo","Awmalzo","Beansmasher","Booga.Booga","B-radk.","Casper.Ebk2282","Cockhead","Dad","Darkside","Demon","Demon.",
            "Deegs","DrakeoTheRuler","Flint","Hiri","Juneteenth","Meshuggah","McGee","OOKXCAWKX","PIRI-38-tinto","Pluto","Presto",
            "Revelation","River,"," Ron ","RON-4-GOLD","Scar-Face","Slaven"
        };

        private static readonly string[] _nap = { "Legion", "Mega.Tron", "Pebo", "Ted" };

        public static string[] allies => _allies;
        public static string[] enemies => _enemies;
        public static string[] nap => _nap;
    }
}