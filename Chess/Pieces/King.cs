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
        public King(Player player, String color, Board board, int x, int y) : base(player, color, board, x, y)
        {
            firstMove = true;
            symbol = 'K';
        }

        /// <summary>
        /// Returns true if a King can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            #region Path Checking
            // Returns false if the new tile has a piece with the same color as the moving piece
            if (board.GetTile(newPosX, newPosY).isOccupied)
            {
                if(board.GetTile(newPosX, newPosY).piece.color == board.GetTile(oldPosX, oldPosY).piece.color)
                {
                    return false;
                }
            }
            #endregion

            #region Movement
            // Returns false if the king is moving right or left (x coordinate changes) and the move isn't one space.
            if (newPosX != oldPosX && Math.Abs(newPosX - oldPosX) != 1)
            {
                return false;
            }

            // Returns false if the king is moving up or down (y coordinate changes) and the move isn't one space.
            if(newPosY != oldPosY && Math.Abs(newPosY - oldPosY) != 1)
            {
                return false;
            }
            #endregion

            return true;
        }
    }
}
