namespace Ex05
{
    partial class MemoryGameBoard
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
            this.currentPlayer = new System.Windows.Forms.Label();
            this.playerOneScore = new System.Windows.Forms.Label();
            this.playerTwoScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // currentPlayer
            // 
            this.currentPlayer.AutoSize = true;
            this.currentPlayer.Location = new System.Drawing.Point(10, 162);
            this.currentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPlayer.Name = "currentPlayer";
            this.currentPlayer.Size = new System.Drawing.Size(0, 15);
            this.currentPlayer.TabIndex = 0;
            // 
            // playerOneScore
            // 
            this.playerOneScore.AutoSize = true;
            this.playerOneScore.Location = new System.Drawing.Point(10, 176);
            this.playerOneScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerOneScore.Name = "playerOneScore";
            this.playerOneScore.Size = new System.Drawing.Size(0, 15);
            this.playerOneScore.TabIndex = 1;
            // 
            // playerTwoScore
            // 
            this.playerTwoScore.AutoSize = true;
            this.playerTwoScore.Location = new System.Drawing.Point(10, 189);
            this.playerTwoScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerTwoScore.Name = "playerTwoScore";
            this.playerTwoScore.Size = new System.Drawing.Size(0, 15);
            this.playerTwoScore.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MemoryGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.playerTwoScore);
            this.Controls.Add(this.playerOneScore);
            this.Controls.Add(this.currentPlayer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemoryGameBoard";
            this.Text = "MemoryGameBoard";
            this.Load += new System.EventHandler(this.memoryGameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label currentPlayer;
        private System.Windows.Forms.Label playerOneScore;
        private System.Windows.Forms.Label playerTwoScore;
        private System.Windows.Forms.Timer timer;
    }
}