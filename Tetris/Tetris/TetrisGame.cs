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
        Board leftL;

        public TetrisGame()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            coordinator = Coordinator.GetCoordinator(grid.CreateGraphics());
            coordinator.playGame();
        }
    }
}
