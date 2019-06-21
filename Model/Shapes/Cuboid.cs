using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cuboid : Shape //TODO or TODO ???
    {
        protected Coordinate Center;
        public Cuboid(Coordinate center, int width, int height)
        {
            Center = center;
            Nodes = new Coordinate[8];  

        } 
    }
}
