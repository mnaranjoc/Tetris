using System.Drawing;
using Tetris.Figures;
using static Tetris.Resources.Constants;

namespace Tetris.Resources
{
    class Coordinator
    {
        private Board board;
        private GameState gameState;

        public Coordinator(Graphics graphics)
        {
            board = new Board(graphics);
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
            IFigure figure = RandomFigure.GetFigure();
            figure.move(5, 0);
            board.addFigure(figure);
            board.printBoard();
        }

        private void moveFigure()
        {
            IFigure figure = board.CurrentFigure;
            Piece startPosition = figure.startPosition;

            board.removeFigure(figure);            
            startPosition.y++;
            figure.move(0, 1);
            board.addFigure(figure);
            board.printBoard();
        }
    }
}
