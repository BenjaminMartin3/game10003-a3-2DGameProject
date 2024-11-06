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
        Bricks bricks = new Bricks();

        Color backgroundGreen = new Color(155, 188, 15);
        Color ballGreen = new Color(139, 172, 25);
        Color brickGreen = new Color(48, 98, 48);
        Color boarderGreen = new Color(15, 65, 25);
        
       

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
            paddle.speed = 400; 
            paddle.color = boarderGreen;

            bricks.size = new Vector2(50, 20);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(backgroundGreen);
            paddle.DrawPaddle();
            paddle.MovePaddle();

            bricks.DrawBricks();

            boarder.DrawBoarder();
            
            ball.UpdatePosition();
            ball.ConstrainWithinBoarder();
            ball.isCollidingWithPaddle(paddle); 
            ball.Render();

            

             
        }
    }
}
