using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Figures;
using static Tetris.Resources.Constants;

namespace Tetris.Resources
{
    class Coordinator
    {
        private static Coordinator coordinator;
        private Graphics graphics { get; set; }
        private GameState gameState;

        private Coordinator() { }

        public static Coordinator GetCoordinator(Graphics graphics)
        {
            if (coordinator == null)
            {
                coordinator = new Coordinator();
                coordinator.graphics = graphics;
            }

            return coordinator;
        }

        public void playGame()
        {
            switch(gameState)
            {
                case GameState.None:
                    gameState = GameState.Started;
                    break;

                case GameState.Started:
                    this.createNewFigure();
                    gameState = GameState.WaitingForUser;
                    break;

                /*case GameState.WaitingForUser:
                    this.redrawBoard();
                    gameState = GameState.EvaluatingLines;
                    break;

                case GameState.EvaluatingLines:
                    gameState = GameState.Finished;
                    break;

                case GameState.Finished:
                    break;*/
            }
        }

        private void createNewFigure()
        {
            LeftL leftL = new LeftL();
            leftL.startPosition = leftL.startPosition + 10;
            leftL.printBoard();
        }
    }
}
