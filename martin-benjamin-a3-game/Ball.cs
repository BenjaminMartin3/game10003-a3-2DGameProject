using System;
using System.Numerics;

namespace Game10003
{
    public class Ball
    {
        Vector2 positon;
        Vector2 velocity;
        float raidus;
        Color ballGreen = new Color(48, 98, 48);

        // Ball Constructor 
        public Ball()
        {
            // Ball Setup
            velocity = Vector2.One * 150;
            raidus = 10;
            positon = new Vector2(450, 500);
        }

        public void UpdatePosition()
        {
            // Moving the Ball 
            positon -= velocity * Time.DeltaTime;
        }

        public void Render()
        {
            // Draws Ball
            Draw.LineSize = 1;
            Draw.LineColor = ballGreen;
            Draw.FillColor = ballGreen;
            Draw.Circle(positon, raidus);
        }

        public bool ConstrainWithinBoarder()
        {
            bool isTouchingTop = positon.Y <= 0 + raidus + 50;
            bool isTouchingLeft = positon.X <= 0 + raidus + 50;
            bool isTouchingRight = positon.X >= Window.Width - raidus - 50;

            if (isTouchingTop)
            {
                velocity.Y = -velocity.Y;
                return true;
            }

            if (isTouchingLeft || isTouchingRight)
            {
                velocity.X = -velocity.X;
                return true;
            }

            return false;
        }

        public bool isCollidingWithPaddle(Paddle paddle)
        {

            float paddleTop = paddle.position.Y;


            if (paddleTop < positon.Y + 5)
            {
                velocity.Y = -velocity.Y;
                return true;    
            }

            return false;
        }
    }
}
