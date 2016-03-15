using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialize players, board and pieces
            Player whitePlayer = new Player("white", true);
            Player blackPlayer = new Player("black", false);
            Board board1 = new Board();

            //White Pawns
            Pawn whitePawn1 = new Pawn("white", board1, 0, 6);
            Pawn whitePawn2 = new Pawn("white", board1, 1, 6);
            Pawn whitePawn3 = new Pawn("white", board1, 2, 6);
            Pawn whitePawn4 = new Pawn("white", board1, 3, 6);
            Pawn whitePawn5 = new Pawn("white", board1, 4, 6);
            Pawn whitePawn6 = new Pawn("white", board1, 5, 6);
            Pawn whitePawn7 = new Pawn("white", board1, 6, 6);
            Pawn whitePawn8 = new Pawn("white", board1, 7, 6);

            //Black Pawns
            Pawn blackPawn1 = new Pawn("black", board1, 0, 1);
            Pawn blackPawn2 = new Pawn("black", board1, 1, 1);
            Pawn blackPawn3 = new Pawn("black", board1, 2, 1);
            Pawn blackPawn4 = new Pawn("black", board1, 3, 1);
            Pawn blackPawn5 = new Pawn("black", board1, 4, 1);
            Pawn blackPawn6 = new Pawn("black", board1, 5, 1);
            Pawn blackPawn7 = new Pawn("black", board1, 6, 1);
            Pawn blackPawn8 = new Pawn("black", board1, 7, 1);

            //Kings
            King whiteKing = new King("white", board1, 4, 7);
            King blackKing = new King("black", board1, 4, 0);

            //Queens
            Queen whiteQueen = new Queen("white", board1, 3, 7);
            Queen blackQueen = new Queen("black", board1, 3, 0);

            //Bishops
            Bishop whiteBishop1 = new Bishop("white", board1, 2, 7);
            Bishop whiteBishop2 = new Bishop("white", board1, 5, 7);

            Bishop blackBishop1 = new Bishop("black", board1, 2, 0);
            Bishop blackBishop2 = new Bishop("black", board1, 5, 0);

            //Knights
            Knight whiteKnight1 = new Knight("white", board1, 1, 7);
            Knight whiteKnight2 = new Knight("white", board1, 6, 7);

            Knight blackKnight1 = new Knight("black", board1, 1, 0);
            Knight blackKnight2 = new Knight("black", board1, 6, 0);

            //Rooks
            Rook whiteRook1 = new Rook("white", board1, 0, 7);
            Rook whiteRook2 = new Rook("white", board1, 7, 7);

            Rook blackRook1 = new Rook("black", board1, 0, 0);
            Rook blackRook2 = new Rook("black", board1, 7, 0);
            #endregion
            
            bool running = true;
            while (running)
            {
                board1.Draw();

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


                if (board1.GetTile(oldx, oldy).isOccupied && board1.GetTile(oldx, oldy).piece.Move(board1, oldx, oldy, newx, newy))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Move");
                    Console.WriteLine();
                }
            }
        }
    }
}
