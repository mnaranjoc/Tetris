using System.Collections.Generic;
using System.Drawing;
using Tetris.Resources;

namespace Tetris.Figures
{
    class Board
    {
        Graphics graphics;
        private int[,] board;
        public IFigure CurrentFigure;

        public Board(Graphics graphics)
        {
            this.board = new int[10, 17];
            this.graphics = graphics;
        }

        public IFigure getCurrentFigure()
        {
            return CurrentFigure;
        }

        public bool addFigure(IFigure figure)
        {
            bool canAddfigure = this.tryAddFigure(figure);

            if (canAddfigure)
            {
                this.addFigure(figure.Map);
            }

            return canAddfigure;
        }

        private bool tryAddFigure(IFigure figure)
        {
            foreach (var piece in figure.Map)
            {
                if (board[piece.x, piece.y] == 1)
                {
                    return false;
                }
            }

            CurrentFigure = figure;

            return true;
        }

        private void addFigure(List<Piece> figureMap)
        {
            foreach (var piece in figureMap)
            {
                board[piece.x, piece.y] = 1;
            }
        }

        public void removeFigure(IFigure figure)
        {
            foreach (var piece in figure.Map)
            {
                board[piece.x, piece.y] = 0;
            }
        }

        public void printBoard()
        {
            graphics.Clear(Color.White);

            SolidBrush myBrush = new SolidBrush(Color.Blue);
            var rectangle = new Rectangle(0, 0, 0, 0);

            for (int y = 0; y < 17; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (board[x, y] == 1)
                    {
                        rectangle = new Rectangle(x * Constants.multiplier,
                                                  y * Constants.multiplier,
                                                  Constants.multiplier,
                                                  Constants.multiplier);

                        graphics.FillRectangle(myBrush, rectangle);
                    }
                }
            }
        }
    }
}
