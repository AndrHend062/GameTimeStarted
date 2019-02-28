using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTimeStarted
{
    class Sprite
    {
        int x, y, size;
        int speed = 5;
        public Sprite(int _x,int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;

        }
        public void Jump()
        {

        }
        public void slide(int posX)
        {
            x = x - speed;
        }
    }
}
