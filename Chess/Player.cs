using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Player
    {
        public String color { get; }
        public bool turn { get; set; }
        private List<Piece> _pieces = new List<Piece>();
        public List<Piece> pieces { get { return _pieces; } }

        private List<Piece> _capturedPieces = new List<Piece>();
        public List<Piece> capturedPieces { get { return _capturedPieces; } }

        /// <summary>
        /// Creates a player with a color and turn
        /// </summary>
        public Player(String color, bool turn)
        {
            this.color = color;
            this.turn = turn;
        }

        public void AddPiece(Piece piece)
        {
            pieces.Add(piece);
        }

        public void AddCapturedPiece(Piece piece)
        {
            capturedPieces.Add(piece);
        }
    }
}
