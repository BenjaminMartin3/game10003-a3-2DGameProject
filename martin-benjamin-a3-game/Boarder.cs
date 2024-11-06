using System;
using System.Numerics;

namespace Game10003
{
    public class Boarder
    {
        Color boarderGreen = new Color(15, 65, 25); 
        public void DrawBoarder()
        {
            Draw.LineSize = 1;
            Draw.LineColor = boarderGreen;
            Draw.FillColor = boarderGreen;

            // Rectangle Edges
            Draw.Rectangle(0, 0, 50, 600);
            Draw.Rectangle(0, 0, 800, 50);
            Draw.Rectangle(750, 0, 50, 600);
        }

        
    }
}
