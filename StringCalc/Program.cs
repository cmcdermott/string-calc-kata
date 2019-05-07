using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StringCalc
    {
        public int Add(string numbers) // "1,2,3,4,5"
        {
            var sum = 0;
            var delimter = new List<string> { ",", "\n" };

            if (string.IsNullOrEmpty(numbers))
                return 0;
            
            numbers = FindDelimiter(numbers, delimter);
            var numbersArray = SplitNumberString(numbers, delimter);

            for (int i = 0; i < numbersArray.Length; i++)
            {
                CheckNegative(numbersArray[i]);

                if (numbersArray[i] <= 1000)
                {
                    var currentNumber = numbersArray[i];
                    sum += currentNumber;
                }
            }

            return sum;
        }

        private static int[] SplitNumberString(string numbers, List<string> delimter)
        {
            return numbers.Split(delimter.ToArray(), new StringSplitOptions()).Select(x => Convert.ToInt32(x)).ToArray();
        }

        private static string FindDelimiter(string numbers, List<string> delimter)
        {
            if (!numbers.StartsWith("//"))
                return numbers;
            
            var newDelimiter = numbers.Substring(2, 1);
            delimter.Add(newDelimiter);

            return numbers.Remove(0, 4);
        }

        private static void CheckNegative(int i)
        {
            if (i < 0)
                throw new Exception("Negatives not allowed: " + i);
        }
    }
}
