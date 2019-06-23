using System;

namespace Model
{
    public class CubeCollisionCalc : ICollisionCalc
    {
        protected Cube A;
        protected Cube B;
        public CubeCollisionCalc(Cube a, Cube b)
        {
            A = a;
            B = b;
        }

        //Returns the colliding volume of the cubes A & B
        public float CollidedVolume()
        {
            Coordinate ALBB = A.GetNodes()[(int)Cube.Edges.LeftBottomBack];
            Coordinate ARTF = A.GetNodes()[(int)Cube.Edges.RightTopFront];
            Coordinate BLBB = B.GetNodes()[(int)Cube.Edges.LeftBottomBack];
            Coordinate BRTF = B.GetNodes()[(int)Cube.Edges.RightTopFront];

            return Math.Max( Coordinate.MinXof(ARTF, BRTF) - Coordinate.MaxXof(ALBB, BLBB), 0 )
                * Math.Max(Coordinate.MinYof(ARTF, BRTF) - Coordinate.MaxYof(ALBB, BLBB), 0 )
                * Math.Max( Coordinate.MinZof(ARTF, BRTF) - Coordinate.MaxZof(ALBB, BLBB), 0 );
        }
    }
}
