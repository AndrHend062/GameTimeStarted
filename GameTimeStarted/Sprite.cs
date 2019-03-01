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
        public int x, y, size;
        int sizeX, sizeY;
        int speed = 5;
        public Rectangle rect; 
        public Sprite(int _x,int _y, int _size)
        {
            x = _x;
            y = _y;
            sizeX = _size;
            sizeY = _size;
            rect= new Rectangle(x, y, sizeX, sizeY);

        }
        public Sprite(int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            rect = new Rectangle(x, y, sizeX, sizeY);

        }
        public void Jump(int jHeight, bool jump)
        {
            if (jump == true)
            {
                y += 2 * jHeight;
            }
           
        }
        public void slide(int posX)
        {
            x = x - speed;
        }
        public Boolean collision(Sprite mobster)
        {
           Rectangle mobRect = new Rectangle(mobster.x, mobster.y, mobster.sizeX, mobster.sizeY);
           return rect.IntersectsWith(mobRect);
            
        }

    }
}
