using System;
using System.Collections.Generic;

namespace FizzBuzz_Epinova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edvin's (new & better) FizzBuzz / JazzFuzz implementation!\n");

            Rules fbRules = new Rules();
            Rules jfRules = new Rules();

            fbRules.AddRule(3, "Fizz");
            fbRules.AddRule(5, "Buzz");

            jfRules.AddRule(4, "Fuzz");
            jfRules.AddRule(9, "Jazz");

            /* Del 1 */
            MathGame fizzBuzz = new MathGame(fbRules, 100, true);
            fizzBuzz.Run();

            Console.WriteLine();

            /* Del 2 */
            fizzBuzz.Run();

            MathGame jazzFuzz = new MathGame(jfRules, 100, false);
            jazzFuzz.Run();

        }

    }
}
