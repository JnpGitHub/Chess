using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        private static int value = 1;
        private bool firstMove;

        /// <summary>
        /// Creates a Pawn piece and sets its firstMove value to true
        /// </summary>
        public Pawn(Player player, String color, Board board, int x, int y) : base(player, color, board, x, y)
        {
            firstMove = true;
            symbol = 'P';
        }

        /// <summary>
        /// Returns true if a Pawn can move from the old position to the new position
        /// </summary>
        public override bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy)
        {
            #region Capturing
            //A pawn can move diagonally one tile forward if that new tile has an enemy piece
            if(color == "white")
            {
                if(oldy - newy == 1 && Math.Abs(oldx - newx) == 1 && board.GetTile(newx, newy).isOccupied && board.GetTile(newx, newy).piece.color == "black"){
                    return true;
                }
            }
            else
            {
                if(newy - oldy == 1 && Math.Abs(newx - oldx) == 1 && board.GetTile(newx, newy).isOccupied && board.GetTile(newx, newy).piece.color == "white")
                {
                    return true;
                }
            }
            #endregion

            #region Movement
            if (firstMove)
            {
                if(color == "white")
                {
                    //If the white pawn has a different x, moved more than 2 spaces, or has a piece in front of it return false
                    if(oldx != newx || oldy - newy != 1 && oldy - newy != 2 || board.GetTile(oldx, oldy - 1).isOccupied)
                    {
                        return false;
                    }
                }
                else
                {
                    //If the black pawn has a different x, moved more than 2 spaces, or has a piece in front of it return false
                    if (oldx != newx || newy - oldy != 1 && newy - oldy != 2 || board.GetTile(oldx, oldy + 1).isOccupied)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (color == "white")
                {
                    //If the white pawn has a different x, moved more than 1 space, or has a piece in front of it return false
                    if (oldx != newx || oldy - newy != 1 || board.GetTile(oldx, oldy - 1).isOccupied)
                    {
                        return false;
                    }
                }
                else
                {
                    //If the black pawn has a different x, moved more than 1 space, or has a piece in front of it return false
                    if (oldx != newx || newy - oldy != 1 || board.GetTile(oldx, oldy + 1).isOccupied)
                    {
                        return false;
                    }
                }
            }
            #endregion

            firstMove = false;
            return true;
        }
    }
}
