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
        /// Draws the board to the console for now
        /// </summary>
        public void draw()
        {
            for (int y = 0; y < Board.rows; y++)                        //For every row
            {
                for (int x = 0; x < Board.columns; x++)                 //For every space in each row
                {
                    if(this.grid[x][y] == "--")                         //If the space is empty, print --
                    {
                        Console.Write("--");
                    }
                    //Else print the piece's type
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
