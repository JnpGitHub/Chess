using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Rook : Piece
    {
        private static int value = 5;

        /// <summary>
        /// Creates a Rook piece and sets its symbol to R
        /// </summary>
        public Rook(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            symbol = 'R';
        }

        /// <summary>
        /// Returns true if a Rook can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {
            return true;
        }
    }
}
