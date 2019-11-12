using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Resources
{
    class Constants
    {
        public static int multiplier = 25;
        public enum GameState { None, Started, WaitingForUser, EvaluatingLines, Finished };
    }
}
