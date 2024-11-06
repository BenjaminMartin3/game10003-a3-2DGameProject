using System;
using System.Numerics;

namespace Game10003
{
    public class Bricks
    {
        public Vector2 size;
        public Vector2 position;
        public bool isBrickVisible = true;
        Color brickGreen = new Color(48, 98, 48);
        Color backgroundGreen = new Color(155, 188, 15);

        public void DrawBricks()
        {
            Draw.LineSize = 1;
            Draw.LineColor = backgroundGreen;
            Draw.FillColor = brickGreen;
            Draw.Rectangle(position, size);
        }

        public bool HasCollidedWithBrick(Ball ball)
        {
            if (isBrickVisible)
            {

                float brickLeft = position.X;
                float brickRight = position.X + size.X;
                float brickTop = position.Y;
                float brickBottom = position.Y + size.Y;

                float ballLeft = ball.position.X;
                float ballRight = ball.position.X + ball.size.X;
                float ballTop = ball.position.Y;
                float ballBottom = ball.position.Y + ball.size.Y;

                bool ballLeftOfBrick = brickLeft < ballRight;
                bool ballRightOfBrick = brickRight > ballLeft;
                bool ballTopOfBrick = brickTop < ballBottom;
                bool ballBottomOfBrick = brickBottom > ballTop;

                bool isBallHittingBrick =
                    ballLeftOfBrick &&
                    ballRightOfBrick &&
                    ballTopOfBrick &&
                    ballBottomOfBrick;

                if (isBallHittingBrick)
                {
                    ball.velocity.Y = -ball.velocity.Y;
                    isBrickVisible = false;
                }

                return isBallHittingBrick;
            }

            return false;
        }
    }
}
