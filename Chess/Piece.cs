using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Piece
    {
        public String color { get; }
        public Char symbol { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        private List<int[]> validMoves;
        
        /// <summary>
        /// Creates a piece with a color and places it on the board passed at the x and y coordinates
        /// </summary>
        public Piece(String color, Board board, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            validMoves = new List<int[]>();
            board.SetPiece(this, this.x, this.y);
        }
        
        /// <summary>
        /// Returns true if the piece can move from the old position to the new position
        /// </summary>
        abstract public bool IsValidMove(int oldx, int oldy, int newx, int newy);

        /// <summary>
        /// Moves the piece from one tile to another if it is a valid move. Returns true if the piece was moved
        /// </summary>
        public bool Move(Board board, int oldx, int oldy, int newx, int newy)
        {
            if(IsValidMove(oldx, oldy, newx, newy))
            {
                board.SetPiece(this, newx, newy);
                board.RemovePiece(oldx, oldy);
            }
            return false;
        }
    }
}
