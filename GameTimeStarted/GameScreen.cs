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
        int spawn = 1;
        Sprite Jumper;
        Sprite Floor;
        int jumperX = 25;
        int jumperY= 140;
        int jumpH = 9;
        bool spaceDown;
        Image REX;
        List<Sprite> mobs = new List<Sprite>();
        static SolidBrush jumpBrush = new SolidBrush(Color.Black);
        SolidBrush mobBrush = new SolidBrush(Color.Red);
        SolidBrush floorBrush = new SolidBrush(Color.Green);
        Pen drawPen = new Pen(Color.Black);
        Font drawFont = new Font("Mongolian Baiti", 16);
        Random rand = new Random();
        int spawnTicks = 48;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            gameTime.Start();
            DoubleBuffered = true;
           
        }
        public void OnStart() 
        {
            Jumper = new Sprite(jumperX,jumperY,20);
            Floor = new Sprite(0,jumperY+20, Width, Height- 110);
            mobs.Add(new Sprite(Width, jumperY, 20));

        }
        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }
        
        private void gameTime_Tick(object sender, EventArgs e) // 60 fps game tick 
        {

            spawn++;

            GameForm.score++;

            if (spawn % spawnTicks == 0) //spawn new monsters 
            {
                mobs.Add(new Sprite(Width, jumperY, 20));
            }
           
            if (mobs[0].collision(Jumper))// check collision with monsters
            {
               gameTime.Stop();
               Form f = FindForm();
               f.Controls.Add(new EndScreen());
               f.Controls.Remove(this);
            }
            
            if (spaceDown) // if space pressed jump player 
            {
                Jumper.Jump(jumpH);
                jumpH--;
                if (jumpH < -9)
                {
                    jumpH = 9;
                    spaceDown = false;
                }
            }
            try
            {
                foreach (Sprite m in mobs) // move monster and delete if off screen
                {
                    m.slide();
                   
                    if (m.rect.X < 0)
                    {
                        mobs.Remove(m);
                       // spawnTicks = rand.Next(48, 61);
                    }
                }
            }
            catch { }
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e) // paint the objects 
        {

            foreach(Sprite m in mobs)
            {
                e.Graphics.FillRectangle(mobBrush, m.rect);
            }
            REX = Properties.Resources.rex.png;
            e.Graphics.FillRectangle(floorBrush, Floor.rect);
            e.Graphics.DrawImage(REX, Jumper.rect);
            e.Graphics.DrawString(GameForm.score+"",drawFont ,jumpBrush,Width-100,50);
        }
    }
}
