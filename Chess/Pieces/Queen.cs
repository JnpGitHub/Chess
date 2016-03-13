using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Queen : Piece
    {
        private static int value = 10;

        /// <summary>
        /// Creates a Queen piece and sets its symbol to Q
        /// </summary>
        public Queen(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            symbol = 'Q';
        }

        /// <summary>
        /// Returns true if a Queen can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(int oldx, int oldy, int newx, int newy)
        {
            return true;
        }
    }
}
