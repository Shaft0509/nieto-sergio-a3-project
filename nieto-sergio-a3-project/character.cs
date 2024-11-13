using Game10003;

namespace Game10003
{
    public class Character
    {
        public int Y;
        public int X = 100; //  X position
        public int Radius = 20; // Circle (Ball size)
        private int gravity = 1; // Slower gravity value
        private int jumpStrength = -7; 
        private int velocity = 0; // Controls speed
        private bool isJumping = false; //  check if the character has jumped yet
        private bool gameStarted = false; //  track if the game has started

        public Character(int startY)
        {
            Y = startY; // Initial Y position for the character
        }

        public void ApplyGravity()
        {
            if (gameStarted) // Apply gravity only if the game has started
            {
                velocity += gravity; // Apply gravity
                Y += velocity; // character (ball) movement
            }
        }

        public void Jump()
        {
            if (gameStarted) // allow jumping if the game has started
                            
            {
                velocity = jumpStrength; // Set velocity to jump strength
            }
        }

        public void StartGame()
        {
            if (!gameStarted) // Start game only once
            {
                gameStarted = true; //  the game Has started
            }
        }

        public void HandleInput()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space)) // Space key = Jump
            {
                if (!gameStarted)
                {
                    StartGame(); // Start the game when space bar is pressed
                }
                Jump(); // Jump action if game started
            }
        }

        public void Update()
        {
            HandleInput(); //  jumping input
            ApplyGravity(); // Apply gravity to the character
        }
    }
}