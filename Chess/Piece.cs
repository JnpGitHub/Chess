using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Piece
    {
        public string color { get; }
        public char symbol { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        private List<int[]> _validMoves = new List<int[]>();
        public List<int[]> validMoves { get { return _validMoves; } }

        /// <summary>
        /// Creates a piece with a color and places it on the board passed at the x and y coordinates
        /// </summary>
        public Piece(Player player, string color, Board board, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            board.SetPiece(this, this.x, this.y);
            player.AddPiece(this);
            GenerateValidMoves(board);
        }
        
        /// <summary>
        /// Returns true if the piece can move from the old position to the new position
        /// </summary>
        abstract public bool IsValidMove(Board board, int oldx, int oldy, int newx, int newy);

        /// <summary>
        /// Moves the piece from one tile to another if it is a valid move. Returns true if the piece was moved
        /// </summary>
        public bool Move(Board board, int oldx, int oldy, int newx, int newy)
        {
            if(board.GetTile(oldx, oldy).isOccupied)
            {
                if(IsValidMove(board, oldx, oldy, newx, newy))
                {
                    board.SetPiece(this, newx, newy);
                    board.RemovePiece(oldx, oldy);
                    return true;
                }
            }
            return false;
        }

        public void GenerateValidMoves(Board board)
        {
            validMoves.Clear();
            for(int y = 0; y < Board.rows; y++)
            {
                for(int x = 0; x < Board.columns; x++)
                {
                    if(IsValidMove(board, this.x, this.y, x, y))
                    {
                        validMoves.Add(new[] { x, y });
                    }
                }
            }
        }
    }
}
