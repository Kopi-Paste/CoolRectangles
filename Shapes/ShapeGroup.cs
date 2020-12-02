using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRectangles.Shapes
{
    class ShapeGroup : Shape, IBuilder, IEnumerable<Shape>
    {
        public ShapeGroup(int horizontalPosition, int verticalPosition) : base(horizontalPosition, verticalPosition, 0, 0)
        {

        }
        List<Shape> shapesCollections = new List<Shape>();
        public void Add(Shape shape)
        {
            shapesCollections.Add(shape);
        }

        public IEnumerator<Shape> GetEnumerator()
        {
            return ((IEnumerable<Shape>)shapesCollections).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)shapesCollections).GetEnumerator();
        }
    }
}
