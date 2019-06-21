using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Shape : ICollidable
    {
        protected Coordinate[] Nodes;
        public Coordinate[] GetNodes()
        {
            return Nodes;
        }
    }
}
