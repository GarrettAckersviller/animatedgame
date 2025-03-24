using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace animatedgame
{
    internal class guy
    {
        public int x, y;
        public int width = 15;
        public int height = 15;
        public int speed = 6;
        



        public guy()
        {
            x = GameScreen.screenWidth / 2 - width / 2;
            y = GameScreen.screenHeight / 2 - height / 2;
        }

        public void Move(string direction)
        {
            if (direction == "up" && y > 0)
            {
                y -= speed;
            }

            if (direction == "down" && y < GameScreen.screenHeight - height)
            {
                y += speed;
            }

            if (direction == "right" && x < GameScreen.screenWidth - width)
            {
                x += speed;
            }

            if (direction == "left" && x > 0)
            {
                x -= speed;
            }
        }
        public bool Collision(Pellets p)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle pellRec = new Rectangle(p.x, p.y, p.size, p.size);
            

            if (playerRec.IntersectsWith(pellRec))
            {
                Rectangle heroRec = new Rectangle(x, y, width , height );



                return true;
            }
            return false;
        }
    }
}
