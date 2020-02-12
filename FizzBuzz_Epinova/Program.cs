using System;
using System.Collections.Generic;

namespace FizzBuzz_Epinova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edvin's (new & better) FizzBuzz / JazzFuzz implementation!\n");

            Rules gameRules = new Rules();

            /* Del 1 */
            gameRules.AddRule(3, "Fizz");
            gameRules.AddRule(5, "Buzz");

            MathGame fizzBuzz = new MathGame(gameRules, 100, true);
            fizzBuzz.Run();

            Console.WriteLine();

            /* Del 2 */
            fizzBuzz.Run();

            gameRules.RemoveRule(3);
            gameRules.RemoveRule(5);

            gameRules.AddRule(4, "Fuzz");
            gameRules.AddRule(9, "Jazz");

            MathGame jazzFuzz = new MathGame(gameRules, 100, false);
            jazzFuzz.Run();

        }

    }
}
