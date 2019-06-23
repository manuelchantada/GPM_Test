
using System;

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
        public override bool Equals(object obj)
        {
            return obj is Coordinate coordinate &&
                   X == coordinate.X &&
                   Y == coordinate.Y &&
                   Z == coordinate.Z;
        }

        public static Coordinate CreateOffsetCoordinate(Coordinate seed, float x, float y, float z)
        {
            return new Coordinate(seed.X + x, seed.Y + y, seed.Z + z);
        }

        public static bool operator !=(Coordinate A, Coordinate B)
        {
            return !A.Equals(B);
        }
        public static bool operator ==(Coordinate A, Coordinate B)
        {
            return A.Equals(B);
        }

        public static float MinXof(Coordinate a, Coordinate b)
        {
            return a.X <= b.X ? a.X : b.X;
        }
        public static float MaxXof(Coordinate a, Coordinate b)
        {
            return a.X >= b.X ? a.X : b.X;
        }
        public static float MinYof(Coordinate a, Coordinate b)
        {
            return a.Y <= b.Y ? a.Y : b.Y;
        }
        public static float MaxYof(Coordinate a, Coordinate b)
        {
            return a.Y >= b.Y ? a.Y : b.Y;
        }
        public static float MinZof(Coordinate a, Coordinate b)
        {
            return a.Z <= b.Z ? a.Z : b.Z;
        }
        public static float MaxZof(Coordinate a, Coordinate b)
        {
            return a.Z >= b.Z ? a.Z : b.Z;
        }
    }
}
