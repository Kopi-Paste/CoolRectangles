using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoolRectangles.Shapes
{
    interface IBuilder
    {
        void Add(Shape shape);
    }
}
