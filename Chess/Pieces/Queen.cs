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
        public Queen(Player player, String color, Board board, int x, int y) : base(player, color, board, x, y)
        {
            symbol = 'Q';
        }

        /// <summary>
        /// Returns true if a Queen can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldPosX, int oldPosY, int newPosX, int newPosY)
        {
            #region Path Checking
            // Returns false if the new tile has a piece with the same color as the Queen
            if (board.GetTile(newPosX, newPosY).isOccupied)
            {
                if (board.GetTile(newPosX, newPosY).piece.color == board.GetTile(oldPosX, oldPosY).piece.color)
                {
                    return false;
                }
            }

            // When moving right, returns false if any space between the old location and new location are occupied
            if (newPosX > oldPosX && newPosY == oldPosY)
            {
                for (int i = oldPosX + 1; i < newPosX; i++)
                {
                    if (board.GetTile(i, oldPosY).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving left, returns false if any space between the old location and the new location are occupied
            if (newPosX < oldPosX && newPosY == oldPosY)
            {
                for (int i = oldPosX - 1; i > newPosX; i--)
                {
                    if (board.GetTile(i, oldPosY).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving down, returns false if any space between the old location and the new location are occupied
            if (newPosY > oldPosY && newPosX == oldPosX)
            {
                for (int i = oldPosY + 1; i < newPosY; i++)
                {
                    if (board.GetTile(oldPosX, i).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving up, returns false if any space between the old location and the new location are occupied
            if (newPosY < oldPosY && newPosX == oldPosX)
            {
                for (int i = oldPosY - 1; i > newPosY; i--)
                {
                    if (board.GetTile(oldPosX, i).isOccupied)
                    {
                        return false;
                    }
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
            // Return true if the Queen is trying to move vertically or horizontally
            if (Math.Abs(oldPosX - newPosX) == Math.Abs(oldPosY - newPosY) || oldPosX == newPosX || oldPosY == newPosY)
            {
                return true;
            }
            #endregion

            return false;
            
        }
    }
}
