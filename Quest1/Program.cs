using System;
using System.Linq;

namespace YAhmadCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ab";
            string s2 = "eidbboooa";
           var output = GetParmutationString(s1, s2);
            Console.WriteLine(output);
            Console.ReadKey();

        }
        public static bool GetParmutationString(string s1, string s2)
        {
            bool containsPermutation = false;
            char[] thechar = s1.ToCharArray();
            for (int i = 0; i < s2.Length-1; i++)
            {
                var testc = s2.LastIndexOfAny(thechar);
                if (testc > 0)
                {
                    containsPermutation = true;
                }
                else
                {
                    containsPermutation = false;
                }
            }
            
            return containsPermutation;
        }
    }
}
