using Raylib_cs;
using System;
using System.Numerics;

namespace Game10003
{
    public class Paddle
    {
        public Vector2 position;
        public Vector2 size;
        public Color color;
        public float speed;

        public void DrawPaddle()
        {
            // Draw Paddle
            Draw.LineSize = 1;
            Draw.FillColor = color;
            Draw.Rectangle(position, size);
        }

        public void MovePaddle()
        {
            // Move Paddle Left
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                position.X -= speed * Time.DeltaTime;
            }

            // Move Paddle Right 
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                position.X += speed * Time.DeltaTime;
            }

            // Constrain Left
            if (position.X < 50)
            {
                position.X = 50;
            }

            // Constrain Right 
            if (position.X + size.X > 750)
            {
                position.X = 750 - size.X;
            }
        }
    }
}
