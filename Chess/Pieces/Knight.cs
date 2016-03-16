using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Knight : Piece
    {
        private static int value = 3;

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
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {
            #region Path Checking
            // Returns false if the Knight tries to move to a space with a piece of the same color.
            if (board.GetTile(newx, newy).isOccupied)
            {
                if(board.GetTile(newx, newy).piece.color == board.GetTile(oldx, oldy).piece.color)
                {
                    return false;
                }
            }
            #endregion

            #region Movement
            // Returns false if the Knight tries to move horizontally or vertically.
            if (oldx == newx || oldy == newy)
            {
                return false;
            }

            // Returns false if the Knight tries to move more than two spaces.
            if(Math.Abs(oldx - newx) > 2 || Math.Abs(oldy - newy) > 2)
            {
                return false;
            }

            // Returns true if the Knight isn't trying to move diagonally.
            if (Math.Abs(oldx - newx) - Math.Abs(oldy - newy) == 1 || Math.Abs(oldx - newx) - Math.Abs(oldy - newy) == -1)
            {
                return true; 
            }
            #endregion

            return false;
        }
    }
}
