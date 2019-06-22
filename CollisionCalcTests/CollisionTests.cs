using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace CollisionCalcTests
{
    [TestClass]
    public class CollidingCubesCollide
    {

        [DataTestMethod]
        [DataRow(0, 0, 0, 2, 1, 1, 1, 2, 1)] //Top Right Front Edge
        [DataRow(0, 0, 0, 2, 1, -1, 1, 2, 1)] //Top Left Front Edge
        [DataRow(0, 0, 0, 2, -1, -1, 1, 2, 1)] //Top Left Back Edge
        [DataRow(0, 0, 0, 2, -1, 1, 1, 2, 1)] //Top Rigth Back Edge
        public void CubesCollidingFromEdgesCollide(int x, int y, int z, int height, 
            int a, int b, int c, int height2, int expectedVolume)
        {
            Cube A = new Cube(new Coordinate(x, y, z), height);
            Cube B = new Cube(new Coordinate(a, b, c), height2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Assert.AreEqual(expectedVolume, colidedVolume);
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 2, 0, 0, 1, 2, 4)] //Top Full Side
        [DataRow(0, 0, 0, 2, 0, 0, -1, 2, 4)] //Bottom Full Side
        [DataRow(0, 0, 0, 2, 1, 0, 0, 2, 4)] //Front Full Side
        [DataRow(0, 0, 0, 2, -1, 0, 0, 2, 4)] //Back Full Side
        [DataRow(0, 0, 0, 2, 0, -1, 0, 2, 4)] //Left Full Side
        [DataRow(0, 0, 0, 2, 0, 1, 0, 2, 4)] //Right Rigth Back Edge
        public void CubesCollidingFromFullSidesCollide(int x, int y, int z, int height,
            int a, int b, int c, int height2, int expectedVolume)
        {
            Cube A = new Cube(new Coordinate(x, y, z), height);
            Cube B = new Cube(new Coordinate(a, b, c), height2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Assert.AreEqual(expectedVolume, colidedVolume);
        }
    }

    [TestClass]
    public class NotCollidingCubesDontCollide
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
