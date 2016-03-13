using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Knight : Piece
    {
        private static int value = 3;       //The amount of points this piece is worth

        /// <summary>
        /// Creates a Knight piece and sets its symbol to N
        /// </summary>
        public Knight(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            symbol = 'N';
        }

        /// <summary>
        /// Returns true if a Knight can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(int oldx, int oldy, int newx, int newy)
        {
            return true;
        }
    }
}
