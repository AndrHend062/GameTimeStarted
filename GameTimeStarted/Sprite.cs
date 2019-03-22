using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameTimeStarted
{
    class Sprite
    {
        public int x, y;
        int sizeX, sizeY;
       
        public Rectangle rect; 
        public Sprite(int _x,int _y, int _size) // square sprite 
        {
            x = _x;
            y = _y;
           
            sizeX = _size;
            sizeY = _size;
            rect= new Rectangle(x, y, sizeX, sizeY);
        }
        public Sprite(int _x, int _y, int _sizeX, int _sizeY) // rectangle sprite
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            rect = new Rectangle(x, y, sizeX, sizeY);

        }
        public void Jump(int jHeight) // jump method
        {
          rect.Y -= 2 * jHeight;
  
        }
        public void slide(int speed) // slide enemys towards you 
        {
            rect.X -= speed;
           
        }
    
        public Boolean collision(Sprite mobster) // cheak if you hit enemy 
        {
            return mobster.rect.IntersectsWith(rect);

        }

    }
}
