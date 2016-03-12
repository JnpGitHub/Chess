using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Pawn : Piece          //Inherits from the Piece class
    {
        private static int value = 1;       //The amount of points this piece is worth
        private bool firstMove;             //Whether or not the piece has moved

        /// <summary>
        /// Creates a Pawn piece and sets its firstMove value to true
        /// </summary>
        public Pawn(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            this.firstMove = true;
            this.symbol = 'P';
        }
    }
}
