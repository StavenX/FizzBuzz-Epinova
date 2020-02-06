using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova
{
    public class JazzFuzz : IMathGame
    {
        public string GetNumberAsKeyword(int input)
        {
            string result = "";

            if (input % 9 == 0)
            {
                result += "Jazz";
            }
            if (input % 4 == 0)
            {
                result += "Fuzz";
            }

            return (result.Length > 0 ? result : input.ToString());
        }

        public void Run(int iterations)
        {
            for (int i = iterations; i >= 1; i--)
            {
                Console.WriteLine(this.GetNumberAsKeyword(i));
            }
        }
    }
}
