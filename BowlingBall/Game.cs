using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {

        private int[] NumberofTimestoroll = new int[21];
        

        int TrackcurrentRoll = 0;

        private bool HasSpare(int frameCount)
        {
            return NumberofTimestoroll[frameCount] + NumberofTimestoroll[frameCount + 1] == 10;
        }

        private bool HasStrike(int frameCount)
        {
            return NumberofTimestoroll[frameCount] == 10;
        }

       /// <summary>
       /// Exposed to users for everytime a Pin is rolled 
       /// </summary>
       /// <param name="pins"> <Int> - number of pins knocked </param>
        public void Roll(int pins)
        {
            NumberofTimestoroll[TrackcurrentRoll++] = pins;
        }

      

        /// <summary>
        /// Exposed for users for getting a score
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            int score = 0;
            int Index = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (HasSpare(Index))
                {
                    score = score + 10 + NumberofTimestoroll[Index + 2];
                    Index = Index + 2;
                }
                else if (HasStrike(Index))
                {
                    score = score + 10 + NumberofTimestoroll[Index + 1] + NumberofTimestoroll[Index + 2];
                    Index++;
                }
                else
                {
                    score = score +  NumberofTimestoroll[Index] + NumberofTimestoroll[Index + 1];
                    Index = Index+ 2;
                }

            }

            return score;
        }
       
       
    }
}
