// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Paddle paddle = new Paddle();
        Boarder boarder = new Boarder();
        Ball ball = new Ball();
        Bricks[] bricks = new Bricks[14];

        Color backgroundGreen = new Color(155, 188, 15);
        Color ballGreen = new Color(139, 172, 25);
        Color brickGreen = new Color(48, 98, 48);
        Color boarderGreen = new Color(15, 65, 25);

        int playerScore = 0;

        int numberOfBricks = 14;
        int maxAmountOfBricks = 14;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Breakout Clone");
            Window.SetSize(800, 600);

            // Paddle Settings 
            paddle.position.X = Window.Width / 2;
            paddle.position.Y = Window.Height - 50;
            paddle.size = new Vector2(80, 20);
            paddle.speed = 500;
            paddle.color = boarderGreen;

            // Setup Random Brick Placements 
            for (int i = 0; i < 10; i++)
            {
                int xOffset = i * 25;
                Bricks brick = new Bricks();
                brick.size = new Vector2(50, 20);
                brick.position.X = 50 + xOffset;
                brick.position.Y = Random.Float(50, 400);
                bricks[i] = brick;
            }

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            if (ball.position.Y > Window.Height)
            {
                RenderGameOver();
            }
            else
            {
                RenderGame(); 
            }
            paddle.MovePaddle();

            // Ball collsion with Brick 

            for (int i = 0; i < 10; i++)
            {
                bool ballCollidesWithBrick = ball.IsCollidingWithBrick(bricks[i]);

                // Brick Disappears When Hit
                if (ballCollidesWithBrick)
                {
                    bricks[i].isBrickVisible = false;
                    bricks[i].isBrickCollisionOn = false;
                    playerScore += 100;
                    numberOfBricks--;
                }

                // Brick Reappears Somewhere Else
                if (ballCollidesWithBrick && maxAmountOfBricks > numberOfBricks)
                {
                    bricks[i].position.X = Random.Float(50, 700);
                    bricks[i].position.Y = Random.Float(50, 400);
                    bricks[i].isBrickVisible = true;
                    bricks[i].isBrickCollisionOn = true;
                }
            }

            Window.ClearBackground(backgroundGreen);
        }

        void RenderGame()
        {
            ball.Render();
            paddle.DrawPaddle();
            boarder.DrawBoarder();
            for (int i = 0; i < 10; i++)
            {
                bricks[i].DrawBricks();
            }
            Text.Draw($"Score: {playerScore}", 75, 10);

            ball.UpdatePosition();
            ball.ConstrainWithinBoarder();
            ball.IsCollidingWithPaddle(paddle);
        }

        void RenderGameOver()
        {
            Text.Draw("Game Over!", Window.Width / 2 - 75, Window.Height / 2 - 100);
            Text.Draw("Press Spacebar To Play", Window.Width / 2 - 175, Window.Height / 2); 
            Text.Draw($"Your Score: {playerScore}", Window.Width / 2 - 125, Window.Height / 2 + 100); 
            if(Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                RenderGame();
                ball.position = new Vector2(450, 500);
                ball.velocity.Y = -ball.velocity.Y;
                playerScore = 0;    
            }
        }
    }
}
