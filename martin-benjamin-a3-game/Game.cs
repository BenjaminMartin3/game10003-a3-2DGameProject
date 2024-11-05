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
            paddle.color = Color.Black; 

            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            paddle.DrawPaddle();
            paddle.MovePaddle();
            boarder.DrawOuterBoarder(); 
            boarder.DrawInnerBoarder(); 
        }
    }
}
