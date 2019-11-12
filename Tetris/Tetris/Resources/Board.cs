using System.Drawing;
using Tetris.Resources;

namespace Tetris.Figures
{
    class Board
    {
        private int[,] board;

        public Board()
        {
            board = new int[10,17];
        }

        public bool fillValues()
        {
            bool trySetValues = this.trySetValues();

            if (trySetValues)
            {
                this.setValues();
            }

            return trySetValues;
        }

        private bool trySetValues()
        {
            return true;
        }

        private void setValues()
        {

        }

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
