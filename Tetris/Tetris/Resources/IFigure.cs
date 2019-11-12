using System.Collections.Generic;
using System.Drawing;

namespace Tetris.Resources
{
    public interface IFigure
    {
        int startPosition { get; set; }
        public List<Piece> figureMap { get; set; }

        void printMe(Graphics _graphics);
    }
}
