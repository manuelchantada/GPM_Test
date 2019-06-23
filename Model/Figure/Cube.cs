
namespace Model
{
    public class Cube : Figure
    {
        protected Coordinate Center;
        public enum Edges
        {
            LeftBottomBack,
            RightTopFront
        }
        //Given a center Coordinate and a height returns a Cube
        public Cube(Coordinate center, float height)  {
            Center = center;
            float halfHeight = height / 2;
            //In Case of a Cube only two Nodes are relevant. 
            Nodes = new Coordinate[2];

            Nodes[(int)Edges.LeftBottomBack] = Coordinate.CreateOffsetCoordinate(center, -halfHeight, -halfHeight, -halfHeight);

            Nodes[(int)Edges.RightTopFront] = Coordinate.CreateOffsetCoordinate(center, halfHeight, halfHeight, halfHeight);

        }
    }
}
