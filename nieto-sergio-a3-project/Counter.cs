
namespace Game10003
{
    public class Score
    {
        private int score = 0; // Score variable

        //  increment the score
        public void Increment()
        {
            score++;
        }

        //  get the current score
        public int GetScore()
        {
            return score;
        }

        //  draw the score on the screen at the top center
        public void Draw()
        {

            Text.Draw("Score:", 350, 50);

        }
    }
}
