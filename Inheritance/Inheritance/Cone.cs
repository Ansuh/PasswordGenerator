using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3DShapes
{
    public class Cone : AbstractShapes
    {
        float radius { get; set; }
        float height { get; set; }

        public Cone (float radius, float height, Point p)
        {

            this.radius = radius;
            this.height = height;
            this.point = p;
        }

        public override float Area()
        {



        }
        public override float Volume()
        {

        }
    }
}
