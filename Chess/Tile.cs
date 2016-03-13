using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Tile
    {
        private int x;
        private int y;
        public bool isOccupied { get; set; }
        public Piece piece { get; set; }

        public Tile(int x, int y, bool isOccupied, Piece piece)
        {
            this.x = x;
            this.y = y;
            this.isOccupied = isOccupied;
            this.piece = piece;
        }
    }
}
