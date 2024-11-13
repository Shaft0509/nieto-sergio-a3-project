using System;

namespace Game10003
{
    public class Pipe
    {
        public int X;
        public int Height;
        public int Width = 50;
        public int Gap = 150;
        public bool Passed;

        public Pipe(int x, int height)
        {
            X = x;
            Height = height;
        }

        public void Move(int speed)
        {
            X -= speed;
            if (X < -Width)
            {
                X = 800; // Reset position to the right side
                Height = new System.Random().Next(100, 250); // Random height between 100 and 250
            }
        }
    }
}