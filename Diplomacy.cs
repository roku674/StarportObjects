//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public static class Diplomacy
    {
        private static readonly string[] _allies =
        {
            "Allie","Anxiety.jar","BananaDei","Bitcoin","Bodhi","CaptArcher","ComputerSheep",
            "Depression.Wav","Devila","Hokujinn","Jumjumbub1410",
            "Leaderkiller","Muzza269u","MRniceguy","Probation","Rancia","Taterchip","Towlie","WW3"
        };

        private static readonly string[] _enemies =
        {
            "Adapt","Altair","Ammimo","Awmalzo","Beansmasher","Booga.Booga","B-radk.","Dad","Darkside","Demon","Demon.",
            "Deegs","DrakeoTheRuler","Cockhead","Flint","Juneteenth","Meshuggah","McGee","PIRI-38-tinto","Pluto","Presto",
            "Revelation"," Ron ","RON-4-GOLD","Scar-Face","Slaven"
        };

        private static readonly string[] _nap = { "Fayil", "Legion", "Mega.Tron", "Pebo", "Shmandoor", "Ted" };

        public static string[] allies => _allies;
        public static string[] enemies => _enemies;
        public static string[] nap => _nap;
    }
}