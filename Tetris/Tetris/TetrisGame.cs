using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Figures;
using Tetris.Resources;

namespace Tetris
{
    public partial class TetrisGame : Form
    {
        Coordinator coordinator;

        public TetrisGame()
        {
            InitializeComponent();
        }

        private void createFigure()
        {
            leftL = new Board();
            leftL.startPosition = leftL.startPosition + 10;
            leftL.printBoard(grid.CreateGraphics());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createFigure();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (coordinator == null)
            {
                coordinator = new Coordinator();
            }

            coordinator.playGame();
        }
    }
}
