using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char letter in alphabet)
            {
                if (letter == c)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length >= str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0) ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number < 0) ? 0 : number / 2;
        }
    }
}
