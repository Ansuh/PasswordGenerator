using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3DShapes
{
   public class Ellipsoid : AbstractShapes

    {
        float a { get; set; }
        float b { get; set; }
        float c { get; set; }

        public Ellipsoid()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;

            this.point = new Point();

        }

        public Ellipsoid (float a, float b, float c, Point p)
        {
            this.a = a;
            this.b = b;
            this.c = c;
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
