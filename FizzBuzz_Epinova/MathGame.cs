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
        /* Runs the game with given rules, start-value, end-value and incrementation amount */
        public static void Run(Rules ruleList, int start, int end, int incrementAmount)
        {
            /* Do not let the user use 0 as 'incrementAmount' */
            if (incrementAmount == 0)
            {
                throw new Exception("The incrementing-value can not be 0.");
            }       

            /* Decides which direction the loop goes */
            bool isRising = incrementAmount >= 0;

            /* Figure out the correct order of 'start' and 'end' */
            int highestNumber = Math.Max(start, end);
            int lowestNumber = Math.Min(start, end);

            /* Make sure start & end are placed accordingly to the direction*/
            if (isRising)
            {
                start = lowestNumber;
                end = highestNumber;
            } else
            {
                start = highestNumber;
                end = lowestNumber;
            }

            /* Increments 'i' with 'incrementValue' until 'i' have not met 'end' yet */
            int i = start; 
            while (isRising ? i <= end : i >= end)
            {
                Console.WriteLine(ruleList.GetNumberAsWholeKeyword(i));
                i += incrementAmount;
            }

        }

    }
}
