using global::Game10003;
using System;

namespace Game10003
{
    public class Game
    {

        // Declare your Variables
        private Pipe pipe;
        private Character character;
        private int pipeSpeed = 5;
        private Movement movement = new Movement();
        private bool gameOver = false;
        private Score score;

        public void Setup()
        {
            Window.SetTitle("Flappity Bally");
            Window.SetSize(800, 400);

            pipe = new Pipe(800, new System.Random().Next(100, 250)); // Height between 100 and 250
            character = new Character(200); // Character starts in the middle of the screen
            score = new Score();
        }

        public void Update()
        {
            // If the game is over, display the "Game Over!" message and stop further updates
            if (gameOver)
            {
                Window.ClearBackground(Color.White);
                DrawGameOverMessage();
                return;
            }


            Window.ClearBackground(Color.White);

            // Update character logic and handle input
            character.Update();

            // Move the pipe and apply gravity to the character
            pipe.Move(pipeSpeed);

            // Check for collisions 
            if (CheckCollision())
            {
                gameOver = true; // Set gameOver true if collision happens
            }

            // Draw the game objects
            DrawGameObjects();
            score.Draw(); // Draw the score using the Score class
        }

        private bool CheckCollision()
        {
            // Check if the character is out of the window 
            if (character.Y > 400 || character.Y < 0) // If character is out of bounds
            {
                return true;
            }

            // Check if the character hits the pipe
            if (character.X + character.Radius > pipe.X && character.X - character.Radius < pipe.X + pipe.Width &&
                (character.Y - character.Radius < pipe.Height || character.Y + character.Radius > pipe.Height + pipe.Gap))
            {
                return true; // Collision with pipe
            }

            return false;
        }
        private void DrawGameObjects()
        {
            // Draw the character as a circle
            Draw.FillColor = Color.Yellow;
            Draw.Circle(character.X, character.Y, character.Radius);

            // Draw the pipes
            Draw.FillColor = Color.Green;
            Draw.Rectangle(pipe.X, 0, pipe.Width, pipe.Height); // Top part of the pipe
            Draw.Rectangle(pipe.X, pipe.Height + pipe.Gap, pipe.Width, 400 - (pipe.Height + pipe.Gap)); // Bottom part of the pipe
        }

        private void DrawGameOverMessage()

        {
            Text.Draw("Game Over!", 300, 200);
        }



    }
}









