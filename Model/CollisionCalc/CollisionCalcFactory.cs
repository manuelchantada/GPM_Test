using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public static class CollisionCalcFactory
    {
        public static CollisionCalc CreateCollisionCalc(Cube A, Cube B)
        {
            return new CubeCollisionCalc(A, B);
        }
    }
}
 