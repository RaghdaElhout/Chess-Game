using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class Player
    {
        public string name;
        public char myColor;
        public bool myTurn;
        public Player ()
        { }
        public Player(string n, char c, bool t)
        {
            this.name = n;
            this.myColor = c;
            if (c == 'W')
                this.myTurn = true;
            if (c == 'B')
                this.myTurn = false;
        }
    }
}
