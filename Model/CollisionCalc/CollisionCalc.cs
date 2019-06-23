
namespace Model
{
    // In case of multiple collitions should consider usign a octree implementation
    // but mind the recursion to avoid stackoverflow 
    public interface ICollisionCalc
    {
        float CollidedVolume();
    }
}
