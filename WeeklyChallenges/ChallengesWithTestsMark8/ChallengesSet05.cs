using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            bool isDivisible = false;
            int divisibleNumber = startNumber + 1;
            while (!isDivisible)
            {
                if (divisibleNumber % n == 0)
                {
                    isDivisible = true;
                }
                else
                {
                    divisibleNumber++;
                }
            }
            return divisibleNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses != null && businesses.Any())
            {
                foreach (Business business in businesses)
                {
                    if (business.TotalRevenue == 0)
                    {
                        business.Name = "CLOSED";
                    }
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            bool isAscending = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 < numbers.Length)
                {
                    if (numbers[i+1] - numbers[i] < 0)
                    {
                        isAscending = false;
                        break;
                    }
                }
            }
            return isAscending;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            int sum = 0;
            bool evenSwitch = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (evenSwitch)
                {
                    sum += numbers[i];
                }
                
                if (numbers[i] % 2 == 0)
                {
                    evenSwitch = true;
                }
                else
                {
                    evenSwitch = false;
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || !words.Any())
            {
                return "";
            }
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Any())
                {
                    if (i + 1 >= words.Length)
                    {
                        sentence += words[i].Trim() + ".";
                    }
                    else
                    {
                        sentence += words[i].Trim() + " ";
                    }
                }

            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[0];
            }
            var fourthElements = new double[elements.Count / 4];
            int j = 0;
            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElements[j] = elements[i];
                j++;
            }
            return fourthElements;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length <= 1)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
