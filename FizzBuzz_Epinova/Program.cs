using System;
using System.Collections.Generic;

namespace FizzBuzz_Epinova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edvin's FizzBuzz / JazzFuzz implementation!\n");

            IMathGame game;

            /* Del 1 */
            Console.WriteLine("- Del 1- ");
            game = new FizzBuzz();
            game.Run(100);

            Console.WriteLine();

            /* Del 2 */
            Console.WriteLine("- Del 2- ");
            game.Run(100);
            game = new JazzFuzz();
            game.Run(100);
        }

        /**
         * EXTRA IMPLEMENTATION I MADE!
         * 
         * FizzBuzz implementation that uses a Dictionary to keep track of rules
         * attached to certain numbers.
         * In the original definition of FizzBuzz, the number 3 is attached to 'Fizz' and
         * so on. 
         * 
         * In this implementation, is is quick to add new rules by just adding a combination
         * of a number and the attached String to the dictionary. 
         * This results in more odd combinations.
         */
        static void FizzBuzzExtended()
        {
            /* Stores the "rules" for which number is to be printed out as what String */
            Dictionary<int, String> rules = new Dictionary<int, string>();

            /* Adds the different rules for the numbers */
            rules.Add(3, "Fizz");
            rules.Add(4, "Quad");
            rules.Add(5, "Buzz");
            rules.Add(7, "Pop");
            rules.Add(8, "Woof");
            rules.Add(15, "OxAb");

            /* Main loop here */
            for (int i = 1; i <= 45; i++)
            {
                /* Stores the final result to be printed out */
                string result = "";   

                foreach (int key in rules.Keys)
                {
                    if (i % key == 0)
                    {
                        /* Append the rule-combination onto the result */
                        result += rules[key];
                    }
                }
                /* Prints the keyword if the number has a rule, otherwise prints the number */
                Console.WriteLine(result.Length > 0 ? result : i.ToString());
            }
        }

    }
}
