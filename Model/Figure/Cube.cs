using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cube : Figure
    {
        protected Coordinate Center;

        public enum Edges{
            LeftBottomBack,
            RightTopFront
        }
        public Cube(Coordinate center, float height)  {
            Center = center;
            float halfHeight = height / 2;
            Nodes = new Coordinate[2];

            Nodes[(int)Edges.LeftBottomBack] = new Coordinate(center.X - halfHeight,
                center.Y - halfHeight,
                center.Z - halfHeight); //left bottom back corner

            Nodes[(int)Edges.RightTopFront] = new Coordinate(center.X + halfHeight,
                center.Y + halfHeight,
                center.Z + halfHeight); //right top front corner
        }


    }
}
