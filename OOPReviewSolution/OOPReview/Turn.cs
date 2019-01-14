using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview
{
    class Turn
    {
        //tracks the data representing one play of the 2 player game

        private int _Player1Roll;
        private int _Player2Roll;

        public int Player1Roll
        {
            get
            {
                return _Player1Roll;
            }
            set
            {
                _Player1Roll = value;
            }
        }

        public int Player2Roll { get; set; }
        
        public Turn()
        {

        }

        public Turn(int player1, int player2)
        {
            Player1Roll = player1;
            Player2Roll = player2;
        }

        //methods
        //public string FindRollResults()
        //{
        //  return results;
        //}
    }
}
