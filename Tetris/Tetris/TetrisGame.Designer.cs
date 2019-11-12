namespace Tetris
{
    partial class TetrisGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grid = new System.Windows.Forms.Panel();
            this.lblScoreFixed = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid.Location = new System.Drawing.Point(13, 26);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(277, 452);
            this.grid.TabIndex = 0;
            // 
            // lblScoreFixed
            // 
            this.lblScoreFixed.AutoSize = true;
            this.lblScoreFixed.Location = new System.Drawing.Point(13, 7);
            this.lblScoreFixed.Name = "lblScoreFixed";
            this.lblScoreFixed.Size = new System.Drawing.Size(38, 13);
            this.lblScoreFixed.TabIndex = 1;
            this.lblScoreFixed.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(58, 7);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(14, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 491);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreFixed);
            this.Controls.Add(this.grid);
            this.Name = "TetrisGame";
            this.Text = "TetrisGame";
            this.Load += new System.EventHandler(this.TetrisGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel grid;
        private System.Windows.Forms.Label lblScoreFixed;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer;
    }
}