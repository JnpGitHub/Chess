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
        public Rook(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            symbol = 'R';
        }

        /// <summary>
        /// Returns true if a Rook can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {
            // Returns false if the new tile has a piece with the same color as the Rook
            if (board.GetTile(newx, newy).isOccupied)
            {
                if (board.GetTile(newx, newy).piece.color == board.GetTile(oldx, oldy).piece.color)
                {
                    return false;
                }
            }

            // When moving right, returns false if any space between the old location and new location are occupied
            if(newx > oldx)
            {
                for(int i = oldx + 1; i < newx; i++)
                {
                    if(board.GetTile(i, oldy).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving left, returns false if any space between the old location and the new location are occupied
            if(newx < oldx)
            {
                for(int i = oldx -1; i > newx; i--)
                {
                    if(board.GetTile(i, oldy).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving down, returns false if any space between the old location and the new location are occupied
            if(newy > oldy)
            {
                for(int i = oldy + 1; i < newy; i++)
                {
                    if(board.GetTile(oldx, i).isOccupied)
                    {
                        return false;
                    }
                }
            }

            // When moving up, returns false if any space between the old location and the new location are occupied
            if(newy < oldy)
            {
                for(int i = oldy - 1; i > newy; i--)
                {
                    if(board.GetTile(oldx, i).isOccupied)
                    {
                        return false;
                    }
                }
            }
            
            // Returns true if the new space is horizontal or vertical from the old space
            if(oldx == newx || oldy == newy)
            {
                return true;
            }

            return false;
        }
    }
}
