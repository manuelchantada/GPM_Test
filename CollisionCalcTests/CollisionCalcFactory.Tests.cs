﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;


namespace CollisionCalcTests
{
    [TestClass]
    public class CollisionCalcFactoryCreatesCubeCollisionCalc
    {
        readonly Cube A = new Cube(new Coordinate(1, 1, 1), 2);
        readonly Cube B = new Cube(new Coordinate(3, 3, 3), 5);

        [TestMethod]
        public void GivenTwoCubesFactoryCreatesCubeCollisionCalc()
        {
            ICollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            Assert.IsNotNull(calc);
            Assert.IsInstanceOfType(calc, typeof(CubeCollisionCalc) );
        }


    }
}
