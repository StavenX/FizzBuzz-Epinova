using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova
{
    /**
     * Provides an abstraction for a set of rules to be used
     * in a MathGame instance.
     */
    public class Rules
    {
        /* Stores the "rules" for which number is to be converted to what String */
        private Dictionary<int, String> ruleList = new Dictionary<int, string>();

        public Rules()
        {

        }

        /* Adds a rule for the given number */
        public void AddRule(int number, string keyword)
        {
            this.ruleList.Add(number, keyword);
        }

        /* Removes the rule for the given number */
        public void RemoveRule(int number)
        {
            this.ruleList.Remove(number);
        }

        /* Returns the input as the single keyword */
        public string GetNumberAsSingleKeyword(int number)
        {
            if (ruleList.ContainsKey(number))
            {
                return ruleList[number];
            }

            /* Empty string if no matching rules for this number */
            return "";
        }

        /* Returns the number as the completed keyword (all rules applied) */
        public string GetNumberAsWholeKeyword(int number)
        {
            string result = "";

            foreach (int key in this.ruleList.Keys)
            {
                if (number % key == 0)
                {
                    result += GetNumberAsSingleKeyword(key);
                }
            }

            /* Prints the keyword if the number has a rule, otherwise prints the number */
            return (result.Length > 0 ? result : number.ToString());
        }
    }
}
