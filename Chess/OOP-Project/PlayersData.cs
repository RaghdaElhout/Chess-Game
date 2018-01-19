using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class PlayersData : Form
    {
        public static Player p1, p2;
        public PlayersData()
        {
            InitializeComponent();
        }
        private void PlayersData_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            char p1col, p2col;
            if (player1name.Text == "" || player2name.Text == "" || colorBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all the fields!");
            }
            else
            {
                if (colorBox.SelectedIndex == 0)
                { 
                    p1col = 'W';
                    p2col = 'B';
                    p1 = new Player(player1name.Text, p1col, true);
                    p2 = new Player(player2name.Text, p2col, false);
                }
                else if (colorBox.SelectedIndex == 1)
                {
                    p1col = 'B';
                    p2col = 'W';
                    p1 = new Player(player1name.Text, p1col, false);
                    p2 = new Player(player2name.Text, p2col, true);
                }
                this.Hide();
                Chess_Game c = new Chess_Game();
                c.ShowDialog();
                this.Close();
            }
        }
    }
}
