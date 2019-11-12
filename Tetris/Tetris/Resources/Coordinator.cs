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
        private Board board;
        private IFigure figure;
        private Graphics graphics { get; set; }
        private GameState gameState;

        public Coordinator(Graphics graphics)
        {
            this.graphics = graphics;
            board = new Board();
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

                case GameState.WaitingForUser:
                    this.moveFigure();
                    gameState = GameState.EvaluatingLines;
                    break;

                case GameState.EvaluatingLines:
                    gameState = GameState.WaitingForUser;
                    break;

                case GameState.Finished:
                    break;
            }
        }

        private void createNewFigure()
        {
            figure = RandomFigure.GetFigure();
            figure.startPosition = figure.startPosition + 10;
            figure.printMe(graphics);
        }

        private void moveFigure()
        {
            figure.startPosition = figure.startPosition + 10;
            figure.printMe(graphics);
        }
    }
}
