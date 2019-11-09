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
        LeftL leftL;

        public TetrisGame()
        {
            InitializeComponent();
        }

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            createFigure();

            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void createFigure()
        {
            leftL = new LeftL();
            leftL.printPicture(grid.CreateGraphics());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            leftL.startPosition = leftL.startPosition + 10;
            leftL.printPicture(grid.CreateGraphics());
        }
    }
}
