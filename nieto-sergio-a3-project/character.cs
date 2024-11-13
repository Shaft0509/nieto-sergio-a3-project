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
