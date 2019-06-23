
namespace Model
{
    public class Figure : ICollidable
    {
        protected Coordinate[] Nodes;
        public enum Edges
        {
            LeftBottomBack,
            RightTopFront
        }
        public Coordinate[] GetNodes()
        {
            return Nodes;
        }
    }
}
