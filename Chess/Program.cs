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
            //Board test
            Board board1 = new Board();
            Pawn whitePawn1 = new Pawn("white", board1, 0, 6);
            board1.Draw();
            Console.WriteLine(whitePawn1.GetSymbol());
        }
    }
}
