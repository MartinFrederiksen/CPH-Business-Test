﻿using System;
using System.Collections.Generic;

namespace assignment_02
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex)) //strike
                {
                    score += 10 + strikBonus(frameIndex);
                    frameIndex++;
                } else if (isSpare(frameIndex)) { //spare
                    score += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                } else {
                    score += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }
        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
        private int sumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int strikBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
    }
}
