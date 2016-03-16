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
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {
            #region Path Checking
            // Returns false if the new tile has a piece with the same color as the Queen
            if (board.GetTile(newx, newy).isOccupied)
            {
                if (board.GetTile(newx, newy).piece.color == board.GetTile(oldx, oldy).piece.color)
                {
                    return false;
                }
            }

            // When moving right, returns false if any space between the old location and new location are occupied
            if (newx > oldx && newy == oldy)
            {
                for (int i = oldx + 1; i < newx; i++)
                {
                    if (board.GetTile(i, oldy).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving left, returns false if any space between the old location and the new location are occupied
            if (newx < oldx && newy == oldy)
            {
                for (int i = oldx - 1; i > newx; i--)
                {
                    if (board.GetTile(i, oldy).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving down, returns false if any space between the old location and the new location are occupied
            if (newy > oldy && newx == oldx)
            {
                for (int i = oldy + 1; i < newy; i++)
                {
                    if (board.GetTile(oldx, i).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving up, returns false if any space between the old location and the new location are occupied
            if (newy < oldy && newx == oldx)
            {
                for (int i = oldy - 1; i > newy; i--)
                {
                    if (board.GetTile(oldx, i).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving down right, returns false if any space between the old spot and new spot are occupied
            if (newx > oldx && newy > oldy)
            {
                int y = oldy + 1;
                for (int x = oldx + 1; x < newx; x++)
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
            if (newx < oldx && newy > oldy)
            {
                x = oldx - 1;
                for (int y = oldy + 1; y < newy; y++)
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
            if (newx > oldx && newy < oldy)
            {
                y = oldy - 1;
                for (int x = oldx + 1; x < newx; x++)
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
            if (newx < oldx && newy < oldy)
            {
                y = oldy - 1;
                for (int x = oldx - 1; x > newx; x--)
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
            if (Math.Abs(oldx - newx) == Math.Abs(oldy - newy) || oldx == newx || oldy == newy)
            {
                Console.WriteLine("Valid Move");
                return true;
            }
            #endregion

            return false;
            
        }
    }
}
