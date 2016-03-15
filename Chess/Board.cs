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
        private static int _columns = 8;
        public static int columns { get { return _columns; } }

        private static int _rows = 8;
        public static int rows { get { return _rows; } }

        private List<List<Tile>> grid = new List<List<Tile>>();

        /// <summary>
        /// Creates a board of empty tile objects
        /// </summary>
        public Board()
        {
            for(int y = 0; y < rows; y++)
            {
                grid.Add(new List<Tile>());
                for(int x = 0; x < columns; x++)
                {
                    grid[y].Add(new Tile(x, y, false, null));
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

        /// <summary>
        /// Returns the tile at the coordinates passed
        /// </summary>
        public Tile GetTile(int x, int y)
        {
            return grid[x][y];
        }

        /// <summary>
        /// Draws the board to the console
        /// </summary>
        public void Draw()
        {
            for(int y = 0; y < rows; y++)
            {
                for(int x = 0; x < columns; x++)
                {
                    if (!grid[x][y].isOccupied)
                    {
                        Console.Write("-- ");
                    }
                    else
                    {
                        if(grid[x][y].piece.color == "white")
                        {
                            Console.Write("W" + grid[x][y].piece.symbol + " ");
                        }
                        else
                        {
                            Console.Write("B" + grid[x][y].piece.symbol + " ");
                        }
                        
                    }
                }
                Console.WriteLine(" {0}", y + 1);
            }
            Console.WriteLine(" 1  2  3  4  5  6  7  8");
            Console.WriteLine();
        }

    }
}
