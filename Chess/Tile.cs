using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Tile
    {
        private int x;                  //The X coordinate of this tile on the board
        private int y;                  //The Y coordinate of this tile on the board
        private bool isOccupied;        //Whether or not this tile has a piece on it
        private Piece piece;            //The piece that this tile has on it

        public Tile(int x, int y, bool isOccupied, Piece piece)
        {
            this.x = x;
            this.y = y;
            this.isOccupied = isOccupied;
            this.piece = piece;
        }
        
        /// <summary>
        /// Returns true if the tile is occupied
        /// </summary>
        public bool IsOccupied()
        {
            return isOccupied;
        }

        /// <summary>
        /// Sets piece equal to the piece object passed and changed the tile to occupied
        /// </summary>
        public void SetPiece(Piece piece)
        {
            this.isOccupied = true;
            this.piece = piece;
        }

        /// <summary>
        /// Return the piece on this tile
        /// </summary>
        public Piece GetPiece()
        {
            return piece;
        }
    }
}
