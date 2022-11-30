using System;

namespace Ex05
{
    public class MemoryGame
    {
        Player m_Player1;
        Player m_Player2;
        Player m_CurrentPlayerTurn;
        Board m_GameBoard;

        public Player Player1
        {
            get
            {
                return m_Player1;
            }
        }

        public Player Player2
        {
            get
            {
                return m_Player2;
            }
        }

        public Player CurrentPlayerTurn
        {
            get
            {
                return m_CurrentPlayerTurn;
            }

            set
            {
                m_CurrentPlayerTurn = value;
            }
        }

        public Board GameBoard
        {
            get
            {
                return m_GameBoard;
            }
        }

        public MemoryGame(int i_Rows, int i_Columns, bool i_AgainstComputer, string i_Player1Name, string i_Player2Name)
        {
            bool isComputer = true;

            this.m_Player1 = new Player(0, i_Player1Name, !isComputer);
            if (!i_AgainstComputer)
            {
                isComputer = !isComputer;
            } 

            this.m_Player2 = new Player(1, i_Player2Name, isComputer);
            this.m_GameBoard = new Board(i_Columns, i_Rows);
            this.m_CurrentPlayerTurn = m_Player1;
        }

        public void RestartGame()
        {
            this.m_CurrentPlayerTurn = this.Player1;
            this.m_GameBoard = new Board(this.m_GameBoard.GetColumns(), this.m_GameBoard.GetRows());
            this.Player1.Restart();
            this.Player2.Restart();
        }

        public void PlayNewTurn(string i_FirstBtnName, string i_SecondBtnName)
        {
            int firstCellRow = (int)Char.GetNumericValue(i_FirstBtnName[0]);
            int firstCellCol = (int)Char.GetNumericValue(i_FirstBtnName[1]);
            int secondCellRow = (int)Char.GetNumericValue(i_SecondBtnName[0]);
            int secondCellCol = (int)Char.GetNumericValue(i_SecondBtnName[1]);
            bool playerLostTurn = true;

            if (this.GameBoard.m_DataCell[firstCellRow, firstCellCol] == this.GameBoard.m_DataCell[secondCellRow, secondCellCol])
            {
                CurrentPlayerTurn.Score++;
                playerLostTurn = false;
            }
            else
            {
                this.GameBoard.UpdateRevealCellValue(firstCellCol, firstCellRow, false);
                this.GameBoard.UpdateRevealCellValue(secondCellCol, secondCellRow, false);
            }

            if (playerLostTurn)
            {
                this.SwitchPlayersTurn();
            }
        }

        public void PlayComputerTurn(out int o_Row, out int o_Col) 
        {
            int numOfRows = this.m_GameBoard.GetRows();
            int numOfCols = this.m_GameBoard.GetColumns();
            Random random = new Random();
            
            do
            {
                o_Row = random.Next(0, numOfRows);
                o_Col = random.Next(0, numOfCols);
            }
            while (this.m_GameBoard.m_RevealCell[o_Row, o_Col]);
        }

        public void SwitchPlayersTurn()
        {
            if (this.CurrentPlayerTurn.Id == this.Player1.Id)
            {
                this.CurrentPlayerTurn = this.Player2;
            }
            else
            {
                this.CurrentPlayerTurn = this.Player1;
            }
        }
    }
}