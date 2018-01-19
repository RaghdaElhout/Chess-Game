using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_Project
{
    [Serializable]
    public class Pieces
    {
        public int X_Postion;
        public int Y_Postion;
        public char Piece_Color;
        public Pieces(int X_Postion, int Y_Postion, char Piece_Color)
        {
            this.X_Postion = X_Postion;
            this.Y_Postion = Y_Postion;
            this.Piece_Color = Piece_Color;
        }
        public virtual void Available_Moves(Board b2, int i, int j)
        {

        }
    }
    [Serializable]
    class Rook : Pieces
    {
        public Rook(int X_Postion, int Y_Postion, char Piece_Color) : base(X_Postion, Y_Postion, Piece_Color)
        {

        }
        public override void Available_Moves(Board b2, int i, int j)
        {
            int i1, i2;
            int j1, j2;
            i1 = i2 = i;
            j1 = j2 = j;
            while (i1 <= 6)
            {
                // t7t
                i1++;
                if (b2.ChessBoard[i1, j].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i1, j].Piece_Color != this.Piece_Color && b2.ChessBoard[i1, j].Piece_Color != 'n')
                {
                    Chess_Game.b[i1, j].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i1, j].BackColor = Color.Yellow;
            }
            while (i2 > 0)
            {
                // fou2
                i2--;
                if (b2.ChessBoard[i2, j].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i2, j].Piece_Color != this.Piece_Color && b2.ChessBoard[i2, j].Piece_Color != 'n')
                {
                    Chess_Game.b[i2, j].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i2, j].BackColor = Color.Yellow;
            }

            while (j1 < 7)
            {
                // ymeen 
                j1++;
                if (b2.ChessBoard[i, j1].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i, j1].Piece_Color != this.Piece_Color && b2.ChessBoard[i, j1].Piece_Color != 'n')
                {
                    Chess_Game.b[i, j1].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i, j1].BackColor = Color.Yellow;
            }

            while (j2 > 0)
            {
                // shaml
                j2--;
                if (b2.ChessBoard[i, j2].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i, j2].Piece_Color != this.Piece_Color && b2.ChessBoard[i, j2].Piece_Color != 'n')
                {
                    Chess_Game.b[i, j2].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i, j2].BackColor = Color.Yellow;
            }

        }
    }
    [Serializable]
    class Knight : Pieces
    {
        public Knight(int X_Postion, int Y_Postion, char Piece_Color) : base(X_Postion, Y_Postion, Piece_Color)
        {
        }
        public override void Available_Moves(Board b2, int i, int j)
        {

            if (i <= 5)
            {
                if (j < 7 && b2.ChessBoard[i + 2, j + 1].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i + 2, j + 1].BackColor = Color.Yellow;
                }
                if (j > 0 && b2.ChessBoard[i + 2, j - 1].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i + 2, j - 1].BackColor = Color.Yellow;
                }
            }
            if (i >= 2)
            {
                if (j < 7 && b2.ChessBoard[i - 2, j + 1].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i - 2, j + 1].BackColor = Color.Yellow;
                }
                if (j > 0 && b2.ChessBoard[i - 2, j - 1].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i - 2, j - 1].BackColor = Color.Yellow;
                }
            }
            //
            if (i < 7)
            {
                if (j < 6 && b2.ChessBoard[i + 1, j + 2].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i + 1, j + 2].BackColor = Color.Yellow;
                }
                if (j > 1 && b2.ChessBoard[i + 1, j - 2].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i + 1, j - 2].BackColor = Color.Yellow;
                }
            }
            if (i >= 1)
            {
                if (j < 6 && b2.ChessBoard[i - 1, j + 2].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i - 1, j + 2].BackColor = Color.Yellow;
                }
                if (j > 1 && b2.ChessBoard[i - 1, j - 2].Piece_Color != this.Piece_Color)
                {
                    Chess_Game.b[i - 1, j - 2].BackColor = Color.Yellow;
                }
            }
        }
    }
    [Serializable]
    class Bishop : Pieces
    {
        public Bishop(int X_Postion, int Y_Postion, char Piece_Color) : base(X_Postion, Y_Postion, Piece_Color)
        {

        }
        public override void Available_Moves(Board b2, int i, int j)
        {
            int i1, i2;
            int j1, j2;
            i1 = i2 = i;
            j1 = j2 = j;

            while (i1 < 7 && j1 < 7)
            {
                // diagonal odam ymeen  :D
                i1++;
                j1++;
                if (b2.ChessBoard[i1, j1].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i1, j1].Piece_Color != this.Piece_Color && b2.ChessBoard[i1, j1].Piece_Color != 'n')
                {
                    Chess_Game.b[i1, j1].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i1, j1].BackColor = Color.Yellow;
            }
            while (i2 < 7 && j2 > 0)
            {
                //diagonal odam shemal :D
                i2++;
                j2--;
                if (b2.ChessBoard[i2, j2].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i2, j2].Piece_Color != this.Piece_Color && b2.ChessBoard[i2, j2].Piece_Color != 'n')
                {
                    Chess_Game.b[i2, j2].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i2, j2].BackColor = Color.Yellow;
            }
            i1 = i2 = i;
            j1 = j2 = j;
            while (i1 > 0 && j1 < 7)
            {
                // diagonal wara ymeen 
                i1--;
                j1++;
                if (b2.ChessBoard[i1, j1].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i1, j1].Piece_Color != this.Piece_Color && b2.ChessBoard[i1, j1].Piece_Color != 'n')
                {
                    Chess_Game.b[i1, j1].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i1, j1].BackColor = Color.Yellow;
            }

            while (i2 > 0 && j2 > 0)
            {
                // diagonal wara shemal
                i2--;
                j2--;
                if (b2.ChessBoard[i2, j2].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i2, j2].Piece_Color != this.Piece_Color && b2.ChessBoard[i2, j2].Piece_Color != 'n')
                {
                    Chess_Game.b[i2, j2].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i2, j2].BackColor = Color.Yellow;
            }

        }
    }
    [Serializable]
    class Pawn : Pieces
    {
        public Pawn(int X_Postion, int Y_Postion, char Piece_Color)
            : base(X_Postion, Y_Postion, Piece_Color)
        {

        }
        public void attack(Board b2, int i, int j)
        {
            if (this.Piece_Color == 'W')

            {
                if (j < 7 && i < 7)
                {
                    if (b2.ChessBoard[i + 1, j + 1].Piece_Color != 'n' && b2.ChessBoard[i + 1, j + 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i + 1, j + 1].BackColor = Color.Yellow;
                }
                if (j > 0 && i < 7)
                {
                    if (b2.ChessBoard[i + 1, j - 1].Piece_Color != 'n' && b2.ChessBoard[i + 1, j - 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i + 1, j - 1].BackColor = Color.Yellow;
                }
            }

            if (this.Piece_Color == 'B')
            {
                if (j < 7 && i > 0)
                    if (b2.ChessBoard[i - 1, j + 1].Piece_Color != 'n' && b2.ChessBoard[i - 1, j + 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i - 1, j + 1].BackColor = Color.Yellow;
                if (j > 0 && i > 0)
                    if (b2.ChessBoard[i - 1, j - 1].Piece_Color != 'n' && b2.ChessBoard[i - 1, j - 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i - 1, j - 1].BackColor = Color.Yellow;
            }
        }
        public bool IsFirstMove(int x, char co)
        {
            if (co == 'W' && x == 1)
                return true;
            else if (co == 'B' && x == 6)
                return true;
            return false;
        }
        public override void Available_Moves(Board b2, int i, int j)
        {
            if (this.Piece_Color == 'W')
            {
                if (i < 7 && b2.ChessBoard[i + 1, j].Piece_Color == 'n')
                {
                    Chess_Game.b[i + 1, j].BackColor = Color.Yellow;
                }
                if (IsFirstMove(i, this.Piece_Color) == true && b2.ChessBoard[i + 1, j].Piece_Color == 'n' && b2.ChessBoard[i + 2, j].Piece_Color == 'n')
                {
                    Chess_Game.b[i + 2, j].BackColor = Color.Yellow;
                }
            }
            if (this.Piece_Color == 'B')
            {
                if (i > 0 && b2.ChessBoard[i - 1, j].Piece_Color == 'n')
                {
                    Chess_Game.b[i - 1, j].BackColor = Color.Yellow;
                }
                if (IsFirstMove(i, this.Piece_Color) == true && b2.ChessBoard[i - 1, j].Piece_Color == 'n' && b2.ChessBoard[i - 2, j].Piece_Color == 'n')
                {
                    Chess_Game.b[i - 2, j].BackColor = Color.Yellow;
                }
            }
            attack(b2, i, j);
        }
    }
    [Serializable]
    class King : Pieces
    {
        public King(int X_Postion, int Y_Postion, char Piece_Color)
            : base(X_Postion, Y_Postion, Piece_Color)
        {

        }
        public override void Available_Moves(Board b2, int i, int j)
        {
            // "i" => el ofoke , "j" => el r2se

            if (i < 7)
            {
                
                if (b2.ChessBoard[i + 1, j].Piece_Color != this.Piece_Color)
                    Chess_Game.b[i + 1, j].BackColor = Color.Yellow;
                
                if (j < 7)
                    if (b2.ChessBoard[i + 1, j + 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i + 1, j + 1].BackColor = Color.Yellow;
                
                if (j > 0)
                    if (b2.ChessBoard[i + 1, j - 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i + 1, j - 1].BackColor = Color.Yellow;
            }
            if (i > 0)
            {
                
                if (b2.ChessBoard[i - 1, j].Piece_Color != this.Piece_Color)
                    Chess_Game.b[i - 1, j].BackColor = Color.Yellow;
                
                if (j < 7)
                    if (b2.ChessBoard[i - 1, j + 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i - 1, j + 1].BackColor = Color.Yellow;
                
                if (j > 0)
                    if (b2.ChessBoard[i - 1, j - 1].Piece_Color != this.Piece_Color)
                        Chess_Game.b[i - 1, j - 1].BackColor = Color.Yellow;
            }
           
            if (j < 7)
                if (b2.ChessBoard[i, j + 1].Piece_Color != this.Piece_Color)
                    Chess_Game.b[i, j + 1].BackColor = Color.Yellow;
            
            if (j > 0)
                if (b2.ChessBoard[i, j - 1].Piece_Color != this.Piece_Color)
                    Chess_Game.b[i, j - 1].BackColor = Color.Yellow;


        }
    }
    [Serializable]
    class Queen : Pieces
    {
        public Queen(int X_Postion, int Y_Postion, char Piece_Color)
            : base(X_Postion, Y_Postion, Piece_Color)
        {

        }
        public override void Available_Moves(Board b2, int i, int j)
        {
            int i1, i2;
            int j1, j2;
            i1 = i2 = i;
            j1 = j2 = j;

            while (i1 <= 6)
            {
                // odam aw t7t :"D
                i1++;
                if (b2.ChessBoard[i1, j].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i1, j].Piece_Color != this.Piece_Color && b2.ChessBoard[i1, j].Piece_Color != 'n')
                {
                    Chess_Game.b[i1, j].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i1, j].BackColor = Color.Yellow;
            }


            while (i2 > 0)
            {
                // warra aw fou2 :"D
                i2--;
                if (b2.ChessBoard[i2, j].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i2, j].Piece_Color != this.Piece_Color && b2.ChessBoard[i2, j].Piece_Color != 'n')
                {
                    Chess_Game.b[i2, j].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i2, j].BackColor = Color.Yellow;
            }

            while (j1 < 7)
            {
                // ymeen 
                j1++;
                if (b2.ChessBoard[i, j1].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i, j1].Piece_Color != this.Piece_Color && b2.ChessBoard[i, j1].Piece_Color != 'n')
                {
                    Chess_Game.b[i, j1].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i, j1].BackColor = Color.Yellow;
            }

            while (j2 > 0)
            {
                // shaml
                j2--;
                if (b2.ChessBoard[i, j2].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i, j2].Piece_Color != this.Piece_Color && b2.ChessBoard[i, j2].Piece_Color != 'n')
                {
                    Chess_Game.b[i, j2].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i, j2].BackColor = Color.Yellow;
            }
            i1 = i2 = i;
            j1 = j2 = j;

            while (i1 < 7 && j1 < 7)
            {
                // diagonal odam ymeen  :D
                i1++;
                j1++;
                if (b2.ChessBoard[i1, j1].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i1, j1].Piece_Color != this.Piece_Color && b2.ChessBoard[i1, j1].Piece_Color != 'n')
                {
                    Chess_Game.b[i1, j1].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i1, j1].BackColor = Color.Yellow;
            }


            while (i2 < 7 && j2 > 0)
            {
                //diagonal odam shemal :D
                i2++;
                j2--;
                if (b2.ChessBoard[i2, j2].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i2, j2].Piece_Color != this.Piece_Color && b2.ChessBoard[i2, j2].Piece_Color != 'n')
                {
                    Chess_Game.b[i2, j2].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i2, j2].BackColor = Color.Yellow;
            }
            i1 = i2 = i;
            j1 = j2 = j;
            while (i1 > 0 && j1 < 7)
            {
                // diagonal wara ymeen 
                i1--;
                j1++;
                if (b2.ChessBoard[i1, j1].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i1, j1].Piece_Color != this.Piece_Color && b2.ChessBoard[i1, j1].Piece_Color != 'n')
                {
                    Chess_Game.b[i1, j1].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i1, j1].BackColor = Color.Yellow;
            }

            while (i2 > 0 && j2 > 0)
            {
                // diagonal wara shemal
                i2--;
                j2--;
                if (b2.ChessBoard[i2, j2].Piece_Color == this.Piece_Color)
                    break;
                if (b2.ChessBoard[i2, j2].Piece_Color != this.Piece_Color && b2.ChessBoard[i2, j2].Piece_Color != 'n')
                {
                    Chess_Game.b[i2, j2].BackColor = Color.Yellow;
                    break;
                }
                Chess_Game.b[i2, j2].BackColor = Color.Yellow;
            }

        }
    }
}