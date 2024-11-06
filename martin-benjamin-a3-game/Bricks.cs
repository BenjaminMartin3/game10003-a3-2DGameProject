using System;
using System.Numerics;

namespace Game10003
{
    public class Bricks
    {
        public Vector2 size;
        public Vector2 position; 
        Color brickGreen = new Color(48, 98, 48);
        Color backgroundGreen = new Color(155, 188, 15);
        
        
        public void DrawBricks()
        {
            
            Draw.LineSize = 1;
            Draw.LineColor = backgroundGreen;
            Draw.FillColor = brickGreen;


            for (int i = 0; i < 14; i++)
            {
                // Set Up Position
                position = new Vector2(i * 50 + 50, 220);

                // Set Up Multiple Rows
                Vector2 seventhLine = new Vector2(0, 40);
                Vector2 eighthLine = new Vector2(0, 80);

                // Sixth Line
                Draw.Rectangle(position, size); 
                // Seventh Line
                Draw.Rectangle(position + seventhLine, size); 
                // Eighth Line
                Draw.Rectangle(position + eighthLine, size); 
            }

            for (int i = 0; i < 10; i++)
            {
                // Set Up Position 
                position = new Vector2(i * 50 + 150, 80);

                // Set Up Multiple Rows
                Vector2 secondLine = new Vector2(0, 20);
                Vector2 thirdLine = new Vector2(0, 40);
                Vector2 ninthLine = new Vector2(0, 260);

                // First Line
                Draw.Rectangle(position, size);
                // Second Line
                Draw.Rectangle(position + secondLine, size);
                // Third Line
                Draw.Rectangle(position + thirdLine, size);
                // Ninth Line
                Draw.Rectangle(position + ninthLine, size);
            }

            for (int i = 0; i < 4; i++)
            {
                // Set Up Position
                position = new Vector2(i * 50, 160);

                // Set Up Indivdual Segments 
                Vector2 segmentOne = new Vector2(300, 0);
                Vector2 segmentTwo = new Vector2(600, 0);

                // Set Up Multiple Rows 
                Vector2 fifthLine = new Vector2(0, 20);
                Vector2 tenthLine = new Vector2(0, 220);

                // Left Segment 
                Draw.Rectangle(position, size);
                Draw.Rectangle(position + fifthLine, size);
                Draw.Rectangle(position + tenthLine, size);

                // Middle Segment
                Draw.Rectangle(position + segmentOne, size);
                Draw.Rectangle(position + segmentOne + fifthLine, size);
                Draw.Rectangle(position + segmentOne + tenthLine, size);

                // Right Segment
                Draw.Rectangle(position + segmentTwo, size);
                Draw.Rectangle(position + segmentTwo + fifthLine, size);
                Draw.Rectangle(position + segmentTwo + tenthLine, size);


            }
            
        }

    }
}
