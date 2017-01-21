using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3DShapes
{
    public abstract class AbstractShapes
    {
        public abstract Point point { get; set; }
        public abstract float Volume();
        public abstract float Arema();
     

    }
}
