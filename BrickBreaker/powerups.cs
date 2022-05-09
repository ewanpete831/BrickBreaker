using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    internal class powerups
    {
        public int x, y;
        public int size = 15;
        public int xspeed, yspeed;
        public int id;
        public powerups(int __x, int __y, int __xspeed, int __yspeed, int _id)
        {
            x = __x;
            y = __y;
            xspeed = __xspeed;
            yspeed = __yspeed;
            id = _id;
        }
        public void Move(Size screenSize)
        {
             y += yspeed;
        }
        public bool PowerupCollision(Paddle p)
        {
            Rectangle powerupRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (powerupRec.IntersectsWith(paddleRec))
            {
                return true;
            }
            return false;

     
        }
    }
}
