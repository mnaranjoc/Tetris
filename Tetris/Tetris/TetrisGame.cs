using System;
using System.Windows.Forms;
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

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            timer.Interval = 300;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (coordinator == null)
            {
                coordinator = new Coordinator(grid.CreateGraphics());
            }
            coordinator.playGame();
        }
    }
}
