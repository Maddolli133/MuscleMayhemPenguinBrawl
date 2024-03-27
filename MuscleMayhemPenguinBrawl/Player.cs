using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MuscleMayhemPenguinBrawl
{
    internal class Player
    {
        public int x, y;
        public int width = 30;
        public int height = 10;
        public int speed = 6;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;

                if (y < 0)
                {
                    y = 0;
                }
            }
            else if (direction == "down")
            {
                y += speed;

                if (y > GameScreen.height - height)
                {
                    y = GameScreen.height - height;
                }
            }
            else if (direction == "left")
            {
                x -= speed;

                if (x < 0)
                {
                    x = 0;
                }
            }
            else
            {
                x += speed;

                if (x > GameScreen.width - width)
                {
                    x = GameScreen.width - width;
                }
            }
        }
        public bool Collision(Penguins penguin)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle ballRec = new Rectangle(penguin.x, penguin.y, penguin.size, penguin.size);

            if (playerRec.IntersectsWith(ballRec))
            {
                //move the ball to the front of the player
                if (penguin.ySpeed > 0)
                {
                    penguin.y = y - penguin.size;
                }
                else
                {
                    penguin.y = y + height;
                }

                //change the balls direction
                penguin.ySpeed *= -1;

                return true;
            }

            return false;
        }
    }
}
