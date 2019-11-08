using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class TetrisGame : Form
    {
        public TetrisGame()
        {
            InitializeComponent();
        }

        private void TetrisGame_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Graphics graphics = grid.CreateGraphics();

            SolidBrush myBrush = new SolidBrush(Color.Blue);
            var rectangle = new Rectangle(20, 20, 8, 8);

            graphics.FillRectangle(myBrush, rectangle);
        }
    }
}
