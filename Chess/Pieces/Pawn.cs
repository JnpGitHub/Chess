using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        private static int value = 1;
        private bool firstMove;

        /// <summary>
        /// Creates a Pawn piece and sets its firstMove value to true
        /// </summary>
        public Pawn(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            firstMove = true;
            symbol = 'P';
        }

        /// <summary>
        /// Returns true if a Pawn can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(int oldx, int oldy, int newx, int newy)
        {
            return true;
        }
    }
}
