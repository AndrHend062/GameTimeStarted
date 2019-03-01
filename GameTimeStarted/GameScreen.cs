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
        Sprite Floor;
        int jumperX = 10;
        int jumperY= 100;
        List<Sprite> mobs = new List<Sprite>();
        SolidBrush jumpBrush = new SolidBrush(Color.Aqua);
        SolidBrush mobBrush = new SolidBrush(Color.Red);
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart() 
        {
            Jumper = new Sprite(jumperX,jumperY,20);
            Floor = new Sprite(0,110, Width, 200);
            mobs.Add(new Sprite(300, 100, 20));

        }
        int jumpH = 3;
        private void gameTime_Tick(object sender, EventArgs e)
        {
            if (Jumper.collision(Floor))    
            {
                Jumper.y--;
            }
         //Jumper.Jump(jumpH, 
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

           

            foreach(Sprite m in mobs)
            {
                e.Graphics.FillRectangle(mobBrush, m.rect);
            }

            e.Graphics.FillRectangle(mobBrush, Floor.rect);
            e.Graphics.FillRectangle(jumpBrush, Jumper.rect);
        }
    }
}
