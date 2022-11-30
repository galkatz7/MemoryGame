namespace Ex05
{
    internal partial class SettingsForm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.secondPlayerBtn = new System.Windows.Forms.Button();
            this.boardSizeBtn = new System.Windows.Forms.Button();
            this.firstPlayerLabel = new System.Windows.Forms.Label();
            this.secondPlayerLabel = new System.Windows.Forms.Label();
            this.firstPlayerTextBox = new System.Windows.Forms.TextBox();
            this.secondPlayerTextBox = new System.Windows.Forms.TextBox();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.startBtn.Location = new System.Drawing.Point(290, 165);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start!";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // secondPlayerBtn
            // 
            this.secondPlayerBtn.Location = new System.Drawing.Point(262, 50);
            this.secondPlayerBtn.Name = "secondPlayerBtn";
            this.secondPlayerBtn.Size = new System.Drawing.Size(103, 23);
            this.secondPlayerBtn.TabIndex = 1;
            this.secondPlayerBtn.Text = "Against a Friend";
            this.secondPlayerBtn.UseVisualStyleBackColor = true;
            this.secondPlayerBtn.Click += new System.EventHandler(this.secondPlayerBtn_Click);
            // 
            // boardSizeBtn
            // 
            this.boardSizeBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.boardSizeBtn.Location = new System.Drawing.Point(12, 126);
            this.boardSizeBtn.Name = "boardSizeBtn";
            this.boardSizeBtn.Size = new System.Drawing.Size(100, 64);
            this.boardSizeBtn.TabIndex = 2;
            this.boardSizeBtn.Text = "4x4";
            this.boardSizeBtn.UseVisualStyleBackColor = false;
            this.boardSizeBtn.Click += new System.EventHandler(this.boardSizeBtn_Click);
            // 
            // firstPlayerLabel
            // 
            this.firstPlayerLabel.AutoSize = true;
            this.firstPlayerLabel.Location = new System.Drawing.Point(15, 18);
            this.firstPlayerLabel.Name = "firstPlayerLabel";
            this.firstPlayerLabel.Size = new System.Drawing.Size(107, 15);
            this.firstPlayerLabel.TabIndex = 3;
            this.firstPlayerLabel.Text = "First Player Name:";
            //this.firstPlayerLabel.Click += new System.EventHandler(this.firstPlayerLabel_Click);
            // 
            // secondPlayerLabel
            // 
            this.secondPlayerLabel.AutoSize = true;
            this.secondPlayerLabel.Location = new System.Drawing.Point(15, 50);
            this.secondPlayerLabel.Name = "secondPlayerLabel";
            this.secondPlayerLabel.Size = new System.Drawing.Size(126, 15);
            this.secondPlayerLabel.TabIndex = 4;
            this.secondPlayerLabel.Text = "Second Player Name:";
            //this.secondPlayerLabel.Click += new System.EventHandler(this.secondPlayerLabel_Click);
            // 
            // firstPlayerTextBox
            // 
            this.firstPlayerTextBox.Location = new System.Drawing.Point(133, 18);
            this.firstPlayerTextBox.Name = "firstPlayerTextBox";
            this.firstPlayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstPlayerTextBox.TabIndex = 5;
            // 
            // secondPlayerTextBox
            // 
            this.secondPlayerTextBox.BackColor = System.Drawing.Color.White;
            this.secondPlayerTextBox.Enabled = false;
            this.secondPlayerTextBox.Location = new System.Drawing.Point(133, 50);
            this.secondPlayerTextBox.Name = "secondPlayerTextBox";
            this.secondPlayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondPlayerTextBox.TabIndex = 6;
            this.secondPlayerTextBox.Text = "- Compuer -";
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(12, 108);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(70, 15);
            this.boardSizeLabel.TabIndex = 7;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 200);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.secondPlayerTextBox);
            this.Controls.Add(this.firstPlayerTextBox);
            this.Controls.Add(this.secondPlayerLabel);
            this.Controls.Add(this.firstPlayerLabel);
            this.Controls.Add(this.boardSizeBtn);
            this.Controls.Add(this.secondPlayerBtn);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Memory Game - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_Closing);
        }
        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button secondPlayerBtn;
        private System.Windows.Forms.Button boardSizeBtn;
        private System.Windows.Forms.Label firstPlayerLabel;
        private System.Windows.Forms.Label secondPlayerLabel;
        private System.Windows.Forms.TextBox firstPlayerTextBox;
        private System.Windows.Forms.TextBox secondPlayerTextBox;
        private System.Windows.Forms.Label boardSizeLabel;
    }
}