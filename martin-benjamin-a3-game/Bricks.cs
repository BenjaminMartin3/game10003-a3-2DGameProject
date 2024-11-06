using System;
using System.Numerics;

namespace Game10003
{
    public class Bricks
    {
        Color brickGreen = new Color(48, 98, 48);
        Color backgroundGreen = new Color(155, 188, 15);

        public void DrawBricks()
        {
            Draw.LineSize = 1;
            Draw.LineColor = backgroundGreen;
            Draw.FillColor = brickGreen;

            int brickWidth = 50;
            int brickHeight = 20;


            // Top 3 Rows of Bricks
            for (int i = 0; i < 10; i++)
            {
                int xOffset = i * 50;

                Draw.Rectangle(xOffset + 150, 80, brickWidth, brickHeight);
                Draw.Rectangle(xOffset + 150, 100, brickWidth, brickHeight);
                Draw.Rectangle(xOffset + 150, 120, brickWidth, brickHeight);
            }

            // Middle 2 Rows of Bricks 
        }
    }
}
