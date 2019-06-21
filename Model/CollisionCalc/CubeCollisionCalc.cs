using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CubeCollisionCalc : CollisionCalc
    {
        protected Cube A;
        protected Cube B;
        public CubeCollisionCalc(Cube a, Cube b)
        {
            A = a;
            B = b;
        }

        public float CollidedVolume()
        {
            Coordinate ALBB = A.GetNodes()[(int)Cube.Edges.LeftBottomBack];
            Coordinate ARTF = A.GetNodes()[(int)Cube.Edges.RightTopFront];
            Coordinate BLBB = B.GetNodes()[(int)Cube.Edges.LeftBottomBack];
            Coordinate BRTF = B.GetNodes()[(int)Cube.Edges.RightTopFront];

            return Math.Max( Math.Min(ARTF.X, BRTF.X) - Math.Max(ALBB.X, BLBB.X), 0 )
                * Math.Max( Math.Min(ARTF.Y, BRTF.Y) - Math.Max(ALBB.Y, BLBB.Y), 0 )
                * Math.Max( Math.Min(ARTF.Z, BRTF.Z) - Math.Max(ALBB.Z, BLBB.Z), 0 );
        }
    }
}
