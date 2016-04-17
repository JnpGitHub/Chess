using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    class Program
    {
        #region initialize players, board and pieces
        static Player whitePlayer = new Player("white", true);
        static Player blackPlayer = new Player("black", false);
        static Board board1 = new Board();

        //White Pawns
        static Pawn whitePawn1 = new Pawn(whitePlayer, "white", board1, 0, 6);
        static Pawn whitePawn2 = new Pawn(whitePlayer, "white", board1, 1, 6);
        static Pawn whitePawn3 = new Pawn(whitePlayer, "white", board1, 2, 6);
        static Pawn whitePawn4 = new Pawn(whitePlayer, "white", board1, 3, 6);
        static Pawn whitePawn5 = new Pawn(whitePlayer, "white", board1, 4, 6);
        static Pawn whitePawn6 = new Pawn(whitePlayer, "white", board1, 5, 6);
        static Pawn whitePawn7 = new Pawn(whitePlayer, "white", board1, 6, 6);
        static Pawn whitePawn8 = new Pawn(whitePlayer, "white", board1, 7, 6);

        //Black Pawns
        static Pawn blackPawn1 = new Pawn(blackPlayer, "black", board1, 0, 1);
        static Pawn blackPawn2 = new Pawn(blackPlayer, "black", board1, 1, 1);
        static Pawn blackPawn3 = new Pawn(blackPlayer, "black", board1, 2, 1);
        static Pawn blackPawn4 = new Pawn(blackPlayer, "black", board1, 3, 1);
        static Pawn blackPawn5 = new Pawn(blackPlayer, "black", board1, 4, 1);
        static Pawn blackPawn6 = new Pawn(blackPlayer, "black", board1, 5, 1);
        static Pawn blackPawn7 = new Pawn(blackPlayer, "black", board1, 6, 1);
        static Pawn blackPawn8 = new Pawn(blackPlayer, "black", board1, 7, 1);

        //Kings
        static King whiteKing = new King(whitePlayer, "white", board1, 4, 7);
        static King blackKing = new King(blackPlayer, "black", board1, 4, 0);

        //Queens
        static Queen whiteQueen = new Queen(whitePlayer, "white", board1, 3, 7);
        static Queen blackQueen = new Queen(blackPlayer, "black", board1, 3, 0);

        //Bishops
        static Bishop whiteBishop1 = new Bishop(whitePlayer, "white", board1, 2, 7);
        static Bishop whiteBishop2 = new Bishop(whitePlayer, "white", board1, 5, 7);

        static Bishop blackBishop1 = new Bishop(blackPlayer, "black", board1, 2, 0);
        static Bishop blackBishop2 = new Bishop(blackPlayer, "black", board1, 5, 0);

        //Knights
        static Knight whiteKnight1 = new Knight(whitePlayer, "white", board1, 1, 7);
        static Knight whiteKnight2 = new Knight(whitePlayer, "white", board1, 6, 7);

        static Knight blackKnight1 = new Knight(blackPlayer, "black", board1, 1, 0);
        static Knight blackKnight2 = new Knight(blackPlayer, "black", board1, 6, 0);

        //Rooks
        static Rook whiteRook1 = new Rook(whitePlayer, "white", board1, 0, 7);
        static Rook whiteRook2 = new Rook(whitePlayer, "white", board1, 7, 7);

        static Rook blackRook1 = new Rook(blackPlayer, "black", board1, 0, 0);
        static Rook blackRook2 = new Rook(blackPlayer, "black", board1, 7, 0);
        #endregion

        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Game());

            

            bool running = true;
            while (running)
            {
                CheckForCheck();
                board1.DrawToConsole();
                
                Console.Write("X: ");
                int oldx = Convert.ToInt32(Console.ReadLine()) - 1;
                
                Console.Write("Y: ");
                int oldy = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine();

                Console.Write("New X: ");
                int newx = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.Write("New Y: ");
                int newy = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine();

                Console.WriteLine("**************************************************************************");
                Console.WriteLine();

                if (board1.GetTile(oldx, oldy).isOccupied && board1.GetTile(oldx, oldy).piece.Move(board1, oldx, oldy, newx, newy))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Move");
                    Console.WriteLine();
                }

                Console.WriteLine(whiteQueen.x + " : " + whiteQueen.y);

                GenerateAllValidMoves();
            }
        }

        /// <summary>
        /// Generates every pieces valid moves
        /// </summary>
        public static void GenerateAllValidMoves()
        {
            foreach(var piece in whitePlayer.pieces)
            {
                piece.GenerateValidMoves(board1);
            }

            foreach(var piece in blackPlayer.pieces)
            {
                piece.GenerateValidMoves(board1);
            }
        }

        /// <summary>
        /// Checks if either king is in any of the other player's piece's valid move list and puts the king in check if it is.
        /// </summary>
        public static void CheckForCheck()
        {
            foreach(var piece in whitePlayer.pieces)
            {
                if (piece.validMoves.Contains(new[] { blackKing.x, blackKing.y }))
                {
                    blackKing.isInCheck = true;
                    Console.WriteLine("Black King is in check!");
                }
                else
                {
                    blackKing.isInCheck = false;
                }
            }

            foreach(var piece in blackPlayer.pieces)
            {
                if (piece.validMoves.Contains(new[] { whiteKing.x, whiteKing.y }))
                {
                    whiteKing.isInCheck = true;
                    Console.WriteLine("White King is in check!");
                }
                else
                {
                    whiteKing.isInCheck = false;
                }
            }
        }
    }
}
