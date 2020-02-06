using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova
{
    public class FizzBuzz : IMathGame
    {
        public string GetNumberAsKeyword(int input)
        {
            string result = "";

            if (input % 3 == 0)
            {
                result += "Fizz";
            }
            if (input % 5 == 0)
            {
                result += "Buzz";
            }

            return (result.Length > 0 ? result : input.ToString()); 
        }

        public void Run(int iterations)
        {
            for (int i = 1; i <= iterations; i++)
            {
                Console.WriteLine(this.GetNumberAsKeyword(i));
            }
        }
    }
}
