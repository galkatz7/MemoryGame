using System;

namespace Ex05
{
    public class Player
    {
        private String m_Name;
        private int m_Id;
        public int m_Score = 0;
        public bool m_IsComputer;

        public String Name
        {
            get
            {
                return m_Name;
            }
        }

        public int Id
        {
            get
            {
                return m_Id;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }

            set
            {
                m_Score = value;
            }
        }

        public Player(int i_Id, String i_Name, bool i_IsComputer)
        {
            this.m_Id = i_Id;
            this.m_Name = i_Name;
            this.m_IsComputer = i_IsComputer;
        }

        public void Restart()
        {
            this.m_Score = 0;
        }
    }
}