using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova
{
    /**
     * Defines logic to be used by mathgames that involve converting
     * numbers to keywords in an amount of iterations.
     */
    public interface IMathGame
    {
        /* Returns the input as the keyword, or itself as a String */
        public string GetNumberAsKeyword(int input);

        /* Runs the game logic for each implementation */
        public void Run(int iterations);
    }
}
