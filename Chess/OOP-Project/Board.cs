using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class Board
    {
        public Pieces[,] ChessBoard = new Pieces[8, 8];
        public Board()
        {
            //White
            ChessBoard[0, 0] = new Rook(0, 0, 'W');
            ChessBoard[0, 1] = new Knight(0, 1, 'W');
            ChessBoard[0, 2] = new Bishop(0, 2, 'W');
            ChessBoard[0, 3] = new King(0, 3, 'W');
            ChessBoard[0, 4] = new Queen(0, 4, 'W');
            ChessBoard[0, 5] = new Bishop(0, 5, 'W');
            ChessBoard[0, 6] = new Knight(0, 6, 'W');
            ChessBoard[0, 7] = new Rook(0, 7, 'W');
            //Black
            ChessBoard[7, 0] = new Rook(7, 0, 'B');
            ChessBoard[7, 1] = new Knight(7, 1, 'B');
            ChessBoard[7, 2] = new Bishop(7, 2, 'B');
            ChessBoard[7, 3] = new King(7, 3, 'B');
            ChessBoard[7, 4] = new Queen(7, 4, 'B');
            ChessBoard[7, 5] = new Bishop(7, 5, 'B');
            ChessBoard[7, 6] = new Knight(7, 6, 'B');
            ChessBoard[7, 7] = new Rook(7, 7, 'B');

            for (int i = 0; i < 8; i++)
            {
                ChessBoard[1, i] = new Pawn(1, i, 'W');
                ChessBoard[6, i] = new Pawn(6, i, 'B');
            }

            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                    ChessBoard[i, j] = new Pieces(i, j, 'n');
            }

        }
    }
}