using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {
        private int pin, pin1, pin2 = 0;
        private int temScore = 0;
        private int finalScore = 0;
        private int count = 0;
        private bool firstStrike = false;
        private bool secondStrike = false;

        public void SetPins(int p)
        {
            count++;
            if (count % 2 == 1)
            {
                pin1 = p;
                LastTime();
                if (pin1 == 10) firstStrike = true;
            }
            else
            {
                pin2 = p;
            }
            if (pin1 + pin2 == 10 && pin2 != 0 ) secondStrike = true;
            if (pin1 == 10 && count % 2 == 1) firstStrike = true;
            if (count % 2 == 0) PinToScore();
        }
        public void LastTime()
        {
            if (firstStrike == true) finalScore = finalScore + pin1;
 
        }
        public int GetFinalScore()
        {
            return this.finalScore;
        }
        private void PinToScore()
        {
            pin = pin1 + pin2;
            temScore = temScore + pin; 
            if (firstStrike)
            {
                finalScore = finalScore + pin;
                firstStrike = false;
            }
            if (secondStrike)
            {
                finalScore = finalScore + pin1;
            }
            finalScore = finalScore + pin;
        }
    }
}
