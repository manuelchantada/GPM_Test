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

            return Math.Max( Coordinate.minXof(ARTF, BRTF) - Coordinate.maxXof(ALBB, BLBB), 0 )
                * Math.Max(Coordinate.minYof(ARTF, BRTF) - Coordinate.maxYof(ALBB, BLBB), 0 )
                * Math.Max( Coordinate.minZof(ARTF, BRTF) - Coordinate.maxZof(ALBB, BLBB), 0 );
        }
    }
}
