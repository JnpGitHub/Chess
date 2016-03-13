using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class King : Piece
    {
        private bool firstMove;             //Whether or not the piece has moved for use with castling

        /// <summary>
        /// Creates a King piece and sets its firstMove value to true and symbol to K
        /// </summary>
        public King(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            firstMove = true;
            symbol = 'K';
        }

        /// <summary>
        /// Returns true if a King can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(int oldx, int oldy, int newx, int newy)
        {
            return true;
        }
    }
}
