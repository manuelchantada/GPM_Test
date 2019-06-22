using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace CollisionCalcTests
{
    public enum Z { Top = 1, Bottom = -1, Aligned = 0, TopEdge = 2, BootomEdge = -2 }
    public enum Y { Right = 1, Left = -1, Aligned = 0, RightEdge = 2, LeftEdge = -2 }
    public enum X { Front = 1, Back = -1, Aligned = 0, FrontEdge = 2, BackEdge = -2 }

    [TestClass]
    public class CollidingCubesCollide
    {
        [DataTestMethod]
        [DataRow(0, 0, 0, 2, X.Front, Y.Right, Z.Top, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Left, Z.Top, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Left, Z.Top, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Right, Z.Top, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Right, Z.Bottom, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Left, Z.Bottom, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Left, Z.Bottom, 2, 1, "Edge")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Right, Z.Bottom, 2, 1, "Edge")]
        public void CubesCollidingFromEdgesCollide(int x, int y, int z, int height,
            X a, Y b, Z c, int height2, int expectedVolume, string test)
        {
            string testName = $"{a.ToString()} {b.ToString()} {c.ToString()} {test}";
            Cube A = new Cube(new Coordinate(x, y, z), height);
            Cube B = new Cube(new Coordinate((int)a, (int)b, (int)c), height2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Assert.AreEqual(expectedVolume, colidedVolume, testName);
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Aligned, Z.Top, 2, 4, "Side")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Aligned, Z.Bottom, 2, 4, "Side")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Aligned, Z.Aligned, 2, 4, "Side")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Aligned, Z.Aligned, 2, 4, "Side")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Left, Z.Aligned, 2, 4, "Side")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Right, Z.Aligned, 2, 4, "Edge")]
        public void CubesCollidingFromFullSidesCollide(int x, int y, int z, int height,
            X a, Y b, Z c, int height2, int expectedVolume, string test)
        {
            string testName = $"{a.ToString()} {b.ToString()} {c.ToString()} {test}";
            Cube A = new Cube(new Coordinate(x, y, z), height);
            Cube B = new Cube(new Coordinate((int)a, (int)b, (int)c), height2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Assert.AreEqual(expectedVolume, colidedVolume, testName);
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 2, X.Front, Y.Aligned, Z.Top, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Aligned, Z.Bottom, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Aligned, Z.Top, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Aligned, Z.Bottom, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Right, Z.Aligned, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Front, Y.Left, Z.Aligned, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Right, Z.Aligned, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Back, Y.Left, Z.Aligned, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Right, Z.Top, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Right, Z.Bottom, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Left, Z.Top, 2, 2, "Edges")]
        [DataRow(0, 0, 0, 2, X.Aligned, Y.Left, Z.Bottom, 2, 2, "Edges")]
        public void CubesCollidingFromFullTwoEdgesCollide(int x, int y, int z, int height,
            X a, Y b, Z c, int height2, int expectedVolume, string test)
        {
            string testName = $"{a.ToString()} {b.ToString()} {c.ToString()} {test}";
            Cube A = new Cube(new Coordinate(x, y, z), height);
            Cube B = new Cube(new Coordinate((int)a, (int)b, (int)c), height2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Assert.AreEqual(expectedVolume, colidedVolume, testName);
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 4, X.Aligned, Y.Aligned, Z.TopEdge, 2, 4, "Partially Inside")]
        [DataRow(0, 0, 0, 4, X.Aligned, Y.Aligned, Z.BootomEdge, 2, 4, "Partially Inside")]
        [DataRow(0, 0, 0, 4, X.Aligned, Y.RightEdge, Z.Aligned, 2, 4, "Partially Inside")]
        [DataRow(0, 0, 0, 4, X.Aligned, Y.LeftEdge, Z.Aligned, 2, 4, "Partially Inside")]
        [DataRow(0, 0, 0, 4, X.FrontEdge, Y.Aligned, Z.Aligned, 2, 4, "Partially Inside")]
        [DataRow(0, 0, 0, 4, X.BackEdge, Y.Aligned, Z.Aligned, 2, 4, "Partially Inside")]

        public void CubesCollidingFromPartiallyInsideCollide(int x, int y, int z, int height,
            X a, Y b, Z c, int height2, int expectedVolume, string test)
        {
            string testName = $"{a.ToString()} {b.ToString()} {c.ToString()} {test}";
            Cube A = new Cube(new Coordinate(x, y, z), height);
            Cube B = new Cube(new Coordinate((int)a, (int)b, (int)c), height2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Assert.AreEqual(expectedVolume, colidedVolume, testName);
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
