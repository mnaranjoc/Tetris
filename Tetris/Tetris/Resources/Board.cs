using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Figures
{
    class Board
    {
        public int startPosition { get; set; }
        public static int multiplier = 25;

        public void printBoard(Graphics _graphics)
        {
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            var rectangle = new Rectangle(0, 0, 0, 0);

            for (int y = 0; y <= multiplier * 17; y = y + multiplier)
            {
                for (int x = 0; x <= multiplier * 10; x = x + multiplier)
                {
                    rectangle = new Rectangle(x, y, multiplier, multiplier);
                    _graphics.FillRectangle(myBrush, rectangle);
                }
            }
        }
    }
}
