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
        public Rook(Player player, String color, Board board, int x, int y) : base(player, color, board, x, y)
        {
            symbol = 'R';
        }

        /// <summary>
        /// Returns true if a Rook can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            // Returns false if the new tile has a piece with the same color as the Rook
            if (board.GetTile(newPosX, newPosY).isOccupied)
            {
                if (board.GetTile(newPosX, newPosY).piece.color == board.GetTile(oldPosX, oldPosY).piece.color)
                {
                    return false;
                }
            }

            // When moving right, returns false if any space between the old location and new location are occupied
            if(newPosX > oldPosX)
            {
                for(int i = oldPosX + 1; i < newPosX; i++)
                {
                    if(board.GetTile(i, oldPosY).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving left, returns false if any space between the old location and the new location are occupied
            if(newPosX < oldPosX)
            {
                for(int i = oldPosX -1; i > newPosX; i--)
                {
                    if(board.GetTile(i, oldPosY).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving down, returns false if any space between the old location and the new location are occupied
            if(newPosY > oldPosY)
            {
                for(int i = oldPosY + 1; i < newPosY; i++)
                {
                    if(board.GetTile(oldPosX, i).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving up, returns false if any space between the old location and the new location are occupied
            if(newPosY < oldPosY)
            {
                for(int i = oldPosY - 1; i > newPosY; i--)
                {
                    if(board.GetTile(oldPosX, i).isOccupied)
                    {
                        return false;
                    }
                }
            }
            
            // Returns true if the new space is horizontal or vertical from the old space
            if(oldPosX == newPosX || oldPosY == newPosY)
            {
                return true;
            }

            return false;
        }
    }
}
