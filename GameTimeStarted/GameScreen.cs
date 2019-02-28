using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTimeStarted
{
    public partial class GameScreen : UserControl
    {

        Sprite Jumper;
        int jumperX = 10;
        int jumpery = 100;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            Jumper = new Sprite()
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle()


        }
    }
}
