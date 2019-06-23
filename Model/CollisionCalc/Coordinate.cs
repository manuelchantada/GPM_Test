using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Coordinate
    {
        public float Y { get; set; }
        public float X { get; set; }
        public float Z { get; set; }
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
        public static bool operator !=(Coordinate A, Coordinate B)
        {
            return !A.Equals(B);
        }
        public static bool operator ==(Coordinate A, Coordinate B)
        {
            return A.Equals(B);
        }

        public static float minXof(Coordinate a, Coordinate b)
        {
            return a.X <= b.X ? a.X : b.X;
        }
        public static float maxXof(Coordinate a, Coordinate b)
        {
            return a.X >= b.X ? a.X : b.X;
        }
        public static float minYof(Coordinate a, Coordinate b)
        {
            return a.Y <= b.Y ? a.Y : b.Y;
        }
        public static float maxYof(Coordinate a, Coordinate b)
        {
            return a.Y >= b.Y ? a.Y : b.Y;
        }
        public static float minZof(Coordinate a, Coordinate b)
        {
            return a.Z <= b.Z ? a.Z : b.Z;
        }
        public static float maxZof(Coordinate a, Coordinate b)
        {
            return a.Z >= b.Z ? a.Z : b.Z;
        }
    }
}
