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

namespace Tetris
{
    public partial class TetrisGame : Form
    {
        Board leftL;

        public TetrisGame()
        {
            InitializeComponent();
        }

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            
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
    }
}
