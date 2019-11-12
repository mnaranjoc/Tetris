using System;
using System.Collections.Generic;
using System.Drawing;
using Tetris.Resources;

namespace Tetris.Figures
{
    class LeftL : IFigure
    {
        public int startPosition { get; set; }
        public List<Piece> figureMap { get; set; }

        public LeftL()
        {
            figureMap = new List<Piece>();
            figureMap.Add(new Piece() { x = 1, y = 1 });
            figureMap.Add(new Piece() { x = 1, y = 2 });
            figureMap.Add(new Piece() { x = 1, y = 3 });
            figureMap.Add(new Piece() { x = 1, y = 4 });
            figureMap.Add(new Piece() { x = 2, y = 4 });
        }

        public void printMe(Graphics _graphics)
        {
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            var rectangle = new Rectangle(startPosition, startPosition, Constants.multiplier, Constants.multiplier);
            _graphics.FillRectangle(myBrush, rectangle);

            rectangle = new Rectangle(startPosition, startPosition + Constants.multiplier, Constants.multiplier, Constants.multiplier);
            _graphics.FillRectangle(myBrush, rectangle);

            rectangle = new Rectangle(startPosition, startPosition + Constants.multiplier, Constants.multiplier, Constants.multiplier);
            _graphics.FillRectangle(myBrush, rectangle);

            rectangle = new Rectangle(startPosition, startPosition + Constants.multiplier, Constants.multiplier, Constants.multiplier);
            _graphics.FillRectangle(myBrush, rectangle);
            
            rectangle = new Rectangle(startPosition + 10, startPosition + Constants.multiplier, Constants.multiplier, Constants.multiplier);
            _graphics.FillRectangle(myBrush, rectangle);
        }
    }
}
