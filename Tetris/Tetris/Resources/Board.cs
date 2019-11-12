using System.Collections.Generic;
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

        public bool addFigure(List<Piece> figureMap)
        {
            bool canAddfigure = this.tryAddFigure(figureMap);

            if (canAddfigure)
            {
                this.addFig(figureMap);
            }

            return canAddfigure;
        }

        private bool tryAddFigure(List<Piece> figureMap)
        {
            foreach(var piece in figureMap)
            {
                if (board[piece.x, piece.y] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        private void addFig(List<Piece> figureMap)
        {
            foreach (var piece in figureMap)
            {
                board[piece.x, piece.y] = 1;
            }
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
