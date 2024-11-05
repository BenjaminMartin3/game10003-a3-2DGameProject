using System;
using System.Numerics;

namespace Game10003
{
    public class Boarder
    {
        public void DrawOuterBoarder()
        {
            Draw.LineSize = 1;
            Draw.FillColor = Color.Black;

            // Rectangle Edges
            Draw.Rectangle(0, 0, 50, 600);
            Draw.Rectangle(0, 0, 800, 50);
            Draw.Rectangle(750, 0, 50, 600);
            Draw.Rectangle(700, 550, 50, 50);
            Draw.Rectangle(50, 550, 50, 50);

            // Triangles Corners 
            Draw.Triangle(700, 50, 750, 50, 750, 100);
            Draw.Triangle(100, 50, 50, 50, 50, 100);
            Draw.Triangle(50, 500, 100, 550, 50, 550);
            Draw.Triangle(750, 500, 750, 550, 700, 550);
        }

        public void DrawInnerBoarder()
        {
            Draw.LineSize = 1;
            Draw.FillColor = Color.Black;

            // Left Inner Boarder 
            Draw.Rectangle(150, 220, 150, 20); 
            Draw.Rectangle(150, 220, 20, 150); 
            Draw.Rectangle(150, 360, 150, 20);

            // Right Inner Boarder
            Draw.Rectangle(500, 220, 150, 20);
            Draw.Rectangle(630, 220, 20, 150);
            Draw.Rectangle(500, 360, 150, 20);
        }
    }
}
