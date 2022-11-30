using System;
using System.Windows.Forms;

namespace Ex05
{
    internal partial class SettingsForm : Form
    {
        private MemoryGame m_MemoryGame;
        
        public MemoryGame MemoryGame
        {
            get
            {
                return this.m_MemoryGame;
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Closing(object sender, EventArgs e)
        {
            bool isAgainstComputer = !secondPlayerTextBox.Enabled;
            string colsAsStr = boardSizeBtn.Text[0].ToString();
            string rowsAsStr = boardSizeBtn.Text[2].ToString();
            string secondPlayerName;

            if (isAgainstComputer)
            {
                secondPlayerName = "Computer";
            }
            else
            {
                secondPlayerName = secondPlayerTextBox.Text;
            }

            Int32.TryParse(colsAsStr, out int numOfCols);   
            Int32.TryParse(rowsAsStr, out int numOfRows);
            this.m_MemoryGame = new MemoryGame(numOfRows, numOfCols, isAgainstComputer, firstPlayerTextBox.Text, secondPlayerName);
        }

        private void boardSizeBtn_Click(object sender, EventArgs e)
        {
            string[] boardSizesList = { "4x4", "4x5", "4x6", "5x4", "5x6", "6x4", "6x5", "6x6" };
            int currentIndex = Array.IndexOf(boardSizesList, boardSizeBtn.Text);

            boardSizeBtn.Text = boardSizesList[(currentIndex + 1) % boardSizesList.Length];
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void secondPlayerBtn_Click(object sender, EventArgs e)
        {
            string[] secondPlayerType = { "Against a Friend", "Against Computer" };
            int currentIndex = Array.IndexOf(secondPlayerType, secondPlayerBtn.Text);

            secondPlayerBtn.Text = secondPlayerType[(currentIndex + 1) % secondPlayerType.Length];
            secondPlayerTextBox.Enabled = !secondPlayerTextBox.Enabled;
            if (secondPlayerTextBox.Enabled)
            {
                secondPlayerTextBox.Text = "";
            }
            else
            {
                secondPlayerTextBox.Text = "- Compuer -";
            }
        }
    }
}