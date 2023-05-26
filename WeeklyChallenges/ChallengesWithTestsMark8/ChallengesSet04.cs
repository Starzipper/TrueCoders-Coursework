using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = { str1, str2, str3, str4 };
            return strings.Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength3 + sideLength1 > sideLength2))
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if ((objs.Length / 2) < (objs.Where(obj => obj == null).Count()))
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || !numbers.Where(num => num % 2 == 0).Any())
            {
                return 0;
            }
            return numbers.Where(num => num % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            int product = 1;
            while (number > 0)
            {
                product *= number;
                number--;
            }
            return product;
        }
    }
}
