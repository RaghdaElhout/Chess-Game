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
namespace OOP_Project
{
    public partial class chess : Form
    {
        public chess()
        {
            InitializeComponent();
        }

        private void chess_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            Hide();
            PlayersData pd = new PlayersData();
            pd.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Chess.txt"))
            {
                MessageBox.Show("There is no Previous Game");
            }
            else
            {
                SaveGame G = new SaveGame();
                FileStream fs = new FileStream("Chess.txt", FileMode.Open);
                BinaryFormatter B = new BinaryFormatter();
                G = (SaveGame)B.Deserialize(fs);
                fs.Close();
                Hide();
                Chess_Game c = new Chess_Game();
                c.New_Game = false;
                c.UpdatePreviousGame(G);
                c.ShowDialog();
                Close();
            }
        }
    }
}
