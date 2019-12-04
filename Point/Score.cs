using System;
namespace Point
{
    
     class Score
        {
            int score = 0;
            public int GetScore() { return score; }
            public void AddPoint() { score++; }
            public void ResetScore() { score = 0; }
        }
    
}
