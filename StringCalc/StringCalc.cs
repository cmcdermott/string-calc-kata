using System;
using System.Linq;

namespace StringCalc
{
    public class StringCalc
    {
        public int Add(string numbers) // "1,2,3,4,5"
        {
            int[] numbersArray = numbers.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            int currentNumber;
            int sum =0;

            for(int i = 0; i < numbersArray.Length -1; i++)
            {
                currentNumber = numbersArray[i];
                sum = sum + currentNumber;

                
            }

            return sum;
        }
    }
}
