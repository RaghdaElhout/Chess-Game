using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace OOP_Project
{
    public partial class Chess_Game : Form
    {
        public static UC[,] b;
        public static UC[,] LW;
        public static UC[,] LB;
        int x = -1, y = -1, X2 = -1, Y2 = -1, king1move=0, king2move=0, rook1move=0, rook2move = 0, rook3move = 0, rook4move = 0;
        public List<Pieces> LostW = new List<Pieces>();
        public List<Pieces> LostB = new List<Pieces>();
        public List<Pieces> check = new List<Pieces>();
        public bool New_Game = true;
        public Board board = new Board();
        public Chess_Game()
        {
            InitializeComponent();

        }
        public void Update_Board()
        {
            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    if (board.ChessBoard[i, j].Piece_Color == 'n')
                        b[i, j].BackgroundImage = null;
                    else if (board.ChessBoard[i, j] is Rook && board.ChessBoard[i, j].Piece_Color == 'B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/RB.png");
                    else if (board.ChessBoard[i, j] is Knight && board.ChessBoard[i, j].Piece_Color == 'B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KB.png");
                    else if (board.ChessBoard[i, j] is Bishop && board.ChessBoard[i, j].Piece_Color == 'B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/BB.png");
                    else if (board.ChessBoard[i, j] is Queen && board.ChessBoard[i, j].Piece_Color == 'B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/QB.png");
                    else if (board.ChessBoard[i, j] is King && board.ChessBoard[i, j].Piece_Color == 'B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KGB.png");
                    else if (board.ChessBoard[i, j] is Pawn && board.ChessBoard[i, j].Piece_Color == 'B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/PB.png");
                    else if (board.ChessBoard[i, j] is Rook && board.ChessBoard[i, j].Piece_Color == 'W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/RW.png");
                    else if (board.ChessBoard[i, j] is Knight && board.ChessBoard[i, j].Piece_Color == 'W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KW.png");
                    else if (board.ChessBoard[i, j] is Bishop && board.ChessBoard[i, j].Piece_Color == 'W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/BW.png");
                    else if (board.ChessBoard[i, j] is Queen && board.ChessBoard[i, j].Piece_Color == 'W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/QW.png");
                    else if (board.ChessBoard[i, j] is King && board.ChessBoard[i, j].Piece_Color == 'W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KGW.png");
                    else if (board.ChessBoard[i, j] is Pawn && board.ChessBoard[i, j].Piece_Color == 'W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/PW.png");

                }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {

                    if (i % 2 == 0)
                        if (j % 2 == 1)
                            b[i, j].BackColor = Color.Black;
                        else
                            b[i, j].BackColor = Color.Silver;
                    else
                        if (j % 2 == 1)
                        b[i, j].BackColor = Color.Silver;
                    else
                        b[i, j].BackColor = Color.Black;

                }

            }
            Update_WhitekilledPieces(LostW);
            Update_BlackkilledPieces(LostB);
        }
        public void Update_WhitekilledPieces(List<Pieces> lost)
        {
            int i, j,k=0;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    //eh dahhhh !!!!!
                    if (k >= lost.Count)
                        LW[i, j].BackgroundImage = null;

                    else if (lost[k] is Rook && lost[k].Piece_Color == 'W')
                        LW[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/RW.png");
                    else if (lost[k] is Knight && lost[k].Piece_Color == 'W')
                        LW[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KW.png");
                    else if (lost[k] is Bishop && lost[k].Piece_Color == 'W')
                        LW[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/BW.png");
                    else if (lost[k] is Queen && lost[k].Piece_Color == 'W')
                        LW[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/QW.png");
                    else if (lost[k] is King && lost[k].Piece_Color == 'W')
                        LW[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KGW.png");
                    else if (lost[k] is Pawn && lost[k].Piece_Color == 'W')
                        LW[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/PW.png");
                    k++;

                }

            }
        }
        public void Update_BlackkilledPieces(List<Pieces> lost)
        {
             int i, j,k=0;
             for (i = 0; i < 4; i++)
             {
                 for (j = 0; j < 4; j++)
                 {
                     if (k >= lost.Count)
                         LB[i, j].BackgroundImage = null;
                     else if (lost[k] is Rook && lost[k].Piece_Color == 'B')
                         LB[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/RB.png");
                     else if (lost[k] is Knight && lost[k].Piece_Color == 'B')
                         LB[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KB.png");
                     else if (lost[k] is Bishop && lost[k].Piece_Color == 'B')
                         LB[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/BB.png");
                     else if (lost[k] is Queen && lost[k].Piece_Color == 'B')
                         LB[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/QB.png");
                     else if (lost[k] is King && lost[k].Piece_Color == 'B')
                         LB[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KGB.png");
                     else if (lost[k] is Pawn && lost[k].Piece_Color == 'B')
                         LB[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/PB.png");
                     k++;
                 }
             }
        }
        public void drawLabel()
        {
            //Player 1
            Label label1 = new Label();
            label1.Location = new System.Drawing.Point(120,50);
            label1.Parent = this; // hyzhr henaaa
            label1.Name = "label1";
            label1.Text = PlayersData.p1.name;
            label1.Size = new System.Drawing.Size(120, 30);
            label1.Font = new Font("Arial", 18, FontStyle.Bold);
            label1.BackColor = Color.Pink;
            //Player 1 color
            Label label3 = new Label();
            label3.Location = new System.Drawing.Point(120, 50+40);
            label3.Parent = this;
            label3.Name = "label3";
            if (PlayersData.p1.myColor == 'W')
                label3.Text = "White";
            if (PlayersData.p1.myColor == 'B')
                label3.Text = "Black";
            label3.Size = new System.Drawing.Size(77, 21);
            label3.Font = new Font("Arial", 14, FontStyle.Bold);
            label3.BackColor = Color.Pink;
            //player2
            Label label2 = new Label();
            label2.Location = new System.Drawing.Point(1050, 50);
            label2.Parent = this;
            label2.Name = "label2";
            label2.Text = PlayersData.p2.name;
            label2.Size = new System.Drawing.Size(120, 30);
            label2.Font = new Font("Arial", 18, FontStyle.Bold);
            label2.BackColor = Color.Pink;
            //Player 2 color
            Label label4 = new Label();
            label4.Location = new System.Drawing.Point(1050, 50+40);
            label4.Parent = this;
            label4.Name = "label4";
            if (PlayersData.p2.myColor == 'W')
                label4.Text = "White";
            if (PlayersData.p2.myColor == 'B')
                label4.Text = "Black";
            label4.Size = new System.Drawing.Size(77, 21);
            label4.Font = new Font("Arial", 14, FontStyle.Bold);
            label4.BackColor = Color.Pink;
            //Save Button
            Button Save = new Button();
            Save.Location = new System.Drawing.Point(1100, 600);
            Save.Parent = this;
            Save.Text = "Save Game";
            Save.Size = new System.Drawing.Size(120, 50);
            Save.Font = new Font("Arial", 18, FontStyle.Bold);
            Save.Click += new EventHandler(Save_Click);
        }
        void Save_Click(object sender, EventArgs e)
        {
            SaveGame Game = new SaveGame(PlayersData.p1, PlayersData.p2, board.ChessBoard, LostW, LostB);
            BinaryFormatter BF = new BinaryFormatter();
            FileStream fs = new FileStream("Chess.txt", FileMode.OpenOrCreate);
            BF.Serialize(fs, Game);
            fs.Close();
            MessageBox.Show("Saved");
        }
        public void UpdatePreviousGame(SaveGame Game)
        {
            LostB = Game.KilledBlack;
            LostW = Game.KilledWhite;
            board.ChessBoard = Game.board;
            PlayersData.p1 = new Player();
            PlayersData.p1 = Game.p1;
            PlayersData.p2 = new Player();
            PlayersData.p2 = Game.p2;
        }
        private void Chess_Game_Load(object sender, EventArgs e)
        {
            /*var sound = new System.Media.SoundPlayer();
            sound.SoundLocation = @"C:\Users\A\Desktop\Chess\OOP-Project\music.wav";
            sound.Play();*/
            //make the form full screen
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            if (New_Game == true)
            {
                board = new Board();
            }
            drawLabel();
            b = new UC[8, 8];
            LB = new UC[4, 4];
            LW = new UC[4, 4];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    b[i, j] = new UC();
                    b[i, j].Parent = this;
                    b[i, j].Location = new Point(250 + (j * 85 + 85), -75 + (i * 85 + 85));
                    b[i, j].X = j;
                    b[i, j].Y = i;
                    b[i, j].Size = new Size(85, 85);
                    b[i, j].Click += new EventHandler(uC_Click);
                    if (i % 2 == 0)
                        if (j % 2 == 1)
                            b[i, j].BackColor = Color.Black;
                        else
                            b[i, j].BackColor = Color.Silver;
                    else
                        if (j % 2 == 1)
                        b[i, j].BackColor = Color.Silver;
                    else
                        b[i, j].BackColor = Color.Black;
                    b[i, j].BackgroundImageLayout = ImageLayout.Center;
                    b[i, j].BorderStyle = BorderStyle.Fixed3D;

                }

            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    LW[i, j] = new UC();
                    LW[i, j].Parent = this;
                    LW[i, j].Location = new Point((j * 85), 200 + (i * 85));
                    LW[i, j].X = j;
                    LW[i, j].Y = i;
                    LW[i, j].Size = new Size(85, 85);
                    LW[i, j].Click += new EventHandler(LW_Click);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    LB[i, j] = new UC();
                    LB[i, j].Parent = this;
                    LB[i, j].Location = new Point((j * 85) + 1000, 200 + (i * 85));
                    LB[i, j].X = j;
                    LB[i, j].Y = i;
                    LB[i, j].Size = new Size(85, 85);
                    LB[i, j].Click += new EventHandler(LB_Click);
                }
            }
            Update_Board();
        }
        void UpgradeWhite(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                if (board.ChessBoard[7, i] is Pawn )
                {
                    board.ChessBoard[7, i] = LostW[(4 * x) + y];
                    LostW[(4 * x) + y] = new Pawn (x, y, 'W');
                   
                    return;
                }
            }
        }
        void LW_Click(object sender, EventArgs e)
        {
            int i, j;
            i = (sender as UC).Y;
            j = (sender as UC).X;
            UpgradeWhite(i, j);
        }
        void UpgradeBlack(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                if (board.ChessBoard[0, i] is Pawn && board.ChessBoard[0, i].Piece_Color == 'B')
                {
                    board.ChessBoard[0, i] = LostB[(4 * x) + y];
                    LostB[(4 * x) + y] = new Pawn(x, y, 'B');
                    return;
                }
            }
        }
        void LB_Click(object sender, EventArgs e)
        {
            int i, j;
            i = (sender as UC).Y;
            j = (sender as UC).X;
            UpgradeBlack(i, j);
        }
        void uC_Click(object sender, EventArgs e)
        {
            int i, j;
            i = (sender as UC).Y;
            j = (sender as UC).X;
            IsYourTurn(i, j);
        }
        void IsYourTurn(int i, int j)
        {
            //lw nfs el color w msh asfr yb2a msh dore
            //7tt msh asfr alle hwa ynf3 a3ml click 3alla piece msh lone 3shan akol
            if (PlayersData.p1.myTurn == false && PlayersData.p1.myColor == board.ChessBoard[i, j].Piece_Color
               && b[i, j].BackColor != Color.Yellow)
            {
                MessageBox.Show("Not your turn!");
            }
            else if (PlayersData.p2.myTurn == false && PlayersData.p2.myColor == board.ChessBoard[i, j].Piece_Color
                && b[i, j].BackColor != Color.Yellow)
            {
                MessageBox.Show("Not your turn!");
            }
            else
            {
                play(i, j);
                //lw 3aml click 3alla rook aw king ha5od el position bta3hom f X2, Y2
                if (board.ChessBoard[i,j] is Rook || board.ChessBoard[i,j] is King)
                {
                    X2 = i;
                    Y2 = j;
                }               
            }
        }
        void play(int i, int j)
        {
            //the first click
            //lw msh fade w msh asfr yb2a de el first click
            if (board.ChessBoard[i, j].Piece_Color != 'n' && b[i, j].BackColor != Color.Yellow)
            {
               if (x != -1 && y != -1)
                    Update_Board();
                board.ChessBoard[i, j].Available_Moves(board, i, j);
                x = i;
                y = j;
            }
            //the after clicks
            if (x != -1 && y != -1)
            {
                //msh awl click liia w el click al 7alia lonha asfr
                //kda hakol
                if (b[i, j].BackColor == Color.Yellow)
                {
                    //lw akl piece ha5odha f list
                    if (board.ChessBoard[i, j].Piece_Color != 'n')
                    {
                        if (board.ChessBoard[i, j].Piece_Color == 'W')
                        {
                            if (board.ChessBoard[i, j] is King)
                            {
                                if (PlayersData.p1.myColor == 'W')
                                MessageBox.Show("Game Over!" + "\n" + "The winner is " + PlayersData.p2.name);
                                else
                                    MessageBox.Show("Game Over!" + "\n" + "The winner is " + PlayersData.p1.name);
                                this.Close();
                            }
                            LostW.Add(board.ChessBoard[i, j]);
                        }  
                        else if (board.ChessBoard[i, j].Piece_Color == 'B')
                        {
                            if (board.ChessBoard[i, j] is King)
                            {
                                if (PlayersData.p1.myColor == 'B')
                                    MessageBox.Show("Game Over!" + "\n" + "The winner is " + PlayersData.p2.name);
                                else
                                    MessageBox.Show("Game Over!" + "\n" + "The winner is " + PlayersData.p1.name);
                                this.Close();
                            }
                            LostB.Add(board.ChessBoard[i, j]);
                        }
                    }
                    //el move nfsha b2a
                    board.ChessBoard[i, j] = board.ChessBoard[x, y];
                    board.ChessBoard[i, j].X_Postion = i;
                    board.ChessBoard[i, j].Y_Postion = j;
                    board.ChessBoard[x, y] = new Pieces(x, y, 'n');
                    //check if the king moved (castling)
                    if (board.ChessBoard[i, j] is King)
                    {
                        if (x == 0 && y == 3)
                            king1move++;
                        if (x == 7 && y == 3)
                            king2move++;
                    }
                    //check if the rook moved
                    if (board.ChessBoard[i, j] is Rook)
                    {
                        if (x == 0 && y == 0)
                            rook1move++;
                        if (x == 0 && y == 7)
                            rook2move++;
                        if (x == 7 && y == 0)
                            rook3move++;
                        if (x == 7 && y == 7)
                            rook4move++;
                    }
                    ChangeTurns();
                    x = -1;
                    y = -1;
                    Update_Board();
                    Checkmate(board.ChessBoard[i, j].Piece_Color);
                }
            }
            //check if two clicks are king and rook
            if (X2 != -1)
            {
                if (board.ChessBoard[i, j].Piece_Color == board.ChessBoard[X2, Y2].Piece_Color)
                {
                    //lw 3aml click 3l king el awl
                    if (board.ChessBoard[i, j] is Rook && board.ChessBoard[X2, Y2] is King)

                    {
                        //white king
                        if (X2 == 0 && Y2 == 3 && king1move == 0 &&
                            (i == 0 && j == 0 && rook1move == 0 || i == 0 && j == 7 && rook2move == 0))
                            castling(i, j, X2, Y2);
                        //black king
                        else if (X2 == 7 && Y2 == 3 && king2move == 0 &&
                            (i == 7 && j == 0 && rook3move == 0 || i == 7 && j == 7 && rook4move == 0))
                            castling(i, j, X2, Y2);
                        else
                        {
                            MessageBox.Show("You can not castle!");
                        }
                    }
                    //lw 3aml click 3l rook el awl
                    if (board.ChessBoard[X2, Y2] is Rook && board.ChessBoard[i, j] is King)
                    {
                        //white king
                        if (i == 0 && j == 3 && king1move == 0 &&
                            (X2 == 0 && Y2 == 0 && rook1move == 0 || X2 == 0 && Y2 == 7 && rook2move == 0))
                            castling(X2, Y2, i, j);
                        //black king
                        else if (i == 7 && j == 3 && king2move == 0 &&
                            (X2 == 7 && Y2 == 0 && rook3move == 0 || X2 == 7 && Y2 == 7 && rook4move == 0))
                            castling(X2, Y2, i, j);
                        else
                        {
                            MessageBox.Show("You can not castle!");
                        }
                    }
                }
            }
        }
        void castling(int RX, int RY, int KX, int KY)
        {
            //el rook el ymen
            if (RX == 0 && RY == 0 || RX == 7 && RY == 0)
            {
                if (board.ChessBoard[RX, RY + 1].Piece_Color == 'n' && board.ChessBoard[RX, RY + 2].Piece_Color == 'n')
                {
                    MessageBox.Show("Castling!");
                    board.ChessBoard[RX, RY + 1] = new King(RX, RY + 1, board.ChessBoard[KX, KY].Piece_Color);
                    board.ChessBoard[RX, RY + 2] = new Rook(RX, RY + 2, board.ChessBoard[KX, KY].Piece_Color);
                    board.ChessBoard[RX, RY] = new Pieces(RX, RY, 'n');
                    board.ChessBoard[KX, KY]= new Pieces(KX, KY, 'n');
                    Update_Board();
                    ChangeTurns();
                }
            }
            //el rook el shmal
            else if (RX == 0 && RY == 7 || RX == 7 && RY == 7)
            {
                if (board.ChessBoard[RX, RY - 1].Piece_Color == 'n' && board.ChessBoard[RX, RY - 2].Piece_Color == 'n'
                    && board.ChessBoard[RX, RY - 3].Piece_Color == 'n')
                {
                    MessageBox.Show("Castling!");
                    board.ChessBoard[RX, RY - 1] = new King(RX, RY - 1, board.ChessBoard[KX, KY].Piece_Color);
                    board.ChessBoard[RX, RY - 2] = new Rook(RX, RY - 2, board.ChessBoard[KX, KY].Piece_Color);
                    board.ChessBoard[RX, RY] = new Pieces(RX, RY, 'n');
                    board.ChessBoard[KX, KY] = new Pieces(KX, KY, 'n');
                    Update_Board();
                    ChangeTurns();
                }
            }
        }
        void ChangeTurns()
        {
            if (PlayersData.p1.myTurn == true)
            {
                PlayersData.p1.myTurn = false;
                PlayersData.p2.myTurn = true;
            }
            else if (PlayersData.p2.myTurn == true)
            {
                PlayersData.p2.myTurn = false;
                PlayersData.p1.myTurn = true;
            }
        }
        void Checkmate(char mycol)
        {
            int z=-1, z2=-1;
            //bylf 3l board yshouf el pieces alle msh lone w ygeb el available moves bta3thom
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board.ChessBoard[i, j].Piece_Color == mycol)
                    {
                        board.ChessBoard[i, j].Available_Moves(board, i, j);
                        //bylf 3l availble moves w yshouf fehom king walla la2
                        for (int a = 0; a < 8; a++)
                        {
                            for (int a2 = 0; a2 < 8; a2++)
                            {
                                if (b[a, a2].BackColor == Color.Yellow) 
                                {
                                    if (board.ChessBoard[a, a2] is King)
                                    {
                                        z = a;
                                        z2 = a2;
                                        check.Add(board.ChessBoard[i, j]);
                                    }
                                }
                            }
                        }
                        Update_Board();
                    }
                }
            }
            if ( check.Count != 0 && z!= -1 )
            {
                b[z, z2].BackColor = Color.Red;
                MessageBox.Show("Checkmate!");
            }
        }
    }
}