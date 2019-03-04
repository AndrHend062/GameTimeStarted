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
        int jumperY= 90;
        int jumpH = 9;
        bool spaceDown;
        List<Sprite> mobs = new List<Sprite>();
        SolidBrush jumpBrush = new SolidBrush(Color.Aqua);
        SolidBrush mobBrush = new SolidBrush(Color.Red);
        SolidBrush floorBrush = new SolidBrush(Color.Green);
        Form f;
        GameForm gForm;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            gameTime.Start();
            DoubleBuffered = true;
            f = FindForm();
            gForm = f as GameForm;
        }
        public void OnStart() 
        {
            Jumper = new Sprite(jumperX,jumperY,20);
            Floor = new Sprite(0,110, Width, Height- 110);
            mobs.Add(new Sprite(Width, 90, 20));

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
        
        private void gameTime_Tick(object sender, EventArgs e)
        {
            int spawnTicks = 48;
            spawn++;

           // gForm.score++;

            if (spawn % spawnTicks == 0)
            {
                mobs.Add(new Sprite(Width, 90, 20));
            }
           if (mobs[0].collision(Jumper))
             {
                gameTime.Stop();
                
                f.Controls.Add(new EndScreen());
                f.Controls.Remove(this);
            }
            if (spaceDown)
            {
                Jumper.Jump(jumpH);
                jumpH--;
                if (jumpH < -8)
                {
                    jumpH = 8;
                    spaceDown = false;
                }
            }
            foreach (Sprite m in mobs)
            {
                m.slide();
                if (m.x < 50)
                {
                    mobs.Remove(m);
                  
                }
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach(Sprite m in mobs)
            {
                e.Graphics.FillRectangle(mobBrush, m.rect);
            }

            e.Graphics.FillRectangle(floorBrush, Floor.rect);
            e.Graphics.FillRectangle(jumpBrush, Jumper.rect);
        }

       
    }
}
