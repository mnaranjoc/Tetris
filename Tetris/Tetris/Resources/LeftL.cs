using System.Drawing;
using Tetris.Resources;

namespace Tetris.Figures
{
    class LeftL : IFigure
    {
        public int startPosition { get; set; }

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
