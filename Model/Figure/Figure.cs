
namespace Model
{
    public class Figure : ICollidable
    {
        protected Coordinate[] Nodes;
        public Coordinate[] GetNodes()
        {
            return Nodes;
        }
    }
}
