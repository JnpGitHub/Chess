using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        private static int columns = 8;                                 //The number of columns on the board
        private static int rows = 8;                                    //The number of rows on the board
        private List<List<Object>> grid = new List<List<Object>>();     //A multidimensional list that holds the Piece objects and blank spaces

        /// <summary>
        /// Creates a board with empty spaces designated by "--"
        /// </summary>
        public Board()
        {
            for(int y = 0; y < Board.rows; y++)
            {
                this.grid.Add(new List<Object>());                      //Add a list for every row
                for(int x = 0; x < Board.columns; x++)
                {
                    this.grid[y].Add("--");                             //Insert a blank space for every column in each row
                }
            }
        }

        /// <summary>
        /// Takes a piece and its coordinates and places it at that spot on the board
        /// </summary>
        public void SetPiece(Piece piece, int x, int y)
        {
            grid[x][y] = piece;
        }

        public object GetPiece(int x, int y)
        {
            return this.grid[x][y];
        }
        /// <summary>
        /// Draws the board to the console for now
        /// </summary>
        public void Draw()
        {
            for (int y = 0; y < Board.rows; y++)                        //For every row
            {
                for (int x = 0; x < Board.columns; x++)                 //For every space in each row
                {
                    if(this.GetPiece(x, y) == "--")                         //If the space is empty, print --
                    {
                        Console.Write("--");
                    }
                    else                                                //If the space has a piece, print the piece's type
                    {
                        Console.Write((this.GetPiece(x, y)).GetSymbol()); //How can I get the symbol of the piece
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
