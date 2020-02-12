using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova
{
    /**
     * Defines logic to be used by mathgames that involve converting
     * numbers to keywords in a certain amount of iterations.
     */
    class MathGame
    {
        private Rules rules;        // The ruleset for this game
        private bool isRising;      // Counting upwards or downwards
        private int iterations;     // Amount of iterations 

        public MathGame(Rules ruleList, int iterations, bool isRising)
        {
            this.rules = ruleList;
            this.isRising = isRising;
            this.iterations = iterations; 
        }

        /* Runs the game with given rules, direction and iterations */
        public void Run()
        {           
            if (isRising)
            {
                for (int i = 1; i <= this.iterations; i++)
                {
                    Console.WriteLine(rules.GetNumberAsWholeKeyword(i));
                }
            }
            else
            {
                for (int i = this.iterations; i >= 1; i--)
                {
                    Console.WriteLine(rules.GetNumberAsWholeKeyword(i));
                }
            }
        }

    }
}
