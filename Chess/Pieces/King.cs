using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class King : Piece
    {
        public bool firstMove { get; set; }
        public bool isInCheck { get; set; }

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
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {
            #region Path Checking
            // Returns false if the new tile has a piece with the same color as the moving piece
            if (board.GetTile(newx, newy).isOccupied)
            {
                if(board.GetTile(newx, newy).piece.color == board.GetTile(oldx, oldy).piece.color)
                {
                    return false;
                }
            }
            #endregion

            #region Movement
            // Returns false if the king is moving right or left (x coordinate changes) and the move isn't one space.
            if (newx != oldx && Math.Abs(newx - oldx) != 1)
            {
                return false;
            }

            // Returns false if the king is moving up or down (y coordinate changes) and the move isn't one space.
            if(newy != oldy && Math.Abs(newy - oldy) != 1)
            {
                return false;
            }
            #endregion

            return true;
        }
    }
}
