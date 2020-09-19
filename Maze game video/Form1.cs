using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_game_video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            movetostart();
        }

        private void Finish_point(object sender, EventArgs e)
        {
            MessageBox.Show("You Won :) ");
            this.Close();
        }
        private void movetostart()
        {
            //startSound.Play();
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 15);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void Hit_wall_out(object sender, EventArgs e)
        {
            MessageBox.Show("You Hit The Wall :( ");
            movetostart();
        }

    }
}
