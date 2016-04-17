using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Bishop : Piece
    {
        private static int value = 3;

        /// <summary>
        /// Creates a Bishop piece and sets its symbol to B
        /// </summary>
        public Bishop(Player player, String color, Board board, int x, int y) : base(player, color, board, x, y)
        {
            symbol = 'B';
        }

        /// <summary>
        /// Returns true if a Bishop can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            #region Path Checking
            // Returns false if the new tile has a piece with the same color as the Bishop
            if(board.GetTile(newPosX, newPosY).isOccupied)
            {
                if (board.GetTile(newPosX, newPosY).piece.color == board.GetTile(oldPosX, oldPosY).piece.color)
                {
                    return false;
                }
            }

            
            // When moving down right, returns false if any space between the old spot and new spot are occupied
            if (newPosX > oldPosX && newPosY > oldPosY)
            {
                int y = oldPosY + 1;
                for (int x = oldPosX + 1; x < newPosX; x++)
                {
                    if (x >= 0 && x < Board.columns && y >= 0 && y < Board.rows)
                    {
                        if (board.GetTile(x, y).isOccupied)
                        {
                            return false;
                        }
                    }
                    y++;
                }
            }

            // When moving down left, returns false if any space between the old spot and new spot are occupied
            if (newPosX < oldPosX && newPosY > oldPosY)
            {
                int x = oldPosX - 1;
                for (int y = oldPosY + 1; y < newPosY; y++)
                {
                    if (x >= 0 && x < Board.columns && y >= 0 && y < Board.rows)
                    {
                        if (board.GetTile(x, y).isOccupied)
                        {
                            return false;
                        }
                    }
                    x--;
                }
            }

            // When moving up right, returns false if any space between the old spot and new spot are occupied
            if (newPosX > oldPosX && newPosY < oldPosY)
            {
                int y = oldPosY - 1;
                for (int x = oldPosX + 1; x < newPosX; x++)
                {
                    if (x >= 0 && x < Board.columns && y >= 0 && y < Board.rows)
                    {
                        if (board.GetTile(x, y).isOccupied)
                        {
                            return false;
                        }
                    }
                    y--;
                }
            }

            // When moving up left, returns false if any space between the old spot and new spot are occupied
            if (newPosX < oldPosX && newPosY < oldPosY)
            {
                int y = oldPosY - 1;
                for (int x = oldPosX - 1; x > newPosX; x--)
                {
                    if (x >= 0 && x < Board.columns && y >= 0 && y < Board.rows)
                    {
                        if (board.GetTile(x, y).isOccupied)
                        {
                            return false;
                        }
                    }
                    y--;
                }
            }
            #endregion

            #region Movement
            // Checks if the new spot is diagonal to the old spot
            if (Math.Abs(oldPosX - newPosX) == Math.Abs(oldPosY - newPosY))
            {
                return true;
            } 
            #endregion

            return false;
        }
    }
}
