using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (string w in words)
            {
                if (w != null)
                {
                    if (ignoreCase)
                    {
                        if (w.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (w == word)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num > 7)
            {
                if (num%2 != 0 && num%3 != 0 && num%5 != 0 && num%7 != 0)
                {
                    return true;
                }
            }
            else
            {
                if (num == 2 || num == 3 || num == 5 || num == 7)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null || !str.Any())
            {
                return -1;
            }
            int lastUnique = -1;
            bool isUnique = true;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    lastUnique = i;
                }
                isUnique = true;
            }
            return lastUnique;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            int maxCount = 1;
            int compCount = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 < numbers.Length)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        compCount++;
                        if (compCount > maxCount)
                        {
                            maxCount = compCount;
                        }
                    }
                    else
                    {
                        compCount = 1;
                    }
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count < n || n <= 0)
            {
                return new double[0];
            }
            double[] result = new double[elements.Count/n];
            int j = 0;
            for (int i = n-1; i < elements.Count; i += n)
            {
                result[j] = elements[i];
                j++;
            }
            return result;
        }
    }
}
