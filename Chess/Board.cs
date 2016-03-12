using Chess.Pieces;
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
        private List<List<Tile>> grid = new List<List<Tile>>();         //A multidimensional list that holds 8 by 8 tile objects

        /// <summary>
        /// Creates a board of empty tile objects
        /// </summary>
        public Board()
        {
            for(int y = 0; y < Board.rows; y++)
            {
                this.grid.Add(new List<Tile>());                        //Add a list of tiles for every row
                for(int x = 0; x < Board.columns; x++)
                {
                    this.grid[y].Add(new Tile(x, y, false, null));      //Insert an empty tile in every column
                }
            }
        }

        /// <summary>
        /// Takes a piece and its coordinates and places it at that spot on the board
        /// </summary>
        public void SetPiece(Piece piece, int x, int y)
        {
            grid[x][y].SetPiece(piece);
        }

        /// <summary>
        /// Return the object at passed coordinate
        /// </summary>
        public object Get(int x, int y)
        {
            return this.grid[x][y].GetPiece();
        }

        /// <summary>
        /// Draws the board to the console for now
        /// </summary>
        public void Draw()
        {
            for(int y = 0; y < rows; y++)                                   //For every row...
            {
                for(int x = 0; x < columns; x++)                            //For every tile in the row...
                {
                    if (!grid[x][y].IsOccupied())
                    {
                        Console.Write("0");                                 //Write -- if the tile is not occupied
                    }
                    else
                    {
                        Console.Write(grid[x][y].GetPiece().GetSymbol());   //Write the symbol of the piece in the tile if it is occupied
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
