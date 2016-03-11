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
        public static String type = "P";   //The type of the piece designated by a letter
        private bool firstMove;

        /// <summary>
        /// Creates a Pawn piece and sets its firstMove value to true
        /// </summary>
        public Pawn(String color, Board board, int x, int y) : base(color, board, x, y)
        {
            this.firstMove = true;
        }

        /// <summary>
        /// type getter
        /// </summary>
        public string GetSymbol()
        {
            return type;
        }

        
    }
}
