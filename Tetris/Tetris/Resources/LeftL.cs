using System.Collections.Generic;
using Tetris.Resources;

namespace Tetris.Figures
{
    class LeftL : IFigure
    {
        public List<Piece> Map { get; set; }

        public Piece startPosition { get; set; }

        public LeftL()
        {
            startPosition = new Piece() { x = 0, y = 0 };

            Map = new List<Piece>();
            Map.Add(new Piece() { x = 0, y = 0 });
            Map.Add(new Piece() { x = 0, y = 1 });
            Map.Add(new Piece() { x = 0, y = 2 });
            Map.Add(new Piece() { x = 0, y = 3 });
            Map.Add(new Piece() { x = 1, y = 3 });
        }

        public void move(int x, int y)
        {
            this.startPosition = startPosition;
            List<Piece> tmpMap = new List<Piece>();            

            foreach (var piece in Map)
            {
                int newXPosi = piece.x;
                int newYPosi = piece.y;

                newXPosi += x;
                newYPosi += y;

                tmpMap.Add(new Piece() { x = newXPosi, y = newYPosi });
            }
            Map = tmpMap;
        }
    }
}
