using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            
            foreach (bool value in vals)
            {
                if (value == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            return (numbers.Sum() % 2 != 0) ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
            {
                return false;
            }
            
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            bool isFound;

            for (int i = 0; i < password.Length; i++)
            {
                isFound = false;
                foreach (char letter in alphabet)
                {
                    if (letter == password[i])
                    {
                        hasUpper = true;
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    foreach (char letter in alphabet.ToLower())
                    {
                        if (letter == password[i])
                        {
                            hasLower = true;
                            isFound = true;
                            break;
                        }
                    }
                }
                if (!isFound)
                {
                    foreach (char number in numbers)
                    {
                        if (number == password[i])
                        {
                            hasNumber = true;
                            break;
                        }
                    }
                }
            }

            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (val == null || val.Length < 0)
            {
                return '\0';
            }
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (val == null || val.Length < 0)
            {
                return '\0';
            }
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            return (nums.Length == 1) ? nums[0] : nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int oddsCounter = 1;
            for(int i = 0; i < 50; i++)
            {
                odds[i] = oddsCounter;
                oddsCounter += 2;
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null || words.Length == 0){}
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
