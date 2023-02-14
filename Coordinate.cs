namespace StarportObjects
{
    public class Coordinate
    {
        public long X
        {
            get; set;
        }
        public long Y
        {
            get; set;
        }

        public Coordinate()
        {
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
