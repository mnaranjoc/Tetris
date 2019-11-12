using System.Collections.Generic;
using System.Drawing;

namespace Tetris.Resources
{
    public interface IFigure
    {
        Piece startPosition { get; set; }

        List<Piece> Map { get; set; }

        void move(int x, int y);
    }
}
