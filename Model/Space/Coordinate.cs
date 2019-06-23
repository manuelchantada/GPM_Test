
namespace Model
{
    public class Coordinate
    {
        protected float Y { get; set; }
        protected float X { get; set; }
        protected float Z { get; set; }
        public Coordinate(float x, float y, float z)
        {
            Y = y;
            X = x;
            Z = z;
        }
        //Given a seed Coordinate, returns A Coordinate with offset x y z
        public static Coordinate CreateOffsetCoordinate(Coordinate seed, float x, float y, float z)
        {
            return new Coordinate(seed.X + x, seed.Y + y, seed.Z + z);
        }

        //Given two coordinates (a, b) returns the min X coordinate of both
        public static float MinXof(Coordinate a, Coordinate b)
        {
            return a.X <= b.X ? a.X : b.X;
        }
        //Given two coordinates (a, b) returns the max X coordinate of both
        public static float MaxXof(Coordinate a, Coordinate b)
        {
            return a.X >= b.X ? a.X : b.X;
        }
        //Given two coordinates (a, b) returns the min y coordinate of both
        public static float MinYof(Coordinate a, Coordinate b)
        {
            return a.Y <= b.Y ? a.Y : b.Y;
        }
        //Given two coordinates (a, b) returns the max Y coordinate of both
        public static float MaxYof(Coordinate a, Coordinate b)
        {
            return a.Y >= b.Y ? a.Y : b.Y;
        }
        //Given two coordinates (a, b) returns the min Z coordinate of both
        public static float MinZof(Coordinate a, Coordinate b)
        {
            return a.Z <= b.Z ? a.Z : b.Z;
        }
        //Given two coordinates (a, b) returns the max Z coordinate of both
        public static float MaxZof(Coordinate a, Coordinate b)
        {
            return a.Z >= b.Z ? a.Z : b.Z;
        }
    }
}
