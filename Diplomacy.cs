//Created by Alexander Fields https://github.com/roku674

namespace StarportObjects
{
    public static class Diplomacy
    {
        private static string[] _allies;
        private static string[] _enemies;
        private static string[] _nap;

        public static string[] allies { get => _allies; set => _allies = value; }
        public static string[] enemies { get => _enemies; set => _enemies = value; }
        public static string[] nap { get => _nap; set => _nap = value; }
    }
}