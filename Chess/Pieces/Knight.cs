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
        public Knight(Player player, String color, Board board, int x, int y) : base(player, color, board, x, y)
        {
            symbol = 'N';
        }

        /// <summary>
        /// Returns true if a Knight can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            #region Path Checking
            // Returns false if the Knight tries to move to a space with a piece of the same color.
            if (board.GetTile(newPosX, newPosY).isOccupied)
            {
                if(board.GetTile(newPosX, newPosY).piece.color == board.GetTile(oldPosX, oldPosY).piece.color)
                {
                    return false;
                }
            }
            #endregion

            #region Movement
            // Returns false if the Knight tries to move horizontally or vertically.
            if (oldPosX == newPosX || oldPosY == newPosY)
            {
                return false;
            }

            // Returns false if the Knight tries to move more than two spaces.
            if(Math.Abs(oldPosX - newPosX) > 2 || Math.Abs(oldPosY - newPosY) > 2)
            {
                return false;
            }

            // Returns true if the Knight isn't trying to move diagonally.
            if (Math.Abs(oldPosX - newPosX) - Math.Abs(oldPosY - newPosY) == 1 || Math.Abs(oldPosX - newPosX) - Math.Abs(oldPosY - newPosY) == -1)
            {
                return true; 
            }
            #endregion

            return false;
        }
    }
}
