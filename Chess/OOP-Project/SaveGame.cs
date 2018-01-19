using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace OOP_Project
{
    [Serializable]
    public class SaveGame
    {
        public Player p1;
        public Player p2;
        public List<Pieces> KilledWhite;
        public List<Pieces> KilledBlack;
        public Pieces[,] board;
        public SaveGame()
        { }
        public SaveGame(Player p1, Player p2, Pieces[,] board, List<Pieces> KilledWhite, List<Pieces> KilledBlack)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.board = board;
            this.KilledBlack = KilledBlack;
            this.KilledWhite = KilledWhite;
        }
    }
}
