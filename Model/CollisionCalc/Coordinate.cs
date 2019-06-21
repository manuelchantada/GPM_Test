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

    }
}
