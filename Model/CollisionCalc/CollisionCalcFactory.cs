
namespace Model
{
    public static class CollisionCalcFactory
    {
        //Factory Pattern allows to isolate the client to the type of objects it processes
        //wich makes it open to change

        //Given two cubes (A & B) returns a CubeCollisionCalc of both of them
        public static ICollisionCalc CreateCollisionCalc(Cube A, Cube B)
        {
            return new CubeCollisionCalc(A, B);
        }
    }
}
 