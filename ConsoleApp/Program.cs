using System;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube A = new Cube(new Coordinate(0, 0, 0), 2);
            Cube B = new Cube(new Coordinate(1, 1, 0), 2);
            CollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Console.WriteLine($"Collision Volume: {colidedVolume}");
            Console.ReadLine();
        }
    }
}
