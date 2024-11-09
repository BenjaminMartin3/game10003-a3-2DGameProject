using System;
using System.Numerics;

namespace Game10003
{
    public class Bricks
    {
        public Vector2 size;
        public Vector2 position;
        public bool isBrickVisible = true;
        public bool isBrickCollisionOn = true;
        Color brickGreen = new Color(48, 98, 48);
        Color backgroundGreen = new Color(155, 188, 15);

        public void DrawBricks()
        {
            if (isBrickVisible)
            {
                Draw.LineSize = 1;
                Draw.LineColor = backgroundGreen;
                Draw.FillColor = brickGreen;
                Draw.Rectangle(position, size);
            }
        }
    }
}
