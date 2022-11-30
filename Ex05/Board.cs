using System;
using System.Linq;

namespace Ex05
{
    public class Board
    {
        public char[,] m_DataCell;
        public bool[,] m_RevealCell;
        private int m_NumOfUnrevealedCells;

        public bool[,] RevealCell
        {
            get
            {
                return m_RevealCell;
            }

            set
            {
                m_RevealCell = value;
            }
        }

        public int NumOfUnrevealedCells
        {
            get
            {
                return m_NumOfUnrevealedCells;
            }

            set
            {
                m_NumOfUnrevealedCells = value;
            }
        }

        public Board(int i_Columns, int i_Rows)
        {
            this.m_DataCell = RandomAllocation(i_Columns, i_Rows);
            this.m_RevealCell = new bool[i_Rows, i_Columns];
            this.m_NumOfUnrevealedCells = i_Columns * i_Rows;
        }

        public char[,] RandomAllocation(int i_Columns, int i_Rows)
        {
            int numOfCells = i_Columns * i_Rows;
            char[,] currentBoard = new char[i_Rows, i_Columns];
            char[] couplesArray = new char[numOfCells];
            int indexForLetter = 0;

            for(int i = 0; i < numOfCells; i+=2)
            {
                char currentLetter = (char)('A' + indexForLetter);
                couplesArray[i] = currentLetter;
                couplesArray[i + 1] = currentLetter;
                indexForLetter++;
            }

            Random random = new Random();
            couplesArray = couplesArray.OrderBy(x => random.Next()).ToArray();
            int indexForCouplesArray = 0;
            for (int i = 0; i < i_Rows; i++)
            {
                for (int j = 0; j < i_Columns; j++)
                {
                    currentBoard[i, j] = couplesArray[indexForCouplesArray];
                    indexForCouplesArray++;
                }
            }

            return currentBoard;
        }

        public int GetRows()
        {
            return this.m_DataCell.GetLength(0);
        }

        public int GetColumns()
        {
            return this.m_DataCell.GetLength(1);
        }

        public void UpdateRevealCellValue(int i_Col, int i_Row, bool i_Value) 
        {
            this.RevealCell[i_Row, i_Col] = i_Value;
            if (i_Value)
            {
                this.NumOfUnrevealedCells--;
            }
            else
            {
                this.NumOfUnrevealedCells++;
            }
        }
    }
}