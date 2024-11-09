using System;
using System.Numerics;

namespace Game10003
{
    public class Ball
    {
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 size;
        public float speed;
        Bricks brick = new Bricks();
        Color ballGreen = new Color(48, 98, 48);

        // Ball Constructor 
        public Ball()
        {
            // Ball Setup
            speed = 300;
            velocity = Vector2.One * speed;
            size = Vector2.One * 20;
            position = new Vector2(450, 500);
        }

        public void UpdatePosition()
        {
            // Moving the Ball 
            position -= velocity * Time.DeltaTime;
        }

        public void Render()
        {
            // Draws Ball
            Draw.LineSize = 1;
            Draw.LineColor = ballGreen;
            Draw.FillColor = ballGreen;
            Draw.Rectangle(position, size);
        }

        public void ConstrainWithinBoarder()
        {

            float ballLeft = position.X;
            float ballRight = position.X + size.X;
            float ballTop = position.Y;
            float ballBottom = position.Y + size.Y;

            bool isTouchingTop = ballTop <= 0 + 50;
            bool isTouchingLeft = ballLeft <= 0 + 50;
            bool isTouchingRight = ballRight >= Window.Width - 50;

            if (isTouchingTop)
            {
                velocity.Y = -velocity.Y;
            }

            if (isTouchingLeft || isTouchingRight)
            {
                velocity.X = -velocity.X;
            }
        }

        public void IsCollidingWithPaddle(Paddle paddle)
        {

            float ballLeft = position.X;
            float ballRight = position.X + size.X;
            float ballTop = position.Y;
            float ballBottom = position.Y + size.Y;

            float paddleLeft = paddle.position.X;
            float paddleRight = paddle.position.X + paddle.size.X;
            float paddleTop = paddle.position.Y;
            float paddleBottom = paddle.position.Y + paddle.size.Y;

            bool isBallLeftOfPaddle = ballRight > paddleLeft;
            bool isBallRightOfPaddle = ballLeft < paddleRight;
            bool isBallTopOfPaddle = ballBottom > paddleTop;
            bool isBallBottomOfPaddle = ballTop < paddleBottom;

            bool isBallHittingPaddle =
                isBallLeftOfPaddle &&
                isBallRightOfPaddle &&
                isBallTopOfPaddle &&
                isBallBottomOfPaddle;


            if (isBallHittingPaddle)
            {
                velocity.Y = -velocity.Y;
            }

        }

        public bool IsCollidingWithBrick(Bricks brick)
        {
            float ballLeft = position.X;
            float ballRight = position.X + size.X;
            float ballTop = position.Y;
            float ballBottom = position.Y + size.Y;

            float brickLeft = brick.position.X;
            float brickRight = brick.position.X + brick.size.X;
            float brickTop = brick.position.Y;
            float brickBottom = brick.position.Y + brick.size.Y;

            bool isBallLeftOfBrick = ballRight > brickLeft;
            bool isBallRightOfBrick = ballLeft < brickRight;
            bool isBallTopOfBrick = ballBottom > brickTop;
            bool isBallBottomOfBrick = ballTop < brickBottom;

            bool isBallHittingBrick =
                isBallLeftOfBrick &&
                isBallRightOfBrick &&
                isBallTopOfBrick &&
                isBallBottomOfBrick;

            if (brick.isBrickCollisionOn)
            {
                if (isBallHittingBrick)
                {
                    velocity.Y = -velocity.Y;
                    return isBallHittingBrick;

                }
            }
            return false;
        }
    }
}
