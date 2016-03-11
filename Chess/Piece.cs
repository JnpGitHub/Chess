using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Piece
    {
        private String color;                   //The pieces color
        private int x;                          //The X coordinate of the piece on the board
        private int y;                          //The Y coordinate of the piece on the board
        private List<int[]> validMoves;         //A list of valid spaces this piece can move

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
    }
}
