
namespace Model
{
    public class Figure : ICollidable
    {
        //Any figure is defined by its relevant Nodes
        protected Coordinate[] Nodes;

        public Coordinate[] GetNodes()
        {
            return Nodes;
        }
    }
}
