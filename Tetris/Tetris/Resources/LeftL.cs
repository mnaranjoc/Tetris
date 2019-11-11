using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Figures
{
    class LeftL
    {
        public int startPosition { get; set; }

        public void printPicture(Graphics _graphics)
        {
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            var rectangle = new Rectangle(startPosition, startPosition, 10, 10);
            _graphics.FillRectangle(myBrush, rectangle);

            rectangle = new Rectangle(startPosition, startPosition + 10, 10, 10);
            _graphics.FillRectangle(myBrush, rectangle);

            rectangle = new Rectangle(startPosition, startPosition + 20, 10, 10);
            _graphics.FillRectangle(myBrush, rectangle);

            rectangle = new Rectangle(startPosition, startPosition + 30, 10, 10);
            _graphics.FillRectangle(myBrush, rectangle);
            
            rectangle = new Rectangle(startPosition + 10, startPosition + 30, 10, 10);
            _graphics.FillRectangle(myBrush, rectangle);
        }
    }
}
