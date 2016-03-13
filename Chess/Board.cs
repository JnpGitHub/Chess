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
            for(int y = 0; y < rows; y++)
            {
                grid.Add(new List<Tile>());                             //Add a list of tiles for every row
                for(int x = 0; x < columns; x++)
                {
                    grid[y].Add(new Tile(x, y, false, null));           //Insert an empty tile in every column
                }
            }
        }

        /// <summary>
        /// Puts the piece on the tile at the coordinates passed
        /// </summary>
        public void SetPiece(Piece piece, int x, int y)
        {
            grid[x][y].piece = piece;
            grid[x][y].isOccupied = true;
            piece.x = x;
            piece.y = y;
        }

        /// <summary>
        /// Removes the piece on the tile at the coordinates passed
        /// </summary>
        public void RemovePiece(int x, int y)
        {
            grid[x][y].isOccupied = false;
            grid[x][y].piece = null;
        }

        public Tile GetTile(int x, int y)
        {
            return grid[x][y];
        }

        /// <summary>
        /// Draws the board to the console
        /// </summary>
        public void Draw()
        {
            for(int y = 0; y < rows; y++)                                           //For every row...
            {
                for(int x = 0; x < columns; x++)                                    //For every tile in the row...
                {
                    if (!grid[x][y].isOccupied)
                    {
                        Console.Write("-- ");                                       //Write -- if the tile is not occupied
                    }
                    else
                    {
                        if(grid[x][y].piece.color == "white")                       //Write the color and symbol of the piece in occupied tiles
                        {
                            Console.Write("W" + grid[x][y].piece.symbol + " ");
                        }
                        else
                        {
                            Console.Write("B" + grid[x][y].piece.symbol + " ");
                        }
                        
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
