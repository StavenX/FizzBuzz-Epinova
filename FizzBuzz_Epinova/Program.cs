using System;
using System.Collections.Generic;

namespace FizzBuzz_Epinova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edvin's (newest & better) FizzBuzz / JazzFuzz implementation!\n");

            Rules fbRules = new Rules();
            fbRules.AddRule(3, "Fizz");
            fbRules.AddRule(5, "Buzz");

            Rules jfRules = new Rules();
            jfRules.AddRule(9, "Jazz");
            jfRules.AddRule(4, "Fuzz");

            /* Del 1 */
            MathGame.Run(fbRules, 1, 100, 1);            
            Console.WriteLine();

            /* Del 2 */
            MathGame.Run(fbRules, 1, 100, 1);
            MathGame.Run(jfRules, 100, 1, -1);
        }
    }
}
