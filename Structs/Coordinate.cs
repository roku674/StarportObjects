namespace StarportObjects.Structs
{
    public struct Coordinate
    {
        public long X {
            get; set;
        }
        public long Y {
            get; set;
        }

        public Coordinate(long x, long y)
        {
            X = x;
            Y = y;
        }

        public string GetAsString()
        {
            return $"({X},{Y})";
        }
    }
}
