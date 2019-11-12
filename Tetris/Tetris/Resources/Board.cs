using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Resources;

namespace Tetris.Figures
{
    class Board
    {
        public int startPosition { get; set; }

        public void printBoard(Graphics _graphics)
        {
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            var rectangle = new Rectangle(0, 0, 0, 0);

            for (int y = 0; y <= Constants.multiplier * 17; y = y + Constants.multiplier)
            {
                for (int x = 0; x <= Constants.multiplier * 10; x = x + Constants.multiplier)
                {
                    rectangle = new Rectangle(x, y, Constants.multiplier, Constants.multiplier);
                    _graphics.FillRectangle(myBrush, rectangle);
                }
            }
        }
    }
}
