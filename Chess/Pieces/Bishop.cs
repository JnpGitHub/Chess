using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Bishop : Piece
    {
        private static int value = 3;

        /// <summary>
        /// Creates a Bishop piece and sets its symbol to B
        /// </summary>
        public Bishop(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            symbol = 'B';
        }

        /// <summary>
        /// Returns true if a Bishop can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(int oldx, int oldy, int newx, int newy)
        {
            return true;
        }
    }
}
