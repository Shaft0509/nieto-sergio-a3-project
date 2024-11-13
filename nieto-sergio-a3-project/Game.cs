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


