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
            if (position.X < 100)
            {
                position.X = 100;
            }

            // Constrain Right 
            if (position.X + size.X > 700)
            {
                position.X = 700 - size.X; 
            }
        }
    }
}
