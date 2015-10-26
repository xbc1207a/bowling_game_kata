using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {
        private int pin = 0;
        private int score = 0;
        private bool allHit = false;

        public void SetPins(int p)
        {
            if (p == 10) allHit = true;
            this.pin = p;
        }
        public int GetFinalScore()
        {
            return this.score;
        }
        private int PinToScore()
        {
            if(allHit)
        }
    }
}
