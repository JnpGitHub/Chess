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
        public Bishop(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            symbol = 'B';
        }

        /// <summary>
        /// Returns true if a Bishop can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {

            // Returns false if the new tile has a piece with the same color as the moving piece
            if(board.GetTile(newx, newy).isOccupied)
            {
                if(board.GetTile(newx, newy).piece.color == board.GetTile(oldx, oldy).piece.color)
                {
                    return false;
                }
            }

            // When moving down right, returns false if any space between the old spot and new spot are occupied
            if(newx > oldx && newy > oldy)
            {
                int y = oldy + 1;
                for(int x = oldx + 1; x < newx; x++)
                {
                    if (x >= 0 && x < Board.columns && y >= 0 && y < Board.rows)
                    {
                        if(board.GetTile(x, y).isOccupied)
                        {
                            return false;
                        }
                    }
                    y++;
                }
            }

            // When moving down left, returns false if any space between the old spot and new spot are occupied
            if(newx < oldx && newy > oldy)
            {
                x = oldx - 1;
                for(int y = oldy + 1; y < newy; y++)
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
            if(newx > oldx && newy < oldy)
            {
                y = oldy - 1;
                for(int x = oldx + 1; x < newx; x++)
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
            if(newx < oldx && newy < oldy)
            {
                y = oldy - 1;
                for(int x = oldx - 1; x > newx; x--)
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

            // Checks if the new spot is diagonal to the old spot
            if(Math.Abs(oldx - newx) == Math.Abs(oldy - newy))
            {
                return true;
            }
            return false;
        }
    }
}
