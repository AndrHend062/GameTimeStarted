using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTimeStarted.Properties;
using System.Media;
namespace GameTimeStarted
{
    public partial class GameScreen : UserControl
    {
        int spawn = 1;
        Sprite Jumper;
        Sprite Floor;
        Sprite DirtFloor;
        int jumperX = 25;
        int jumperY = 140;
        int jumpH = 9;
        int speed = 5;
        bool spaceDown;
        bool Haks;
        Image REX;
        Image DINODEAD;
        List<Sprite> mobs = new List<Sprite>();
        List<Sprite> deads = new List<Sprite>();
        static SolidBrush jumpBrush = new SolidBrush(Color.Black);
        SolidBrush mobBrush = new SolidBrush(Color.Red);
        SolidBrush floorBrush;
        Pen drawPen = new Pen(Color.Black);
        Font drawFont = new Font("Mongolian Baiti", 16);
        Random rand = new Random();
        int spawnTicks = 48;
        int deadTicks = 120;
        SoundPlayer SPlayer;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            gameTime.Start();
            DoubleBuffered = true; // make it look nicer 
            SPlayer = new SoundPlayer(Resources.boing); 
        }
        public void OnStart()
        {
            Jumper = new Sprite(jumperX, jumperY, 20);
            Floor = new Sprite(0, jumperY + 20, Width, Height - 110); // place all the objects 
            DirtFloor = new Sprite(0, jumperY + 180, Width, Height - 270);
            mobs.Add(new Sprite(Width, jumperY, 20));
            REX = Resources.rex;
            DINODEAD = Resources.dinoDed; // create images 
            Haks = false;

        }
        private void GameScreen_KeyDown(object sender, KeyEventArgs e) // key presses 
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    SPlayer.Play();
                    break;
                case Keys.G:
                    Haks = !Haks;
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
            if (spawn % 200 == 0) //speed up 
            {
                speed++;
            }
         
            if (spawn % deadTicks == 0)
            {
                deads.Add(new Sprite(Width, rand.Next(350, 700), 30));
            }
            if (Haks == false)
            {
                if (mobs[0].collision(Jumper))// check collision with monsters
                {
                    gameTime.Stop();
                    Form f = FindForm();
                    EndScreen gS = new EndScreen();
                    f.Controls.Add(gS);
                    gS.Location = new Point(Location.X, 0);
                    f.Controls.Remove(this);
                }
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

            foreach (Sprite m in mobs) // move monster and delete if off screen
            {
                m.slide(speed);

                if (m.rect.X < 0)
                {
                    mobs.Remove(m);
                    spawnTicks = rand.Next(48, 61);
                    break;
                }
            }

            foreach (Sprite d in deads)
            {
                d.slide(speed);
                if (d.rect.X < 0)
                {
                    deads.Remove(d);
                    deadTicks = rand.Next(120, 200);
                    break;
                }
            }
            Refresh();
        }

        
    

        private void GameScreen_Paint(object sender, PaintEventArgs e) // paint the objects 
        {

            foreach (Sprite m in mobs)
            {
                e.Graphics.FillRectangle(mobBrush, m.rect);
            }
           
            floorBrush = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(floorBrush, Floor.rect);
            floorBrush = new SolidBrush(Color.SandyBrown);
            e.Graphics.FillRectangle(floorBrush, DirtFloor.rect);
            e.Graphics.DrawImage(REX, Jumper.rect);
            
            e.Graphics.DrawString(GameForm.score + "", drawFont, jumpBrush, Width - 100, 50);
            if (Haks == true)
            {
                e.Graphics.DrawString("Hacks Activated", drawFont, jumpBrush, Width - 500, 50);
            }
            foreach (Sprite d in deads)
            {
                e.Graphics.DrawImage(DINODEAD, d.rect);
            }

        }

    }
}