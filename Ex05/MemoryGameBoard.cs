using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex05
{
    public partial class MemoryGameBoard : Form
    {
        private const int k_MarginSize = 12;
        private const int k_CardSize = 100;
        private MemoryGame m_MemoryGame;
        private Button[,] m_ButtonsArr;
        private Button m_FirstClicked, m_SecondClicked;
    
        public MemoryGameBoard(MemoryGame i_CurrentGame)
        {
            this.m_MemoryGame = i_CurrentGame;
            this.initializeButtons();        
            InitializeComponent();
        }

        private void memoryGameBoard_Load(object sender, EventArgs e)
        {
            this.updateDisplay();
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (!(this.m_FirstClicked != null && this.m_SecondClicked != null))
            {
                int playerColor = 1;
                Button clickedButton = sender as Button;
                if (this.m_MemoryGame.CurrentPlayerTurn == this.m_MemoryGame.Player1)
                {
                    playerColor = 0;
                }

                showCard(clickedButton, playerColor);
                if (this.m_FirstClicked == null)
                {
                    this.m_FirstClicked = clickedButton;        
                }
                else 
                {
                    this.m_SecondClicked = clickedButton;
                    timer.Start();
                }      
            }
        }
        
        private void initializeButtons()
        {
            getDisplaySize(out int numOfRows, out int numOfCols, out int width, out int height);
            this.Size = new Size(width, height);
            this.m_ButtonsArr = new Button[numOfRows, numOfCols];
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    Button newButton = new Button();
                    newButton.BackColor = Color.LightGray;
                    newButton.Click += new EventHandler(card_Click);
                    string btnName = String.Format("{0}{1}", i, j);
                    newButton.Name = btnName;
                    newButton.Size = new Size(k_CardSize, k_CardSize);
                    newButton.Location = new Point(k_MarginSize + (j * (k_CardSize + k_MarginSize)), k_MarginSize + (i * (k_CardSize + k_MarginSize)));
                    hideCard(newButton);
                    this.Controls.Add(newButton);
                    this.m_ButtonsArr[i, j] = newButton;
                }
            }
        }

        private void updateDisplay()
        {
            getDisplaySize(out int numOfRows, out int numOfCols, out int width, out int height);
            this.Size = new Size(width, height);
            int lowestPointOfCards = numOfRows * (k_MarginSize + k_CardSize) + 2 * k_MarginSize;
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    Button currentBtn = this.m_ButtonsArr[i, j];
                    if(!this.m_MemoryGame.GameBoard.m_RevealCell[i, j])
                    {
                        hideCard(currentBtn);
                    }
                }
            }

            currentPlayer.Text = string.Format("Current Player: {0}", this.m_MemoryGame.CurrentPlayerTurn.Name);
            playerOneScore.Text = string.Format("{0}: {1} pairs", this.m_MemoryGame.Player1.Name, this.m_MemoryGame.Player1.Score);
            playerTwoScore.Text = string.Format("{0}: {1} pairs", this.m_MemoryGame.Player2.Name, this.m_MemoryGame.Player2.Score);
            currentPlayer.Location = new Point(k_MarginSize, lowestPointOfCards);
            playerOneScore.Location = new Point(k_MarginSize, lowestPointOfCards + 2 * k_MarginSize);
            playerTwoScore.Location = new Point(k_MarginSize, lowestPointOfCards + 4 * k_MarginSize);
            playerOneScore.BackColor = Color.LightBlue;
            playerTwoScore.BackColor = Color.LightPink;
            if (this.m_MemoryGame.CurrentPlayerTurn == this.m_MemoryGame.Player1)
            {
                currentPlayer.BackColor = Color.LightBlue;
            }
            else
            {
                currentPlayer.BackColor = Color.LightPink;
            }
        }

        private void getDisplaySize(out int o_NumOfRows, out int o_NumOfCols, out int o_Width, out int o_Height)
        {
            o_NumOfRows = this.m_MemoryGame.GameBoard.m_DataCell.GetLength(0);
            o_NumOfCols = this.m_MemoryGame.GameBoard.m_DataCell.GetLength(1);
            o_Width = o_NumOfCols * (k_CardSize + k_MarginSize) + 2 * k_MarginSize;
            o_Height = o_NumOfRows * (k_CardSize + k_MarginSize) + 150;
        }

        private void showCard(Button i_BtnToShow, int i_BackColor)
        { 
            convertLocation(i_BtnToShow.Name, out int col, out int row);
            if(!this.m_MemoryGame.GameBoard.RevealCell[row, col])
            {
                i_BtnToShow.Text = this.m_MemoryGame.GameBoard.m_DataCell[row, col].ToString();
                i_BtnToShow.Enabled = false;
                i_BtnToShow.BackColor = Color.Brown;
                if (i_BackColor == 0)
                {
                    i_BtnToShow.BackColor = Color.LightBlue;
                }
                else
                {
                    i_BtnToShow.BackColor = Color.LightPink;
                }

                this.m_MemoryGame.GameBoard.UpdateRevealCellValue(col, row, true);     
            }
        }

        private static void convertLocation(string i_BtnName, out int o_Col, out int o_Row)
        {
            o_Row = (int)Char.GetNumericValue(i_BtnName[0]);
            o_Col = (int)Char.GetNumericValue(i_BtnName[1]);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.m_MemoryGame.PlayNewTurn(this.m_FirstClicked.Name, this.m_SecondClicked.Name);
            this.m_FirstClicked = null;
            this.m_SecondClicked = null;
            timer.Stop();
            updateDisplay();
            if (this.m_MemoryGame.GameBoard.NumOfUnrevealedCells == 0)
            {
                timer.Stop();
                this.showExitDialog();
            }

            if (this.m_MemoryGame.CurrentPlayerTurn.m_IsComputer)
            {
                this.m_MemoryGame.PlayComputerTurn(out int rowfirst, out int colfirst);
                this.m_FirstClicked = this.m_ButtonsArr[rowfirst, colfirst];
                showCard(this.m_FirstClicked, 1);
                this.m_MemoryGame.PlayComputerTurn(out int rowsecond, out int colsecond);
                this.m_SecondClicked = this.m_ButtonsArr[rowsecond, colsecond];
                showCard(this.m_SecondClicked, 1);
                timer.Start();
                updateDisplay();    
            }
        }

        private void showExitDialog()
        {
            updateDisplay();
            string dialog = String.Format("GAME OVER! {0}{1} has {2} points.{0}{3} has {4} points.{0}Do you want to play again?", Environment.NewLine, this.m_MemoryGame.Player1.Name, this.m_MemoryGame.Player1.Score, this.m_MemoryGame.Player2.Name, this.m_MemoryGame.Player2.Score);
            DialogResult exitDialog = MessageBox.Show(dialog, "Game over", MessageBoxButtons.YesNo);
            switch (exitDialog)
            {
                case DialogResult.Yes:
                    this.m_MemoryGame.RestartGame();
                    this.updateDisplay();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }

        private void hideCard(Button i_BtnToHide)
        {
            convertLocation(i_BtnToHide.Name, out int col, out int row);
            i_BtnToHide.Text = "";
            i_BtnToHide.BackColor = Color.LightGray;
            i_BtnToHide.Enabled = true;
        }
    }       
}