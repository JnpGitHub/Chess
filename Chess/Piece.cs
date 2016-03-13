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
        public Char symbol;                     //The pieces type as a character
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

        /// <summary>
        /// Returns the piece's symbol
        /// </summary>
        public Char GetSymbol()
        {
            return symbol;
        }

        /// <summary>
        /// Returns the piece's color
        /// </summary>
        public String GetColor()
        {
            return color;
        }

        /// <summary>
        /// Returns an array with the piece's x and y coordinates
        /// </summary>
        /// <returns></returns>
        public int[] GetPosition()
        {
            int[] position = { x, y };
            return position;
        }

        /// <summary>
        /// Set the piece's X and Y
        /// </summary>
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
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
