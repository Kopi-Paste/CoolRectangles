using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRectangles.Shapes
{
    abstract class Shape
    {
        public Shape(int horizontalPosition, int verticalPosition, int scaleX, int scaleY)
        {
            if (horizontalPosition < 0 || verticalPosition < 0)
                throw new ArgumentException("Incorrect position!");
            if (scaleX <= 0 || scaleY <= 0)
                throw new ArgumentException("Incorrect scale!");

            Position.HorizontalPosition = horizontalPosition;
            Position.VerticalPosition = verticalPosition;
            Scale.ScaleX = scaleX;
            Scale.ScaleY = scaleY;
        }
        
        public Position Position { get; private set; }
        public Scale Scale { get; private set; }

        protected Shape partOf { get; set; } = null;
    }
}
