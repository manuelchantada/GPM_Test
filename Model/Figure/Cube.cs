
namespace Model
{
    public class Cube : Figure
    {
        protected Coordinate Center;

        public Cube(Coordinate center, float height)  {
            Center = center;
            float halfHeight = height / 2;
            Nodes = new Coordinate[2];

            Nodes[(int)Edges.LeftBottomBack] = Coordinate.CreateOffsetCoordinate(center, -halfHeight, -halfHeight, -halfHeight);

            Nodes[(int)Edges.RightTopFront] = Coordinate.CreateOffsetCoordinate(center, halfHeight, halfHeight, halfHeight);

        }


    }
}
