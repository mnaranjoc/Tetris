using Tetris.Figures;

namespace Tetris.Resources
{
    class RandomFigure
    {
        private RandomFigure() { }

        public static IFigure GetFigure()
        {
            IFigure ret = null;
            int random = 3;

            switch (random)
            {
                case 3:
                    ret = new LeftL();
                    break;
            }

            return ret;
        }
    }
}
