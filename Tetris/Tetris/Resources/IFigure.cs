using System.Drawing;

namespace Tetris.Resources
{
    public interface IFigure
    {
        int startPosition { get; set; }

        void printMe(Graphics _graphics);
    }
}
